-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 27, 2019 at 04:47 PM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.2.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `skripsi2`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_analisa`
--

CREATE TABLE `tbl_analisa` (
  `kode_analisa` varchar(5) NOT NULL,
  `kode_CPB` varchar(4) NOT NULL,
  `kode_pekerjaan` varchar(2) NOT NULL,
  `kode_penghasilan` varchar(2) NOT NULL,
  `kode_tanggungan` varchar(2) NOT NULL,
  `kode_atap` varchar(2) NOT NULL,
  `kode_dinding` varchar(2) NOT NULL,
  `kode_lantai` varchar(2) NOT NULL,
  `tanggal` date NOT NULL,
  `admin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_atap`
--

CREATE TABLE `tbl_atap` (
  `kode_atap` varchar(2) NOT NULL,
  `kondisi_atap` varchar(100) NOT NULL,
  `bobot` float NOT NULL,
  `nilai` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_atap`
--

INSERT INTO `tbl_atap` (`kode_atap`, `kondisi_atap`, `bobot`, `nilai`) VALUES
('01', 'Baik-baik saja', 0.2, 1),
('02', 'Bocor', 0.2, 2),
('03', 'Bocor dan usuk keropos', 0.2, 3),
('04', 'Bocor, usuk keropos & gordin keropos', 0.2, 4),
('05', 'Bocor, usuk keropos, gordin keropos & kuda-kuda keropos', 0.2, 5);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_cpb`
--

CREATE TABLE `tbl_cpb` (
  `kode_CPB` varchar(4) NOT NULL,
  `no_KK` varchar(25) NOT NULL,
  `nama_kepala_keluarga` varchar(50) NOT NULL,
  `alamat` varchar(250) NOT NULL,
  `RT` varchar(50) NOT NULL,
  `kelurahan` varchar(250) NOT NULL,
  `distrik` varchar(250) NOT NULL,
  `status` varchar(2) NOT NULL DEFAULT 'A'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_dinding`
--

CREATE TABLE `tbl_dinding` (
  `kode_dinding` varchar(2) NOT NULL,
  `kondisi_dinding` varchar(100) NOT NULL,
  `bobot` float NOT NULL,
  `nilai` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_dinding`
--

INSERT INTO `tbl_dinding` (`kode_dinding`, `kondisi_dinding`, `bobot`, `nilai`) VALUES
('01', 'Baik-baik saja', 0.2, 1),
('02', 'Terbuat dari semen dan papan dengan kondisi keropos', 0.2, 2),
('03', 'Terbuat dari papan dengan kondisi keropos', 0.2, 3),
('04', 'Terbuat dari papan dengan kondisi keropos & penyangga keropos', 0.2, 4),
('05', 'Terbuat dari papan dengan kondisi keropos,  penyangga keropos & kondisi dinding miring', 0.2, 5);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_histori`
--

CREATE TABLE `tbl_histori` (
  `KODE_HISTORI` varchar(25) DEFAULT NULL,
  `NM_HISTORI` varchar(250) DEFAULT NULL,
  `TANGGAL` varchar(25) DEFAULT NULL,
  `KODE_RANKING` varchar(25) DEFAULT NULL,
  `RANKING` varchar(25) DEFAULT NULL,
  `KODE_CPB` varchar(25) DEFAULT NULL,
  `NAMA_CPB` varchar(250) DEFAULT NULL,
  `ALAMAT_CPB` text DEFAULT NULL,
  `C1_PEKERJAAN` text DEFAULT NULL,
  `C2_PENGHASILAN` text DEFAULT NULL,
  `C3_TANGGUNGAN` text DEFAULT NULL,
  `C4_ATAP` text DEFAULT NULL,
  `C5_DINDING` text DEFAULT NULL,
  `C6_LANTAI` text DEFAULT NULL,
  `NILAI` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_lantai`
--

CREATE TABLE `tbl_lantai` (
  `kode_lantai` varchar(2) NOT NULL,
  `kondisi_lantai` varchar(100) NOT NULL,
  `bobot` float NOT NULL,
  `nilai` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_lantai`
--

INSERT INTO `tbl_lantai` (`kode_lantai`, `kondisi_lantai`, `bobot`, `nilai`) VALUES
('01', 'Baik-baik saja', 0.2, 1),
('02', 'Terbuat dari tehel dengan kondisi retak-retak', 0.2, 2),
('03', 'Terbuat dari semen/cor dengan kondisi berlubang/retak-retak', 0.2, 3),
('04', 'Terbuat dari papan dengan kondisi keropos', 0.2, 4),
('05', 'Terbuat dari tanah dan beralaskan karpet', 0.2, 5);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pekerjaan`
--

CREATE TABLE `tbl_pekerjaan` (
  `kode_pekerjaan` varchar(2) NOT NULL,
  `pekerjaan` varchar(50) NOT NULL,
  `bobot` float NOT NULL,
  `nilai` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_pekerjaan`
--

INSERT INTO `tbl_pekerjaan` (`kode_pekerjaan`, `pekerjaan`, `bobot`, `nilai`) VALUES
('01', 'Wiraswasta', 0.15, 1),
('02', 'Buruh', 0.15, 2),
('03', 'Sopir Taxi/Gojek', 0.15, 3),
('04', 'Petani/Perkebun', 0.15, 4);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_penghasilan`
--

CREATE TABLE `tbl_penghasilan` (
  `kode_penghasilan` varchar(2) NOT NULL,
  `jumlah_penghasilan` varchar(50) NOT NULL,
  `bobot` float NOT NULL,
  `nilai` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_penghasilan`
--

INSERT INTO `tbl_penghasilan` (`kode_penghasilan`, `jumlah_penghasilan`, `bobot`, `nilai`) VALUES
('01', '1.500.000 - <2.300.000', 0.15, 1),
('02', '1.000.000 - <1.500.000', 0.15, 2),
('03', '100.000 - <1.000.000', 0.15, 3);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_tanggungan_jiwa`
--

CREATE TABLE `tbl_tanggungan_jiwa` (
  `kode_tanggungan` varchar(2) NOT NULL,
  `jumlah_tanggungan` varchar(50) NOT NULL,
  `bobot` float NOT NULL,
  `nilai` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_tanggungan_jiwa`
--

INSERT INTO `tbl_tanggungan_jiwa` (`kode_tanggungan`, `jumlah_tanggungan`, `bobot`, `nilai`) VALUES
('01', '1 - 2 orang', 0.1, 1),
('02', '3 - 4 orang', 0.1, 2),
('03', '5 - 6 orang', 0.1, 3),
('04', '7 - 12 orang', 0.1, 4);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `kode_user` varchar(5) NOT NULL,
  `nama_user` varchar(50) NOT NULL,
  `password_user` varchar(50) NOT NULL,
  `level_user` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`kode_user`, `nama_user`, `password_user`, `level_user`) VALUES
('ADM01', 'admin', 'admin', 'ADMIN'),
('ADM02', 'pimpinan', 'pimpinan', 'PIMPINAN');

-- --------------------------------------------------------

--
-- Table structure for table `tp_normalisasi`
--

CREATE TABLE `tp_normalisasi` (
  `KODE` varchar(5) NOT NULL,
  `kode_CPB` varchar(4) NOT NULL,
  `pekerjaan` float NOT NULL,
  `penghasilan` float NOT NULL,
  `tanggungan` float NOT NULL,
  `atap` float NOT NULL,
  `dinding` float NOT NULL,
  `lantai` float NOT NULL,
  `tanggal` date NOT NULL,
  `admin` varchar(50) NOT NULL,
  `total` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tp_normalisasi_akar`
--

CREATE TABLE `tp_normalisasi_akar` (
  `KODE` varchar(5) NOT NULL,
  `kode_CPB` varchar(4) NOT NULL,
  `pekerjaan` float NOT NULL,
  `penghasilan` float NOT NULL,
  `tanggungan` float NOT NULL,
  `atap` float NOT NULL,
  `dinding` float NOT NULL,
  `lantai` float NOT NULL,
  `tanggal` date NOT NULL,
  `admin` varchar(50) NOT NULL,
  `total` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tp_normalisasi_bobot`
--

CREATE TABLE `tp_normalisasi_bobot` (
  `KODE` varchar(5) NOT NULL,
  `kode_CPB` varchar(4) NOT NULL,
  `pekerjaan` float NOT NULL,
  `penghasilan` float NOT NULL,
  `tanggungan` float NOT NULL,
  `atap` float NOT NULL,
  `dinding` float NOT NULL,
  `lantai` float NOT NULL,
  `tanggal` date NOT NULL,
  `admin` varchar(50) NOT NULL,
  `total` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tp_normalisasi_maxmin`
--

CREATE TABLE `tp_normalisasi_maxmin` (
  `pekerjaan` float NOT NULL,
  `penghasilan` float NOT NULL,
  `tanggungan` float NOT NULL,
  `atap` float NOT NULL,
  `dinding` float NOT NULL,
  `lantai` float NOT NULL,
  `tanggal` date NOT NULL,
  `admin` varchar(50) NOT NULL,
  `keterangan` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tp_ranking`
--

CREATE TABLE `tp_ranking` (
  `KODE` varchar(5) NOT NULL,
  `kode_CPB` varchar(4) NOT NULL,
  `preverensi` float NOT NULL,
  `ranking` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tp_solusi_jarak_negatif`
--

CREATE TABLE `tp_solusi_jarak_negatif` (
  `KODE` varchar(5) NOT NULL,
  `kode_CPB` varchar(4) NOT NULL,
  `pekerjaan` float NOT NULL,
  `penghasilan` float NOT NULL,
  `tanggungan` float NOT NULL,
  `atap` float NOT NULL,
  `dinding` float NOT NULL,
  `lantai` float NOT NULL,
  `tanggal` date NOT NULL,
  `admin` varchar(50) NOT NULL,
  `total` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tp_solusi_jarak_positif`
--

CREATE TABLE `tp_solusi_jarak_positif` (
  `KODE` varchar(5) NOT NULL,
  `kode_CPB` varchar(4) NOT NULL,
  `pekerjaan` float NOT NULL,
  `penghasilan` float NOT NULL,
  `tanggungan` float NOT NULL,
  `atap` float NOT NULL,
  `dinding` float NOT NULL,
  `lantai` float NOT NULL,
  `tanggal` date NOT NULL,
  `admin` varchar(50) NOT NULL,
  `total` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_analisa`
-- (See below for the actual view)
--
CREATE TABLE `v_analisa` (
`KODE` varchar(5)
,`kode_CPB` varchar(4)
,`C1` float
,`C2` float
,`C3` float
,`C4` float
,`C5` float
,`C6` float
,`NAMA` varchar(50)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_hasil_ranking`
-- (See below for the actual view)
--
CREATE TABLE `v_hasil_ranking` (
`KODE` varchar(5)
,`kode_CPB` varchar(4)
,`POSITIF` float
,`NEGATIF` float
,`preverensi` float
,`ranking` float
,`NAMA` varchar(50)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_normalisasi`
-- (See below for the actual view)
--
CREATE TABLE `v_normalisasi` (
`KODE` varchar(5)
,`kode_CPB` varchar(4)
,`C1` float
,`C2` float
,`C3` float
,`C4` float
,`C5` float
,`C6` float
,`NAMA` varchar(50)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_normalisasi_akar`
-- (See below for the actual view)
--
CREATE TABLE `v_normalisasi_akar` (
`KODE` varchar(5)
,`kode_CPB` varchar(4)
,`C1` float
,`C2` float
,`C3` float
,`C4` float
,`C5` float
,`C6` float
,`NAMA` varchar(50)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_normalisasi_bobot`
-- (See below for the actual view)
--
CREATE TABLE `v_normalisasi_bobot` (
`KODE` varchar(5)
,`kode_CPB` varchar(4)
,`C1` float
,`C2` float
,`C3` float
,`C4` float
,`C5` float
,`C6` float
,`NAMA` varchar(50)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_report`
-- (See below for the actual view)
--
CREATE TABLE `v_report` (
`KODE` varchar(5)
,`RANKING` float
,`KODE_CPB` varchar(4)
,`NAMA_CPB` varchar(50)
,`NO_KK` varchar(25)
,`ALAMAT` varchar(250)
,`RT` varchar(50)
,`KELURAHAN` varchar(250)
,`DISTRIK` varchar(250)
,`ALAMAT_LENGKAP` text
,`KODE_PEKERJAAN` varchar(2)
,`KODE_PENGHASILAN` varchar(2)
,`KODE_TANGGUNGAN` varchar(2)
,`KODE_ATAP` varchar(2)
,`KODE_DINDING` varchar(2)
,`KODE_LANTAI` varchar(2)
,`C1_PEKERJAAN` varchar(50)
,`C2_PENGHASILAN` varchar(50)
,`C3_TANGGUNGAN` varchar(50)
,`C4_ATAP` varchar(100)
,`C5_DINDING` varchar(100)
,`C6_LANTAI` varchar(100)
,`NILAI` varchar(25)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_report_normalisasi_bobot`
-- (See below for the actual view)
--
CREATE TABLE `v_report_normalisasi_bobot` (
`KODE` varchar(5)
,`RANKING` float
,`KODE_CPB` varchar(4)
,`NAMA_KEPALA_KELUARGA` varchar(50)
,`C1_PEKERJAAN` varchar(25)
,`C2_PENGHASILAN` varchar(25)
,`C3_TANGGUNGAN` varchar(25)
,`C4_ATAP` varchar(25)
,`C5_DINDING` varchar(25)
,`C6_LANTAI` varchar(25)
,`NILAI` varchar(25)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_report_solusi_negatif`
-- (See below for the actual view)
--
CREATE TABLE `v_report_solusi_negatif` (
`KODE` varchar(5)
,`RANKING` float
,`KODE_CPB` varchar(4)
,`NAMA_KEPALA_KELUARGA` varchar(50)
,`C1_PEKERJAAN` varchar(25)
,`C2_PENGHASILAN` varchar(25)
,`C3_TANGGUNGAN` varchar(25)
,`C4_ATAP` varchar(25)
,`C5_DINDING` varchar(25)
,`C6_LANTAI` varchar(25)
,`NILAI` varchar(25)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_report_solusi_positif`
-- (See below for the actual view)
--
CREATE TABLE `v_report_solusi_positif` (
`KODE` varchar(5)
,`RANKING` float
,`KODE_CPB` varchar(4)
,`NAMA_KEPALA_KELUARGA` varchar(50)
,`C1_PEKERJAAN` varchar(25)
,`C2_PENGHASILAN` varchar(25)
,`C3_TANGGUNGAN` varchar(25)
,`C4_ATAP` varchar(25)
,`C5_DINDING` varchar(25)
,`C6_LANTAI` varchar(25)
,`NILAI` varchar(25)
);

-- --------------------------------------------------------

--
-- Structure for view `v_analisa`
--
DROP TABLE IF EXISTS `v_analisa`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_analisa`  AS  select `ts`.`kode_analisa` AS `KODE`,`tc`.`kode_CPB` AS `kode_CPB`,`tp`.`nilai` AS `C1`,`tpeng`.`nilai` AS `C2`,`ta`.`nilai` AS `C3`,`td`.`nilai` AS `C4`,`tl`.`nilai` AS `C5`,`tt`.`nilai` AS `C6`,`tc`.`nama_kepala_keluarga` AS `NAMA` from (((((((`tbl_analisa` `ts` join `tbl_cpb` `tc`) join `tbl_pekerjaan` `tp`) join `tbl_penghasilan` `tpeng`) join `tbl_tanggungan_jiwa` `tt`) join `tbl_atap` `ta`) join `tbl_dinding` `td`) join `tbl_lantai` `tl`) where `ts`.`kode_CPB` = `tc`.`kode_CPB` and `tp`.`kode_pekerjaan` = `ts`.`kode_pekerjaan` and `tpeng`.`kode_penghasilan` = `ts`.`kode_penghasilan` and `tt`.`kode_tanggungan` = `ts`.`kode_tanggungan` and `ta`.`kode_atap` = `ts`.`kode_atap` and `td`.`kode_dinding` = `ts`.`kode_dinding` and `tl`.`kode_lantai` = `ts`.`kode_lantai` ;

-- --------------------------------------------------------

--
-- Structure for view `v_hasil_ranking`
--
DROP TABLE IF EXISTS `v_hasil_ranking`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_hasil_ranking`  AS  select `a`.`KODE` AS `KODE`,`a`.`kode_CPB` AS `kode_CPB`,`b`.`total` AS `POSITIF`,`c`.`total` AS `NEGATIF`,`a`.`preverensi` AS `preverensi`,`a`.`ranking` AS `ranking`,`d`.`nama_kepala_keluarga` AS `NAMA` from (((`tp_ranking` `a` left join `tp_solusi_jarak_positif` `b` on(`a`.`kode_CPB` = `b`.`kode_CPB`)) left join `tp_solusi_jarak_negatif` `c` on(`a`.`kode_CPB` = `c`.`kode_CPB`)) left join `tbl_cpb` `d` on(`a`.`kode_CPB` = `d`.`kode_CPB`)) ;

-- --------------------------------------------------------

--
-- Structure for view `v_normalisasi`
--
DROP TABLE IF EXISTS `v_normalisasi`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_normalisasi`  AS  select `n`.`KODE` AS `KODE`,`c`.`kode_CPB` AS `kode_CPB`,`n`.`pekerjaan` AS `C1`,`n`.`penghasilan` AS `C2`,`n`.`tanggungan` AS `C3`,`n`.`atap` AS `C4`,`n`.`dinding` AS `C5`,`n`.`lantai` AS `C6`,`c`.`nama_kepala_keluarga` AS `NAMA` from (`tp_normalisasi` `n` join `tbl_cpb` `c`) where `n`.`kode_CPB` = `c`.`kode_CPB` ;

-- --------------------------------------------------------

--
-- Structure for view `v_normalisasi_akar`
--
DROP TABLE IF EXISTS `v_normalisasi_akar`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_normalisasi_akar`  AS  select `n`.`KODE` AS `KODE`,`c`.`kode_CPB` AS `kode_CPB`,`n`.`pekerjaan` AS `C1`,`n`.`penghasilan` AS `C2`,`n`.`tanggungan` AS `C3`,`n`.`atap` AS `C4`,`n`.`dinding` AS `C5`,`n`.`lantai` AS `C6`,`c`.`nama_kepala_keluarga` AS `NAMA` from (`tp_normalisasi_akar` `n` join `tbl_cpb` `c`) where `n`.`kode_CPB` = `c`.`kode_CPB` ;

-- --------------------------------------------------------

--
-- Structure for view `v_normalisasi_bobot`
--
DROP TABLE IF EXISTS `v_normalisasi_bobot`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_normalisasi_bobot`  AS  select `n`.`KODE` AS `KODE`,`c`.`kode_CPB` AS `kode_CPB`,`n`.`pekerjaan` AS `C1`,`n`.`penghasilan` AS `C2`,`n`.`tanggungan` AS `C3`,`n`.`atap` AS `C4`,`n`.`dinding` AS `C5`,`n`.`lantai` AS `C6`,`c`.`nama_kepala_keluarga` AS `NAMA` from (`tp_normalisasi_bobot` `n` join `tbl_cpb` `c`) where `n`.`kode_CPB` = `c`.`kode_CPB` ;

-- --------------------------------------------------------

--
-- Structure for view `v_report`
--
DROP TABLE IF EXISTS `v_report`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_report`  AS  select `a`.`KODE` AS `KODE`,`a`.`ranking` AS `RANKING`,`a`.`kode_CPB` AS `KODE_CPB`,`b`.`nama_kepala_keluarga` AS `NAMA_CPB`,`b`.`no_KK` AS `NO_KK`,`b`.`alamat` AS `ALAMAT`,`b`.`RT` AS `RT`,`b`.`kelurahan` AS `KELURAHAN`,`b`.`distrik` AS `DISTRIK`,concat(`b`.`alamat`,'\r\n','RT/RW ',`b`.`RT`,'\r\n','KEL. ',`b`.`kelurahan`,'\r\n','DISTRIK ',`b`.`distrik`) AS `ALAMAT_LENGKAP`,`c`.`kode_pekerjaan` AS `KODE_PEKERJAAN`,`c`.`kode_penghasilan` AS `KODE_PENGHASILAN`,`c`.`kode_tanggungan` AS `KODE_TANGGUNGAN`,`c`.`kode_atap` AS `KODE_ATAP`,`c`.`kode_dinding` AS `KODE_DINDING`,`c`.`kode_lantai` AS `KODE_LANTAI`,`d`.`pekerjaan` AS `C1_PEKERJAAN`,`e`.`jumlah_penghasilan` AS `C2_PENGHASILAN`,`f`.`jumlah_tanggungan` AS `C3_TANGGUNGAN`,`g`.`kondisi_atap` AS `C4_ATAP`,`h`.`kondisi_dinding` AS `C5_DINDING`,`i`.`kondisi_lantai` AS `C6_LANTAI`,cast(`a`.`preverensi` as char(25) charset utf8mb4) AS `NILAI` from ((((((((`tp_ranking` `a` left join `tbl_cpb` `b` on(`a`.`kode_CPB` = `b`.`kode_CPB`)) left join `tbl_analisa` `c` on(`a`.`kode_CPB` = `c`.`kode_CPB`)) left join `tbl_pekerjaan` `d` on(`c`.`kode_pekerjaan` = `d`.`kode_pekerjaan`)) left join `tbl_penghasilan` `e` on(`c`.`kode_penghasilan` = `e`.`kode_penghasilan`)) left join `tbl_tanggungan_jiwa` `f` on(`c`.`kode_tanggungan` = `f`.`kode_tanggungan`)) left join `tbl_atap` `g` on(`c`.`kode_atap` = `g`.`kode_atap`)) left join `tbl_dinding` `h` on(`c`.`kode_dinding` = `h`.`kode_dinding`)) left join `tbl_lantai` `i` on(`c`.`kode_lantai` = `i`.`kode_lantai`)) order by `a`.`KODE` ;

-- --------------------------------------------------------

--
-- Structure for view `v_report_normalisasi_bobot`
--
DROP TABLE IF EXISTS `v_report_normalisasi_bobot`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_report_normalisasi_bobot`  AS  select `a`.`KODE` AS `KODE`,`a`.`ranking` AS `RANKING`,`a`.`kode_CPB` AS `KODE_CPB`,`b`.`nama_kepala_keluarga` AS `NAMA_KEPALA_KELUARGA`,cast(`c`.`pekerjaan` as char(25) charset utf8mb4) AS `C1_PEKERJAAN`,cast(`c`.`penghasilan` as char(25) charset utf8mb4) AS `C2_PENGHASILAN`,cast(`c`.`tanggungan` as char(25) charset utf8mb4) AS `C3_TANGGUNGAN`,cast(`c`.`atap` as char(25) charset utf8mb4) AS `C4_ATAP`,cast(`c`.`dinding` as char(25) charset utf8mb4) AS `C5_DINDING`,cast(`c`.`lantai` as char(25) charset utf8mb4) AS `C6_LANTAI`,cast(`a`.`preverensi` as char(25) charset utf8mb4) AS `NILAI` from ((`tp_ranking` `a` left join `tbl_cpb` `b` on(`a`.`kode_CPB` = `b`.`kode_CPB`)) left join `tp_normalisasi_bobot` `c` on(`a`.`kode_CPB` = `c`.`kode_CPB`)) order by `a`.`ranking` ;

-- --------------------------------------------------------

--
-- Structure for view `v_report_solusi_negatif`
--
DROP TABLE IF EXISTS `v_report_solusi_negatif`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_report_solusi_negatif`  AS  select `a`.`KODE` AS `KODE`,`a`.`ranking` AS `RANKING`,`a`.`kode_CPB` AS `KODE_CPB`,`b`.`nama_kepala_keluarga` AS `NAMA_KEPALA_KELUARGA`,cast(`c`.`pekerjaan` as char(25) charset utf8mb4) AS `C1_PEKERJAAN`,cast(`c`.`penghasilan` as char(25) charset utf8mb4) AS `C2_PENGHASILAN`,cast(`c`.`tanggungan` as char(25) charset utf8mb4) AS `C3_TANGGUNGAN`,cast(`c`.`atap` as char(25) charset utf8mb4) AS `C4_ATAP`,cast(`c`.`dinding` as char(25) charset utf8mb4) AS `C5_DINDING`,cast(`c`.`lantai` as char(25) charset utf8mb4) AS `C6_LANTAI`,cast(`a`.`preverensi` as char(25) charset utf8mb4) AS `NILAI` from ((`tp_ranking` `a` left join `tbl_cpb` `b` on(`a`.`kode_CPB` = `b`.`kode_CPB`)) left join `tp_solusi_jarak_negatif` `c` on(`a`.`kode_CPB` = `c`.`kode_CPB`)) order by `a`.`ranking` ;

-- --------------------------------------------------------

--
-- Structure for view `v_report_solusi_positif`
--
DROP TABLE IF EXISTS `v_report_solusi_positif`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_report_solusi_positif`  AS  select `a`.`KODE` AS `KODE`,`a`.`ranking` AS `RANKING`,`a`.`kode_CPB` AS `KODE_CPB`,`b`.`nama_kepala_keluarga` AS `NAMA_KEPALA_KELUARGA`,cast(`c`.`pekerjaan` as char(25) charset utf8mb4) AS `C1_PEKERJAAN`,cast(`c`.`penghasilan` as char(25) charset utf8mb4) AS `C2_PENGHASILAN`,cast(`c`.`tanggungan` as char(25) charset utf8mb4) AS `C3_TANGGUNGAN`,cast(`c`.`atap` as char(25) charset utf8mb4) AS `C4_ATAP`,cast(`c`.`dinding` as char(25) charset utf8mb4) AS `C5_DINDING`,cast(`c`.`lantai` as char(25) charset utf8mb4) AS `C6_LANTAI`,cast(`a`.`preverensi` as char(25) charset utf8mb4) AS `NILAI` from ((`tp_ranking` `a` left join `tbl_cpb` `b` on(`a`.`kode_CPB` = `b`.`kode_CPB`)) left join `tp_solusi_jarak_positif` `c` on(`a`.`kode_CPB` = `c`.`kode_CPB`)) order by `a`.`ranking` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_analisa`
--
ALTER TABLE `tbl_analisa`
  ADD PRIMARY KEY (`kode_analisa`),
  ADD KEY `kode_CPB` (`kode_CPB`),
  ADD KEY `kode_pekerjaan` (`kode_pekerjaan`),
  ADD KEY `kode_penghasilan` (`kode_penghasilan`),
  ADD KEY `kode_tanggungan` (`kode_tanggungan`),
  ADD KEY `kode_atap` (`kode_atap`),
  ADD KEY `kode_dinding` (`kode_dinding`),
  ADD KEY `kode_lantai` (`kode_lantai`);

--
-- Indexes for table `tbl_atap`
--
ALTER TABLE `tbl_atap`
  ADD PRIMARY KEY (`kode_atap`);

--
-- Indexes for table `tbl_cpb`
--
ALTER TABLE `tbl_cpb`
  ADD PRIMARY KEY (`kode_CPB`);

--
-- Indexes for table `tbl_dinding`
--
ALTER TABLE `tbl_dinding`
  ADD PRIMARY KEY (`kode_dinding`);

--
-- Indexes for table `tbl_lantai`
--
ALTER TABLE `tbl_lantai`
  ADD PRIMARY KEY (`kode_lantai`);

--
-- Indexes for table `tbl_pekerjaan`
--
ALTER TABLE `tbl_pekerjaan`
  ADD PRIMARY KEY (`kode_pekerjaan`);

--
-- Indexes for table `tbl_penghasilan`
--
ALTER TABLE `tbl_penghasilan`
  ADD PRIMARY KEY (`kode_penghasilan`);

--
-- Indexes for table `tbl_tanggungan_jiwa`
--
ALTER TABLE `tbl_tanggungan_jiwa`
  ADD PRIMARY KEY (`kode_tanggungan`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`kode_user`);

--
-- Indexes for table `tp_normalisasi`
--
ALTER TABLE `tp_normalisasi`
  ADD PRIMARY KEY (`KODE`);

--
-- Indexes for table `tp_normalisasi_akar`
--
ALTER TABLE `tp_normalisasi_akar`
  ADD PRIMARY KEY (`KODE`);

--
-- Indexes for table `tp_normalisasi_bobot`
--
ALTER TABLE `tp_normalisasi_bobot`
  ADD PRIMARY KEY (`KODE`);

--
-- Indexes for table `tp_ranking`
--
ALTER TABLE `tp_ranking`
  ADD PRIMARY KEY (`KODE`);

--
-- Indexes for table `tp_solusi_jarak_negatif`
--
ALTER TABLE `tp_solusi_jarak_negatif`
  ADD PRIMARY KEY (`KODE`);

--
-- Indexes for table `tp_solusi_jarak_positif`
--
ALTER TABLE `tp_solusi_jarak_positif`
  ADD PRIMARY KEY (`KODE`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_analisa`
--
ALTER TABLE `tbl_analisa`
  ADD CONSTRAINT `tbl_analisa_ibfk_1` FOREIGN KEY (`kode_pekerjaan`) REFERENCES `tbl_pekerjaan` (`kode_pekerjaan`),
  ADD CONSTRAINT `tbl_analisa_ibfk_2` FOREIGN KEY (`kode_penghasilan`) REFERENCES `tbl_penghasilan` (`kode_penghasilan`),
  ADD CONSTRAINT `tbl_analisa_ibfk_3` FOREIGN KEY (`kode_tanggungan`) REFERENCES `tbl_tanggungan_jiwa` (`kode_tanggungan`),
  ADD CONSTRAINT `tbl_analisa_ibfk_4` FOREIGN KEY (`kode_atap`) REFERENCES `tbl_atap` (`kode_atap`),
  ADD CONSTRAINT `tbl_analisa_ibfk_5` FOREIGN KEY (`kode_dinding`) REFERENCES `tbl_dinding` (`kode_dinding`),
  ADD CONSTRAINT `tbl_analisa_ibfk_6` FOREIGN KEY (`kode_lantai`) REFERENCES `tbl_lantai` (`kode_lantai`),
  ADD CONSTRAINT `tbl_analisa_ibfk_7` FOREIGN KEY (`kode_CPB`) REFERENCES `tbl_cpb` (`kode_CPB`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
