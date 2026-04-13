-- ============================================================
--  UPDATE DATABASE – Tambah Tabel Penjualan
--  Jalankan ini SETELAH database_setup.sql yang lama
-- ============================================================

USE db_part_komputer;

-- ────────────────────────────────────────────────────────────
-- Tabel HEADER PENJUALAN (satu baris = satu nota)
-- ────────────────────────────────────────────────────────────
CREATE TABLE IF NOT EXISTS tbpenjualan (
    NomorNota   VARCHAR(30)    NOT NULL,
    TanggalJual DATE           NOT NULL,
    NamaPembeli VARCHAR(150)   NOT NULL,
    TotalItem   INT            NOT NULL DEFAULT 0,
    TotalHarga  DECIMAL(15,2)  NOT NULL DEFAULT 0,
    Keterangan  TEXT,
    PRIMARY KEY (NomorNota)
) ENGINE=InnoDB;

-- ────────────────────────────────────────────────────────────
-- Tabel DETAIL PENJUALAN (item-item dalam satu nota)
-- ────────────────────────────────────────────────────────────
CREATE TABLE IF NOT EXISTS tbdetailpenjualan (
    IdDetail     INT            NOT NULL AUTO_INCREMENT,
    NomorNota    VARCHAR(30)    NOT NULL,
    KodePart     VARCHAR(20)    NOT NULL,
    Jumlah       INT            NOT NULL DEFAULT 1,
    HargaSatuan  DECIMAL(15,2)  NOT NULL DEFAULT 0,
    Subtotal     DECIMAL(15,2)  NOT NULL DEFAULT 0,
    PRIMARY KEY (IdDetail),
    FOREIGN KEY (NomorNota) REFERENCES tbpenjualan(NomorNota),
    FOREIGN KEY (KodePart)  REFERENCES tbpart(KodePart)
) ENGINE=InnoDB;

-- ────────────────────────────────────────────────────────────
-- Cek tabel sudah terbuat
-- ────────────────────────────────────────────────────────────
SHOW TABLES;
