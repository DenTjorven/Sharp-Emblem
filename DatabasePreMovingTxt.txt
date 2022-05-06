-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 21, 2022 at 11:44 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

--
-- Database: `sharpemblem`
--

-- --------------------------------------------------------

--
-- Table structure for table `t_askill`
--

CREATE TABLE `t_askill` (
  `aSkillID` int(45) NOT NULL,
  `d_naam` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_askill`
--

INSERT INTO `t_askill` (`aSkillID`, `d_naam`) VALUES
(14, 'Armored Blow'),
(22, 'Attack'),
(5, 'Close Counter'),
(13, 'Darting Blow'),
(6, 'Death Blow'),
(10, 'Defense'),
(11, 'Defiant Atk'),
(33, 'Defiant Def'),
(25, 'Defiant Spd'),
(2, 'Distant Counter'),
(20, 'Fury'),
(15, 'HP'),
(24, 'Life and Death'),
(7, 'Resistance'),
(1, 'Speed'),
(19, 'Triangle Adept'),
(8, 'Warding Blow');

-- --------------------------------------------------------

--
-- Table structure for table `t_beweging`
--

CREATE TABLE `t_beweging` (
  `movementID` int(45) NOT NULL,
  `d_naam` varchar(255) DEFAULT NULL,
  `d_mov` int(45) DEFAULT NULL,
  `d_fly` tinyint(1) DEFAULT NULL,
  `d_cav` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_beweging`
--

INSERT INTO `t_beweging` (`movementID`, `d_naam`, `d_mov`, `d_fly`, `d_cav`) VALUES
(1, 'Armor', 1, 0, 0),
(2, 'Infantry', 2, 0, 0),
(3, 'Cavalry', 3, 0, 1),
(4, 'Flier', 2, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `t_bskill`
--

CREATE TABLE `t_bskill` (
  `bSkillID` int(45) NOT NULL,
  `d_naam` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_bskill`
--

INSERT INTO `t_bskill` (`bSkillID`, `d_naam`) VALUES
(18, 'Axebreaker'),
(30, 'Brash Assault'),
(3, 'Daggerbreaker'),
(2, 'Drag Back'),
(4, 'Escape Route'),
(5, 'Knock Back'),
(26, 'Lancebreaker'),
(17, 'Live to Serve'),
(10, 'Lunge'),
(16, 'Obstruct'),
(8, 'Pass'),
(29, 'Poison Strike'),
(12, 'Quick Riposte'),
(27, 'Red Tomebreaker'),
(19, 'Renewal'),
(7, 'Seal Atk'),
(11, 'Seal Def'),
(9, 'Seal Res'),
(6, 'Swordbreaker'),
(13, 'Vantage'),
(1, 'Wary Fighter');

-- --------------------------------------------------------

--
-- Table structure for table `t_cskill`
--

CREATE TABLE `t_cskill` (
  `cSkillID` int(45) NOT NULL,
  `d_naam` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_cskill`
--

INSERT INTO `t_cskill` (`cSkillID`, `d_naam`) VALUES
(7, 'Breath of Life'),
(13, 'Fortify Def'),
(1, 'Fortify Res'),
(2, 'Goad Arm'),
(23, 'Goad Cav'),
(9, 'Hone Atk'),
(30, 'Hone Cav'),
(31, 'Hone Fly'),
(6, 'Hone Spd'),
(16, 'Savage Blow'),
(4, 'Spur Atk'),
(17, 'Spur Def'),
(14, 'Spur Res'),
(8, 'Spur Spd'),
(29, 'Threaten Atk'),
(19, 'Threaten Def'),
(10, 'Threaten Res'),
(5, 'Threaten Spd'),
(28, 'Ward Cav'),
(22, 'Ward Fly');

-- --------------------------------------------------------

--
-- Table structure for table `t_karakter`
--

CREATE TABLE `t_karakter` (
  `charID` int(45) NOT NULL,
  `d_naam` varchar(255) DEFAULT NULL,
  `d_hp` int(45) DEFAULT NULL,
  `d_atk` int(45) DEFAULT NULL,
  `d_spd` int(45) DEFAULT NULL,
  `d_def` int(45) DEFAULT NULL,
  `d_res` int(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_karakter`
--

INSERT INTO `t_karakter` (`charID`, `d_naam`, `d_hp`, `d_atk`, `d_spd`, `d_def`, `d_res`) VALUES
(2, 'Azura', 36, 43, 36, 21, 28),
(3, 'Hector', 52, 52, 24, 37, 19),
(4, 'Linde', 35, 49, 39, 24, 27),
(5, 'Lucina', 43, 50, 36, 25, 19),
(6, 'Takumi', 40, 46, 33, 25, 18),
(7, 'Effie', 50, 55, 22, 33, 23),
(8, 'Eirika', 42, 42, 35, 26, 28),
(9, 'Julia', 38, 49, 26, 17, 35),
(10, 'Kagero', 31, 40, 32, 22, 28),
(11, 'Marth', 41, 47, 34, 29, 23),
(12, 'Nino', 33, 46, 36, 19, 29),
(13, 'Nowi', 45, 45, 27, 33, 27),
(14, 'Olivia', 36, 43, 33, 27, 26),
(15, 'Ryoma', 41, 50, 35, 27, 21),
(16, 'Sharena', 43, 48, 35, 29, 22),
(17, 'Tharja', 39, 45, 34, 23, 20),
(18, 'Tiki(S)', 41, 46, 30, 32, 29),
(19, 'Abel', 44, 41, 27, 25, 25),
(20, 'Camilla', 37, 38, 27, 28, 31),
(21, 'Catria', 39, 42, 34, 29, 25),
(22, 'Chrom', 47, 53, 25, 31, 17),
(23, 'Cordelia', 40, 43, 30, 22, 25),
(24, 'Corrin(F)', 41, 40, 34, 34, 21),
(25, 'Eldigan', 45, 51, 27, 37, 22),
(26, 'Ephraim', 45, 51, 25, 32, 20),
(27, 'Klein', 40, 38, 28, 20, 24),
(28, 'Lilina', 35, 53, 25, 19, 31),
(29, 'Lyn', 37, 44, 37, 26, 29),
(30, 'Minerva', 40, 52, 38, 27, 17),
(31, 'Reinhardt', 38, 41, 18, 27, 25),
(32, 'Robin(M)', 40, 40, 29, 29, 22),
(33, 'Sanaki', 33, 51, 26, 17, 34),
(34, 'Tiki(A)', 40, 46, 23, 35, 24),
(35, 'Anna', 41, 45, 38, 22, 28),
(36, 'Cecilia', 36, 46, 25, 22, 29),
(37, 'Corrin(M)', 42, 48, 32, 31, 24),
(38, 'Elise', 30, 42, 32, 19, 32),
(39, 'Eliwood', 39, 47, 30, 23, 32),
(40, 'Fae', 46, 46, 28, 25, 30),
(41, 'Gordin', 43, 41, 20, 32, 17),
(42, 'Gunter', 43, 47, 24, 33, 21),
(43, 'Hana', 37, 52, 41, 18, 21),
(44, 'Hinoka', 41, 43, 27, 25, 24),
(45, 'Jeorge', 37, 46, 32, 24, 22),
(46, 'Leo', 39, 43, 22, 25, 30),
(47, 'Lissa', 35, 36, 25, 28, 30),
(48, 'Lon\'qu', 42, 40, 42, 22, 22),
(49, 'Merric', 48, 40, 32, 28, 19),
(50, 'Narcian', 42, 41, 29, 32, 26),
(51, 'Odin', 43, 35, 32, 25, 25),
(52, 'Ogma', 47, 43, 29, 28, 13),
(53, 'Olwen', 34, 35, 29, 20, 30),
(54, 'Raven', 41, 42, 30, 25, 22),
(55, 'Roy', 44, 46, 31, 25, 28),
(56, 'Saizo', 36, 38, 34, 33, 16),
(57, 'Seliph', 52, 50, 24, 30, 22),
(58, 'Sully', 42, 38, 31, 27, 28),
(59, 'Ursula', 35, 39, 32, 19, 30);

-- --------------------------------------------------------

--
-- Table structure for table `t_speciaal`
--

CREATE TABLE `t_speciaal` (
  `specialID` int(11) NOT NULL,
  `d_naam` varchar(255) DEFAULT NULL,
  `d_cooldown` int(11) DEFAULT NULL,
  `d_atkInc` int(11) DEFAULT NULL,
  `d_defIng` int(11) DEFAULT NULL,
  `d_proOfDef` int(11) DEFAULT NULL,
  `d_proOfRes` int(11) DEFAULT NULL,
  `d_proOfMissHP` int(11) DEFAULT NULL,
  `d_dmgReduc` int(11) DEFAULT NULL,
  `d_dmgIncre` int(45) DEFAULT NULL,
  `d_healForDmg` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_speciaal`
--

INSERT INTO `t_speciaal` (`specialID`, `d_naam`, `d_cooldown`, `d_atkInc`, `d_defIng`, `d_proOfDef`, `d_proOfRes`, `d_proOfMissHP`, `d_dmgReduc`, `d_dmgIncre`, `d_healForDmg`) VALUES
(1, 'Pavise', 3, 0, 0, 0, 0, 0, 50, 0, 0),
(2, 'Aether', 5, 0, 50, 0, 0, 0, 0, 0, 50),
(3, 'Vengeance', 3, 0, 0, 0, 0, 50, 0, 0, 0),
(4, 'Dragon Fang', 4, 50, 0, 0, 0, 0, 0, 0, 0),
(5, 'Reprisal', 2, 0, 0, 0, 0, 30, 0, 0, 0),
(6, 'Astra', 5, 0, 0, 0, 0, 0, 0, 150, 0),
(9, 'Aegis', 3, 0, 0, 0, 0, 0, 50, 0, 0),
(10, 'Draconic Aura', 3, 30, 0, 0, 0, 0, 0, 0, 0),
(11, 'Luna', 3, 0, 50, 0, 0, 0, 0, 0, 0),
(16, 'Moonbow', 2, 0, 30, 0, 0, 0, 0, 0, 0),
(17, 'Glacies', 4, 0, 0, 0, 80, 0, 0, 0, 0),
(20, 'Sacred Cowl', 2, 0, 0, 0, 0, 0, 30, 0, 0),
(22, 'Bonfire', 3, 0, 0, 50, 0, 0, 0, 0, 0),
(26, 'Miracle', 5, 0, 0, 0, 0, 0, 0, 0, 0),
(32, 'Glimmer', 3, 0, 0, 0, 0, 0, 0, 50, 0),
(36, 'Noontime', 3, 0, 0, 0, 0, 0, 0, 0, 30),
(37, 'Sol', 4, 0, 0, 0, 0, 0, 0, 0, 50);

-- --------------------------------------------------------

--
-- Table structure for table `t_tussenkara`
--

CREATE TABLE `t_tussenkara` (
  `karAID` int(11) NOT NULL,
  `charID` int(11) DEFAULT NULL,
  `aSkillID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_tussenkara`
--

INSERT INTO `t_tussenkara` (`karAID`, `charID`, `aSkillID`) VALUES
(1, 19, 15),
(2, 2, 1),
(3, 20, 13),
(4, 21, 14),
(5, 36, 22),
(6, 22, 33),
(7, 23, 19),
(8, 37, 10),
(9, 7, 6),
(10, 25, 20),
(11, 41, 22),
(12, 42, 14),
(13, 43, 24),
(14, 3, 2),
(15, 44, 33),
(16, 9, 7),
(17, 10, 8),
(18, 27, 6),
(19, 28, 22),
(20, 4, 1),
(21, 48, 1),
(22, 5, 25),
(23, 29, 11),
(24, 49, 15),
(25, 30, 24),
(26, 12, 7),
(27, 13, 10),
(28, 51, 11),
(29, 52, 11),
(30, 53, 8),
(31, 54, 25),
(32, 32, 25),
(33, 55, 19),
(34, 15, 11),
(35, 33, 19),
(36, 57, 15),
(37, 16, 1),
(38, 6, 5),
(39, 17, 13),
(40, 34, 11),
(41, 18, 14),
(42, 59, 6);

-- --------------------------------------------------------

--
-- Table structure for table `t_tussenkarb`
--

CREATE TABLE `t_tussenkarb` (
  `karBID` int(11) NOT NULL,
  `charID` int(11) DEFAULT NULL,
  `bSkillID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_tussenkarb`
--

INSERT INTO `t_tussenkarb` (`karBID`, `charID`, `bSkillID`) VALUES
(1, 19, 6),
(2, 35, 13),
(3, 21, 7),
(4, 36, 4),
(5, 23, 8),
(6, 24, 9),
(7, 37, 16),
(8, 7, 1),
(9, 8, 2),
(10, 25, 10),
(11, 38, 17),
(12, 39, 18),
(13, 26, 11),
(14, 40, 19),
(15, 41, 13),
(16, 43, 16),
(17, 45, 7),
(18, 10, 3),
(19, 27, 12),
(20, 46, 12),
(21, 47, 19),
(22, 48, 13),
(23, 11, 4),
(24, 50, 26),
(25, 51, 27),
(26, 14, 5),
(27, 31, 13),
(28, 55, 11),
(29, 56, 29),
(30, 57, 30),
(31, 58, 6);

-- --------------------------------------------------------

--
-- Table structure for table `t_tussenkarc`
--

CREATE TABLE `t_tussenkarc` (
  `karCID` int(11) NOT NULL,
  `charID` int(11) DEFAULT NULL,
  `cSkillID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_tussenkarc`
--

INSERT INTO `t_tussenkarc` (`karCID`, `charID`, `cSkillID`) VALUES
(1, 35, 14),
(2, 2, 1),
(3, 20, 16),
(4, 22, 17),
(5, 24, 9),
(6, 8, 6),
(7, 39, 28),
(8, 26, 19),
(9, 40, 29),
(10, 42, 30),
(11, 3, 2),
(12, 44, 31),
(13, 45, 8),
(14, 9, 7),
(15, 46, 16),
(16, 28, 4),
(17, 4, 1),
(18, 5, 4),
(19, 29, 8),
(20, 11, 8),
(21, 49, 14),
(22, 30, 22),
(23, 50, 16),
(24, 12, 9),
(25, 13, 10),
(26, 52, 4),
(27, 14, 9),
(28, 53, 28),
(29, 54, 19),
(30, 31, 23),
(31, 32, 17),
(32, 15, 6),
(33, 56, 8),
(34, 33, 9),
(35, 16, 13),
(36, 58, 17),
(37, 6, 5),
(38, 17, 14),
(39, 34, 14),
(40, 18, 7),
(41, 59, 10);

-- --------------------------------------------------------

--
-- Table structure for table `t_tussenkarmov`
--

CREATE TABLE `t_tussenkarmov` (
  `karMovID` int(11) NOT NULL,
  `charID` int(11) DEFAULT NULL,
  `movementID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_tussenkarmov`
--

INSERT INTO `t_tussenkarmov` (`karMovID`, `charID`, `movementID`) VALUES
(251, 19, 3),
(252, 35, 2),
(253, 2, 2),
(254, 20, 4),
(255, 21, 4),
(256, 36, 3),
(257, 22, 2),
(258, 23, 4),
(259, 24, 2),
(260, 37, 2),
(261, 7, 1),
(262, 8, 2),
(263, 25, 3),
(264, 38, 3),
(265, 39, 3),
(266, 26, 2),
(267, 40, 2),
(268, 41, 2),
(269, 42, 3),
(270, 43, 2),
(271, 3, 1),
(272, 44, 4),
(273, 45, 2),
(274, 9, 2),
(275, 10, 2),
(276, 27, 2),
(277, 46, 3),
(278, 28, 2),
(279, 4, 2),
(280, 47, 2),
(281, 48, 2),
(282, 5, 2),
(283, 29, 2),
(284, 11, 2),
(285, 49, 2),
(286, 30, 4),
(287, 50, 4),
(288, 12, 2),
(289, 13, 2),
(290, 51, 2),
(291, 52, 2),
(292, 14, 2),
(293, 53, 3),
(294, 54, 2),
(295, 31, 3),
(296, 32, 2),
(297, 55, 2),
(298, 15, 2),
(299, 56, 2),
(300, 33, 2),
(301, 57, 2),
(302, 16, 2),
(303, 58, 3),
(304, 6, 2),
(305, 17, 2),
(306, 34, 2),
(307, 18, 2),
(308, 59, 3);

-- --------------------------------------------------------

--
-- Table structure for table `t_tussenkarspec`
--

CREATE TABLE `t_tussenkarspec` (
  `karSpecID` int(11) NOT NULL,
  `charID` int(11) DEFAULT NULL,
  `specialID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_tussenkarspec`
--

INSERT INTO `t_tussenkarspec` (`karSpecID`, `charID`, `specialID`) VALUES
(1, 19, 9),
(2, 35, 6),
(3, 20, 10),
(4, 21, 11),
(5, 22, 2),
(6, 23, 6),
(7, 24, 10),
(8, 37, 4),
(9, 25, 16),
(10, 39, 20),
(11, 26, 16),
(12, 3, 1),
(13, 44, 4),
(14, 45, 10),
(15, 9, 4),
(16, 10, 5),
(17, 27, 17),
(18, 46, 37),
(19, 28, 3),
(20, 48, 32),
(21, 5, 2),
(22, 29, 6),
(23, 49, 36),
(24, 30, 20),
(25, 50, 3),
(26, 51, 16),
(27, 52, 36),
(28, 54, 37),
(29, 31, 32),
(30, 32, 22),
(31, 15, 6),
(32, 6, 3),
(33, 17, 3),
(34, 34, 22),
(35, 18, 10),
(36, 59, 4);

-- --------------------------------------------------------

--
-- Table structure for table `t_tussenkarwapen`
--

CREATE TABLE `t_tussenkarwapen` (
  `karWapenID` int(11) NOT NULL,
  `charID` int(11) DEFAULT NULL,
  `weaponID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_tussenkarwapen`
--

INSERT INTO `t_tussenkarwapen` (`karWapenID`, `charID`, `weaponID`) VALUES
(1, 19, 18),
(2, 35, 34),
(3, 2, 1),
(4, 20, 19),
(5, 21, 20),
(6, 36, 35),
(7, 22, 4),
(8, 23, 18),
(9, 24, 23),
(10, 37, 36),
(11, 7, 6),
(12, 8, 7),
(13, 25, 24),
(14, 38, 37),
(15, 39, 38),
(16, 26, 25),
(17, 40, 39),
(18, 41, 40),
(19, 42, 41),
(20, 43, 42),
(21, 3, 2),
(22, 44, 18),
(23, 45, 44),
(24, 9, 8),
(25, 10, 9),
(26, 27, 40),
(27, 46, 45),
(28, 28, 27),
(29, 4, 3),
(30, 47, 37),
(31, 48, 47),
(32, 5, 4),
(33, 29, 28),
(34, 11, 4),
(35, 49, 48),
(36, 30, 29),
(37, 50, 49),
(38, 12, 11),
(39, 13, 12),
(40, 51, 50),
(41, 52, 51),
(42, 14, 13),
(43, 53, 30),
(44, 54, 19),
(45, 31, 30),
(46, 32, 31),
(47, 55, 54),
(48, 15, 14),
(49, 56, 55),
(50, 33, 32),
(51, 57, 56),
(52, 16, 15),
(53, 58, 1),
(54, 6, 5),
(55, 17, 16),
(56, 34, 33),
(57, 18, 17),
(58, 59, 58);

-- --------------------------------------------------------

--
-- Table structure for table `t_wapen`
--

CREATE TABLE `t_wapen` (
  `weaponID` int(10) NOT NULL,
  `d_naam` varchar(255) DEFAULT NULL,
  `d_kracht` int(45) DEFAULT NULL,
  `d_type` varchar(45) DEFAULT NULL,
  `d_kleur` varchar(45) DEFAULT NULL,
  `d_cooldownEffect` int(11) DEFAULT NULL,
  `d_dc` tinyint(1) DEFAULT 0,
  `d_gem` tinyint(1) DEFAULT 0,
  `d_draEffect` tinyint(1) DEFAULT 0,
  `d_infEffect` tinyint(1) DEFAULT 0,
  `d_colorEffect` tinyint(1) DEFAULT 0,
  `d_armorEffect` tinyint(1) DEFAULT 0,
  `d_cavEffect` tinyint(1) DEFAULT 0,
  `d_flyEffect` tinyint(1) DEFAULT 0,
  `d_brave` tinyint(1) DEFAULT 0,
  `d_killer` tinyint(1) DEFAULT 0,
  `d_bladetome` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_wapen`
--

INSERT INTO `t_wapen` (`weaponID`, `d_naam`, `d_kracht`, `d_type`, `d_kleur`, `d_cooldownEffect`, `d_dc`, `d_gem`, `d_draEffect`, `d_infEffect`, `d_colorEffect`, `d_armorEffect`, `d_cavEffect`, `d_flyEffect`, `d_brave`, `d_killer`, `d_bladetome`) VALUES
(1, 'Sapphire Lance', 12, 'Lance', 'B', 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(2, 'Armads', 16, 'Axe', 'G', 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(3, 'Aura', 14, 'Tome', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(4, 'Falchion', 16, 'Sword', 'R', 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0),
(5, 'Fujin Yumi', 14, 'Bow', 'C', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(6, 'Silver Lance', 15, 'Lance', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(7, 'Sieglinde', 16, 'Sword', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(8, 'Naga', 14, 'Tome', 'G', 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0),
(9, 'Poison Dagger', 5, 'Dagger', 'C', 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0),
(11, 'Gronnblade', 13, 'Tome', 'G', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1),
(12, 'Lightning Breath', 11, 'Dragon', 'B', 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(13, 'Silver Sword', 15, 'Sword', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(14, 'Raijinto', 16, 'Sword', 'R', 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(15, 'Fensalir', 16, 'Lance', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(16, 'Raudrblade', 13, 'Tome', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1),
(17, 'Flametongue', 15, 'Dragon', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(18, 'Brave Lance', 8, 'Lance', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(19, 'Brave Axe', 8, 'Axe', 'G', 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(20, 'Killer Lance', 11, 'Lance', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(23, 'Dark Breath', 13, 'Dragon', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(24, 'Mystletainn', 16, 'Sword', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(25, 'Siegmund', 16, 'Lance', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(27, 'Bolganone', 13, 'Tome', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(28, 'Sol Katti', 16, 'Sword', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(29, 'Hauteclere', 16, 'Axe', 'G', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(30, 'Dire Thunder', 9, 'Tome', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(31, 'Blarraven', 11, 'Tome', 'B', 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0),
(32, 'Cymbeline', 14, 'Tome', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(33, 'Lightning Breath', 11, 'Dragon', 'R', 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(34, 'Noatun', 16, 'Axe', 'G', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(35, 'Gronnraven', 11, 'Tome', 'G', 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0),
(36, 'Yato', 16, 'Sword', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(37, 'Gravity', 6, 'Staff', 'C', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(38, 'Durandal', 16, 'Sword', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(39, 'Light Breath', 13, 'Dragon', 'G', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(40, 'Brave Bow', 7, 'Bow', 'C', 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(41, 'Silver Axe', 15, 'Axe', 'G', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(42, 'Armorslayer', 12, 'Sword', 'R', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0),
(44, 'Parthia', 14, 'Bow', 'C', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(45, 'Brynhildr', 14, 'Tome', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(47, 'Killing Edge', 11, 'Sword', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(48, 'Excalibur', 14, 'Tome', 'G', 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0),
(49, 'Emerald Axe', 12, 'Axe', 'G', 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(50, 'Blarblade', 13, 'Tome', 'B', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1),
(51, 'Brave Sword', 8, 'Sword', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(54, 'Binding Blade', 16, 'Sword', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(55, 'Smoke Dagger', 9, 'Dagger', 'C', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(56, 'Tyrfing', 16, 'Sword', 'R', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(58, 'Blàrwolf', 10, 'Tome', 'B', 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `t_askill`
--
ALTER TABLE `t_askill`
  ADD PRIMARY KEY (`aSkillID`),
  ADD UNIQUE KEY `d_naam` (`d_naam`);

--
-- Indexes for table `t_beweging`
--
ALTER TABLE `t_beweging`
  ADD PRIMARY KEY (`movementID`);

--
-- Indexes for table `t_bskill`
--
ALTER TABLE `t_bskill`
  ADD PRIMARY KEY (`bSkillID`),
  ADD UNIQUE KEY `d_naam` (`d_naam`);

--
-- Indexes for table `t_cskill`
--
ALTER TABLE `t_cskill`
  ADD PRIMARY KEY (`cSkillID`),
  ADD UNIQUE KEY `d_naam` (`d_naam`);

--
-- Indexes for table `t_karakter`
--
ALTER TABLE `t_karakter`
  ADD PRIMARY KEY (`charID`);

--
-- Indexes for table `t_speciaal`
--
ALTER TABLE `t_speciaal`
  ADD PRIMARY KEY (`specialID`),
  ADD UNIQUE KEY `d_naam` (`d_naam`);

--
-- Indexes for table `t_tussenkara`
--
ALTER TABLE `t_tussenkara`
  ADD PRIMARY KEY (`karAID`),
  ADD KEY `charID` (`charID`),
  ADD KEY `aSkillID` (`aSkillID`);

--
-- Indexes for table `t_tussenkarb`
--
ALTER TABLE `t_tussenkarb`
  ADD PRIMARY KEY (`karBID`),
  ADD KEY `charID` (`charID`),
  ADD KEY `bSkillID` (`bSkillID`);

--
-- Indexes for table `t_tussenkarc`
--
ALTER TABLE `t_tussenkarc`
  ADD PRIMARY KEY (`karCID`),
  ADD KEY `charID` (`charID`),
  ADD KEY `cSkillID` (`cSkillID`);

--
-- Indexes for table `t_tussenkarmov`
--
ALTER TABLE `t_tussenkarmov`
  ADD PRIMARY KEY (`karMovID`),
  ADD KEY `charID` (`charID`),
  ADD KEY `movementID` (`movementID`);

--
-- Indexes for table `t_tussenkarspec`
--
ALTER TABLE `t_tussenkarspec`
  ADD PRIMARY KEY (`karSpecID`),
  ADD KEY `charID` (`charID`),
  ADD KEY `specialID` (`specialID`);

--
-- Indexes for table `t_tussenkarwapen`
--
ALTER TABLE `t_tussenkarwapen`
  ADD PRIMARY KEY (`karWapenID`),
  ADD KEY `charID` (`charID`),
  ADD KEY `weaponID` (`weaponID`);

--
-- Indexes for table `t_wapen`
--
ALTER TABLE `t_wapen`
  ADD PRIMARY KEY (`weaponID`),
  ADD UNIQUE KEY `weaponID` (`weaponID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `t_askill`
--
ALTER TABLE `t_askill`
  MODIFY `aSkillID` int(45) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT for table `t_beweging`
--
ALTER TABLE `t_beweging`
  MODIFY `movementID` int(45) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `t_bskill`
--
ALTER TABLE `t_bskill`
  MODIFY `bSkillID` int(45) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `t_cskill`
--
ALTER TABLE `t_cskill`
  MODIFY `cSkillID` int(45) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT for table `t_karakter`
--
ALTER TABLE `t_karakter`
  MODIFY `charID` int(45) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=60;

--
-- AUTO_INCREMENT for table `t_speciaal`
--
ALTER TABLE `t_speciaal`
  MODIFY `specialID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT for table `t_tussenkara`
--
ALTER TABLE `t_tussenkara`
  MODIFY `karAID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT for table `t_tussenkarb`
--
ALTER TABLE `t_tussenkarb`
  MODIFY `karBID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `t_tussenkarc`
--
ALTER TABLE `t_tussenkarc`
  MODIFY `karCID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT for table `t_tussenkarmov`
--
ALTER TABLE `t_tussenkarmov`
  MODIFY `karMovID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=309;

--
-- AUTO_INCREMENT for table `t_tussenkarspec`
--
ALTER TABLE `t_tussenkarspec`
  MODIFY `karSpecID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `t_tussenkarwapen`
--
ALTER TABLE `t_tussenkarwapen`
  MODIFY `karWapenID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT for table `t_wapen`
--
ALTER TABLE `t_wapen`
  MODIFY `weaponID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `t_tussenkara`
--
ALTER TABLE `t_tussenkara`
  ADD CONSTRAINT `t_tussenkara_ibfk_1` FOREIGN KEY (`charID`) REFERENCES `t_karakter` (`charID`),
  ADD CONSTRAINT `t_tussenkara_ibfk_2` FOREIGN KEY (`aSkillID`) REFERENCES `t_askill` (`aSkillID`);

--
-- Constraints for table `t_tussenkarb`
--
ALTER TABLE `t_tussenkarb`
  ADD CONSTRAINT `t_tussenkarb_ibfk_1` FOREIGN KEY (`charID`) REFERENCES `t_karakter` (`charID`),
  ADD CONSTRAINT `t_tussenkarb_ibfk_2` FOREIGN KEY (`bSkillID`) REFERENCES `t_bskill` (`bSkillID`);

--
-- Constraints for table `t_tussenkarc`
--
ALTER TABLE `t_tussenkarc`
  ADD CONSTRAINT `t_tussenkarc_ibfk_1` FOREIGN KEY (`charID`) REFERENCES `t_karakter` (`charID`),
  ADD CONSTRAINT `t_tussenkarc_ibfk_2` FOREIGN KEY (`cSkillID`) REFERENCES `t_cskill` (`cSkillID`);

--
-- Constraints for table `t_tussenkarmov`
--
ALTER TABLE `t_tussenkarmov`
  ADD CONSTRAINT `t_tussenkarmov_ibfk_1` FOREIGN KEY (`charID`) REFERENCES `t_karakter` (`charID`),
  ADD CONSTRAINT `t_tussenkarmov_ibfk_2` FOREIGN KEY (`movementID`) REFERENCES `t_beweging` (`movementID`);

--
-- Constraints for table `t_tussenkarspec`
--
ALTER TABLE `t_tussenkarspec`
  ADD CONSTRAINT `t_tussenkarspec_ibfk_1` FOREIGN KEY (`charID`) REFERENCES `t_karakter` (`charID`),
  ADD CONSTRAINT `t_tussenkarspec_ibfk_2` FOREIGN KEY (`specialID`) REFERENCES `t_speciaal` (`specialID`);

--
-- Constraints for table `t_tussenkarwapen`
--
ALTER TABLE `t_tussenkarwapen`
  ADD CONSTRAINT `t_tussenkarwapen_ibfk_1` FOREIGN KEY (`charID`) REFERENCES `t_karakter` (`charID`),
  ADD CONSTRAINT `t_tussenkarwapen_ibfk_2` FOREIGN KEY (`weaponID`) REFERENCES `t_wapen` (`weaponID`);
COMMIT;
