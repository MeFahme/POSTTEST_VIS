-- ============================================================
--  SISTEM MANAJEMEN & INVENTORI SPAREPART MOTOR
--  Script SQL - MySQL
-- ============================================================

CREATE DATABASE IF NOT EXISTS db_sparepart_motor
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE db_sparepart_motor;

-- ------------------------------------------------------------
-- 1. TABEL USERS
--    Menyimpan akun login: admin, kasir, mekanik
-- ------------------------------------------------------------
CREATE TABLE users (
    id_user   INT          NOT NULL AUTO_INCREMENT,
    nama      VARCHAR(100) NOT NULL,
    username  VARCHAR(50)  NOT NULL UNIQUE,
    password  VARCHAR(255) NOT NULL,
    role      ENUM('admin','kasir','mekanik') NOT NULL,
    PRIMARY KEY (id_user)
) ENGINE=InnoDB;

-- Data awal: akun admin default
INSERT INTO users (nama, username, password, role) VALUES
('Administrator', 'admin', '1234', 'admin');

-- Catatan: ganti password dengan hasil hashing di VB
--          sebelum deploy ke produksi


-- ------------------------------------------------------------
-- 2. TABEL SPAREPART
--    Master data sparepart & stok
-- ------------------------------------------------------------
CREATE TABLE sparepart (
    id_part    INT            NOT NULL AUTO_INCREMENT,
    nama_part  VARCHAR(150)   NOT NULL,
    kategori   VARCHAR(50),
    merk_motor VARCHAR(50),
    harga_jual DECIMAL(12,2)  NOT NULL DEFAULT 0,
    stok       INT            NOT NULL DEFAULT 0,
    PRIMARY KEY (id_part)
) ENGINE=InnoDB;

-- Data sparepart: Honda Vario & Yamaha MX King
INSERT INTO sparepart (nama_part, kategori, merk_motor, harga_jual, stok) VALUES
-- Honda Vario
('Kampas Rem Depan',   'Rem',      'Honda Vario',  45000,  15),
('Kampas Rem Belakang','Rem',      'Honda Vario',  40000,  15),
('Busi NGK',           'Pengapian','Honda Vario',  25000,  20),
('Filter Udara',       'Filter',   'Honda Vario',  35000,  10),
-- Yamaha MX King
('Kampas Rem Depan',   'Rem',      'Yamaha MX King', 50000, 15),
('Kampas Rem Belakang','Rem',      'Yamaha MX King', 45000, 15),
('Busi NGK',           'Pengapian','Yamaha MX King', 25000, 20),
('Filter Udara',       'Filter',   'Yamaha MX King', 38000, 10);


-- ------------------------------------------------------------
-- 3. TABEL TRANSAKSI
--    Header transaksi (beli part saja / servis saja / keduanya)
--    no_transaksi di-generate otomatis di VB, format: TRX-YYYYMMDD-XXX
--    Contoh: TRX-20250426-001
-- ------------------------------------------------------------
CREATE TABLE transaksi (
    no_transaksi  VARCHAR(20)   NOT NULL,
    jenis         ENUM('part','servis','keduanya') NOT NULL,
    nama_pelanggan VARCHAR(100) NOT NULL,
    no_hp         VARCHAR(20),
    id_user       INT           NOT NULL,           -- kasir yg input
    total_harga   DECIMAL(12,2) NOT NULL DEFAULT 0,
    status_bayar  ENUM('lunas','belum')  NOT NULL DEFAULT 'belum',
    tgl_transaksi DATETIME      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (no_transaksi),
    CONSTRAINT fk_trx_user FOREIGN KEY (id_user)
        REFERENCES users(id_user)
) ENGINE=InnoDB;


-- ------------------------------------------------------------
-- 4. TABEL DETAIL_TRANSAKSI
--    Rincian sparepart per transaksi
-- ------------------------------------------------------------
CREATE TABLE detail_transaksi (
    id_detail     INT           NOT NULL AUTO_INCREMENT,
    no_transaksi  VARCHAR(20)   NOT NULL,
    id_part       INT           NOT NULL,
    qty           INT           NOT NULL DEFAULT 1,
    harga_satuan  DECIMAL(12,2) NOT NULL,
    subtotal      DECIMAL(12,2) NOT NULL,
    PRIMARY KEY (id_detail),
    CONSTRAINT fk_det_trx  FOREIGN KEY (no_transaksi)
        REFERENCES transaksi(no_transaksi)
        ON DELETE CASCADE,
    CONSTRAINT fk_det_part FOREIGN KEY (id_part)
        REFERENCES sparepart(id_part)
) ENGINE=InnoDB;


-- ------------------------------------------------------------
-- 5. TABEL SERVIS
--    Data motor yang masuk servis
--    no_servis di-generate otomatis di VB, format: SRV-YYYYMMDD-XXX
--    Contoh: SRV-20250426-001
--    no_transaksi nullable: motor bisa masuk dulu, bayar belakangan
-- ------------------------------------------------------------
CREATE TABLE servis (
    no_servis      VARCHAR(20)  NOT NULL,
    no_transaksi   VARCHAR(20)  DEFAULT NULL,        -- nullable
    nama_pelanggan VARCHAR(100) NOT NULL,
    no_polisi      VARCHAR(15)  NOT NULL,
    merk_motor     VARCHAR(50)  NOT NULL,
    keluhan        TEXT,
    id_mekanik     INT          NOT NULL,
    status         ENUM('antri','proses','menunggu_part','selesai')
                                NOT NULL DEFAULT 'antri',
    biaya_jasa     DECIMAL(12,2) NOT NULL DEFAULT 0,
    tgl_masuk      DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP,
    tgl_selesai    DATETIME     DEFAULT NULL,
    PRIMARY KEY (no_servis),
    CONSTRAINT fk_srv_trx      FOREIGN KEY (no_transaksi)
        REFERENCES transaksi(no_transaksi)
        ON DELETE SET NULL,
    CONSTRAINT fk_srv_mekanik  FOREIGN KEY (id_mekanik)
        REFERENCES users(id_user)
) ENGINE=InnoDB;


-- ------------------------------------------------------------
-- 6. TABEL LOG_SERVIS
--    Riwayat perubahan status motor — ditampilkan ke layar publik
-- ------------------------------------------------------------
CREATE TABLE log_servis (
    id_log      INT          NOT NULL AUTO_INCREMENT,
    no_servis   VARCHAR(20)  NOT NULL,
    status_baru VARCHAR(50)  NOT NULL,
    catatan     TEXT,
    id_mekanik  INT          NOT NULL,
    waktu       DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (id_log),
    CONSTRAINT fk_log_srv      FOREIGN KEY (no_servis)
        REFERENCES servis(no_servis)
        ON DELETE CASCADE,
    CONSTRAINT fk_log_mekanik  FOREIGN KEY (id_mekanik)
        REFERENCES users(id_user)
) ENGINE=InnoDB;


-- ============================================================
--  TRIGGER: Kurangi stok otomatis saat detail_transaksi diisi
-- ============================================================
DELIMITER $$

CREATE TRIGGER trg_kurangi_stok
AFTER INSERT ON detail_transaksi
FOR EACH ROW
BEGIN
    UPDATE sparepart
    SET stok = stok - NEW.qty
    WHERE id_part = NEW.id_part;
END$$

DELIMITER ;


-- ============================================================
--  VIEW: Status servis untuk layar publik pelanggan
--  Menampilkan semua motor beserta status & log terakhir
-- ============================================================
CREATE VIEW v_status_motor AS
SELECT
    s.no_servis,
    s.nama_pelanggan,
    s.no_polisi,
    s.merk_motor,
    s.keluhan,
    s.status,
    s.tgl_masuk,
    s.tgl_selesai,
    u.nama          AS nama_mekanik,
    l.catatan       AS catatan_terakhir,
    l.waktu         AS update_terakhir
FROM servis s
JOIN users u
    ON s.id_mekanik = u.id_user
LEFT JOIN log_servis l
    ON l.id_log = (
        SELECT MAX(id_log)
        FROM log_servis
        WHERE no_servis = s.no_servis
    )
ORDER BY s.tgl_masuk DESC;


-- ============================================================
--  VIEW: Laporan penjualan (untuk admin)
-- ============================================================
CREATE VIEW v_laporan_penjualan AS
SELECT
    t.no_transaksi,
    t.tgl_transaksi,
    t.jenis,
    t.nama_pelanggan,
    t.no_hp,
    u.nama          AS nama_kasir,
    t.total_harga,
    t.status_bayar
FROM transaksi t
JOIN users u ON t.id_user = u.id_user
ORDER BY t.tgl_transaksi DESC;


-- ============================================================
--  VIEW: Stok sparepart (peringatan stok rendah < 5)
-- ============================================================
CREATE VIEW v_stok_sparepart AS
SELECT
    id_part,
    nama_part,
    kategori,
    merk_motor,
    harga_jual,
    stok,
    CASE
        WHEN stok = 0   THEN 'Habis'
        WHEN stok < 5   THEN 'Hampir Habis'
        ELSE                 'Tersedia'
    END AS keterangan_stok
FROM sparepart
ORDER BY stok ASC;

-- ============================================================
--  SELESAI
-- ============================================================
