CREATE DATABASE IF NOT EXISTS db_part_komputer;

USE db_part_komputer;

CREATE TABLE IF NOT EXISTS tbkategori (
    KodeKategori  VARCHAR(10)  NOT NULL,
    NamaKategori  VARCHAR(100) NOT NULL,
    PRIMARY KEY (KodeKategori)
) ENGINE=InnoDB;

INSERT INTO tbkategori VALUES
('KAT01', 'Processor (CPU)'),
('KAT02', 'Motherboard'),
('KAT03', 'RAM'),
('KAT04', 'Storage SSD'),
('KAT05', 'Storage HDD'),
('KAT06', 'VGA / GPU'),
('KAT07', 'Power Supply (PSU)'),
('KAT08', 'Casing'),
('KAT09', 'CPU Cooler'),
('KAT10', 'Monitor'),
('KAT11', 'Keyboard & Mouse'),
('KAT12', 'Sound Card / Speaker');

CREATE TABLE IF NOT EXISTS tbmerk (
    KodeMerk  VARCHAR(10)  NOT NULL,
    NamaMerk  VARCHAR(100) NOT NULL,
    PRIMARY KEY (KodeMerk)
) ENGINE=InnoDB;

INSERT INTO tbmerk VALUES
('MRK01', 'Intel'),
('MRK02', 'AMD'),
('MRK03', 'NVIDIA'),
('MRK04', 'ASUS'),
('MRK05', 'MSI'),
('MRK06', 'Gigabyte'),
('MRK07', 'ASRock'),
('MRK08', 'Kingston'),
('MRK09', 'Corsair'),
('MRK10', 'G.Skill'),
('MRK11', 'Samsung'),
('MRK12', 'Western Digital'),
('MRK13', 'Seagate'),
('MRK14', 'Seasonic'),
('MRK15', 'DeepCool'),
('MRK16', 'Noctua'),
('MRK17', 'LG'),
('MRK18', 'Logitech');

CREATE TABLE IF NOT EXISTS tbpart (
    KodePart     VARCHAR(20)    NOT NULL,
    NamaPart     VARCHAR(150)   NOT NULL,
    KodeKategori VARCHAR(10)    NOT NULL,
    KodeMerk     VARCHAR(10)    NOT NULL,
    Harga        DECIMAL(15,2)  NOT NULL DEFAULT 0,
    Stok         INT            NOT NULL DEFAULT 0,
    PRIMARY KEY (KodePart),
    FOREIGN KEY (KodeKategori) REFERENCES tbkategori(KodeKategori),
    FOREIGN KEY (KodeMerk)     REFERENCES tbmerk(KodeMerk)
) ENGINE=InnoDB;

INSERT INTO tbpart (KodePart, NamaPart, KodeKategori, KodeMerk, Harga, Stok) VALUES
-- CPU
('CPU001', 'Intel Core i9-14900K',       'KAT01', 'MRK01', 8500000,  5),
('CPU002', 'Intel Core i5-14400F',       'KAT01', 'MRK01', 2850000, 15),
('CPU003', 'AMD Ryzen 9 7950X',          'KAT01', 'MRK02', 9200000,  4),
('CPU004', 'AMD Ryzen 5 7600X',          'KAT01', 'MRK02', 2650000, 12),

-- Motherboard
('MBD001', 'ASUS ROG Strix Z790-E',      'KAT02', 'MRK04', 6800000,  6),
('MBD002', 'MSI MAG B650 Tomahawk',      'KAT02', 'MRK05', 3200000, 10),
('MBD003', 'Gigabyte B760M DS3H',        'KAT02', 'MRK06', 1450000, 20),

-- RAM
('RAM001', 'Corsair Vengeance DDR5 32GB','KAT03', 'MRK09', 1850000, 25),
('RAM002', 'G.Skill Trident Z5 64GB',   'KAT03', 'MRK10', 4200000,  8),
('RAM003', 'Kingston Fury Beast 16GB',   'KAT03', 'MRK08',  650000, 40),

-- SSD
('SSD001', 'Samsung 990 Pro 1TB',        'KAT04', 'MRK11', 1650000, 18),
('SSD002', 'WD Black SN850X 2TB',        'KAT04', 'MRK12', 2900000, 10),
('SSD003', 'Kingston A400 480GB',        'KAT04', 'MRK08',  450000, 35),

-- HDD
('HDD001', 'Seagate Barracuda 2TB',      'KAT05', 'MRK13',  550000, 30),
('HDD002', 'WD Blue 4TB',                'KAT05', 'MRK12',  950000, 20),

-- GPU / VGA
('GPU001', 'ASUS ROG RTX 4090 24GB',    'KAT06', 'MRK04', 29500000,  3),
('GPU002', 'MSI RTX 4070 Ti 12GB',      'KAT06', 'MRK05', 12500000,  7),
('GPU003', 'Gigabyte RX 7800 XT 16GB',  'KAT06', 'MRK06', 7200000, 10),

-- PSU
('PSU001', 'Seasonic Focus GX-1000',     'KAT07', 'MRK14', 2100000,  8),
('PSU002', 'Corsair RM850x',             'KAT07', 'MRK09', 1650000, 12),

-- Cooler
('CLR001', 'Noctua NH-D15',              'KAT09', 'MRK16', 1350000, 10),
('CLR002', 'DeepCool AK620',             'KAT09', 'MRK15',  750000, 20),
('CLR003', 'Corsair H150i Elite Capellix','KAT09', 'MRK09', 2450000,  8),

-- Monitor
('MON001', 'LG 27GP850-B 27"',          'KAT10', 'MRK17', 4200000,  6),
('MON002', 'ASUS ROG Swift PG279QM',    'KAT10', 'MRK04', 9500000,  3);

CREATE TABLE IF NOT EXISTS tbpenjualan (
    NomorNota   VARCHAR(30)    NOT NULL,
    TanggalJual DATE           NOT NULL,
    NamaPembeli VARCHAR(150)   NOT NULL,
    TotalItem   INT            NOT NULL DEFAULT 0,
    TotalHarga  DECIMAL(15,2)  NOT NULL DEFAULT 0,
    Keterangan  TEXT,
    PRIMARY KEY (NomorNota)
) ENGINE=InnoDB;

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