-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Feb 26. 15:52
-- Kiszolgáló verziója: 10.4.11-MariaDB
-- PHP verzió: 7.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `autok`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `autoktabla`
--

CREATE TABLE `autoktabla` (
  `rendszam` varchar(7) COLLATE utf8_hungarian_ci NOT NULL,
  `alvazszam` varchar(17) COLLATE utf8_hungarian_ci NOT NULL,
  `km` int(7) DEFAULT NULL,
  `autoradio` tinyint(2) DEFAULT 1,
  `vontatokotel` tinyint(2) DEFAULT 1,
  `bikakabel` tinyint(2) DEFAULT 1,
  `mentodoboz` tinyint(2) DEFAULT 1,
  `gyartmany` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `tipus` varchar(20) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `autoktabla`
--

INSERT INTO `autoktabla` (`rendszam`, `alvazszam`, `km`, `autoradio`, `vontatokotel`, `bikakabel`, `mentodoboz`, `gyartmany`, `tipus`) VALUES
('IHN-760', 'JMY4RZ6TG8WFN32P9', 383083, 0, 0, 0, 0, 'Fiat', 'Ducato'),
('ILP-525', 'QUSEH6MHIG3OJ6ABH', 288368, 0, 0, 0, 1, 'Toyota', 'Dyna'),
('INP-152', '5CQIP4LJ0YXOWKVQ8', 509831, 0, 1, 0, 1, 'Fiat', 'Ducato'),
('IOM-256', 'DJE6JXBKG570HEMDK', 308443, 0, 1, 1, 0, 'Toyota', 'Dyna'),
('IOP-678', 'P5KDPQCOUULSH9OSL', 686322, 1, 0, 0, 1, 'Fiat', 'Ducato'),
('JIH-255', 'Y3NRRK8FXSESTRATB', 102445, 1, 1, 0, 0, 'Fiat', 'Ducato'),
('JJJ-834', 'QWO97G1FQKBOB2Y5T', 186268, 1, 0, 1, 1, 'Toyota', 'Dyna'),
('JKH-298', '81W9UDYD82ZHCONED', 474882, 1, 0, 1, 0, 'Toyota', 'Dyna'),
('JNH-628', '9JTLNPK4AJZB85PC7', 717227, 0, 0, 0, 1, 'Fiat', 'Ducato'),
('JOK-726', '7HHS6H39YX3ATQ5V3', 460165, 1, 1, 0, 0, 'Toyota', 'Dyna'),
('KHM-434', 'JRRME9SKR0T230EUT', 748630, 0, 1, 0, 0, 'Toyota', 'Dyna'),
('KJH-787', '4OCLN5HR526984JW5', 32359, 1, 1, 0, 1, 'Fiat', 'Ducato'),
('KKJ-791', 'EKTM8TZAC0P7SVXQV', 80832, 0, 1, 1, 1, 'Isuzu', 'M21H'),
('KKK-117', 'PJNHQ9PW8EOFDQTGY', 170206, 0, 0, 1, 0, 'Isuzu', 'M21H'),
('LJM-815', 'VCXIAOG1GFBL09Q6L', 476302, 1, 1, 1, 0, 'Toyota', 'Dyna'),
('LJN-175', '3JNQLWD5XVA4K74TU', 264009, 0, 0, 0, 1, 'Fiat', 'Ducato'),
('LKJ-453', 'SDX9HYDF3AI2GN7J6', 410078, 1, 1, 0, 0, 'Toyota', 'Dyna'),
('LLL-723', 'I4WLN7CWL0W4QYMO9', 16803, 1, 0, 0, 1, 'Toyota', 'Dyna'),
('LLN-817', '5K3TSXWBWVQOKYYBY', 738600, 1, 0, 1, 0, 'Toyota', 'Dyna'),
('LML-948', '6U65IAM0LZ2GSU120', 42307, 0, 0, 1, 1, 'Toyota', 'Dyna'),
('MKL-994', '1P0I6ICYH2RQARC4K', 322590, 1, 1, 0, 1, 'Isuzu', 'M21H'),
('MMI-572', '7EQKNE3OQ0Q05JVZW', 457833, 0, 0, 1, 1, 'Fiat', 'Ducato'),
('MMK-645', 'WOR3EX2OMGQ809538', 492008, 0, 0, 1, 0, 'Toyota', 'Dyna'),
('MNI-847', 'R5LK8MD4FIAMWPMJC', 738607, 1, 0, 1, 0, 'Toyota', 'Dyna'),
('MNP-865', 'GMYXUFBHOK8VPFFR2', 86741, 1, 1, 1, 0, 'Toyota', 'Dyna'),
('NFG-116', '1234567890abcdefg', 465112, 1, 1, 1, 1, 'Isuzu', 'N1R'),
('NFG-117', 'abcdefghijklmnopq', 466678, 1, 1, 1, 1, 'Isuzu', 'N1R'),
('NHH-651', 'K6K4RLLTH0LUOG7V3', 724621, 0, 1, 1, 0, 'Isuzu', 'M21H'),
('NIJ-461', 'Y5R9N1FVTEY8SAAZ5', 515897, 0, 1, 1, 0, 'Toyota', 'Dyna'),
('NJH-164', 'EA1XYUPXE3I5I16NA', 501516, 1, 1, 1, 0, 'Toyota', 'Dyna'),
('NKP-942', 'W6C4I0FC2LMU6NZEY', 364573, 1, 1, 0, 0, 'Toyota', 'Dyna'),
('NMP-178', '1605L8VS4MWZ1TZ6L', 630685, 1, 0, 0, 1, 'Toyota', 'Dyna'),
('NNH-507', 'R7NQ33F31GCNBVKZF', 356090, 1, 1, 0, 0, 'Fiat', 'Ducato'),
('NPJ-208', 'DIPCO6TLOC22I3SJ6', 57878, 0, 0, 0, 0, 'Fiat', 'Ducato'),
('OLO-872', '1MT1SQJWOQC4DF8LD', 79392, 1, 0, 1, 0, 'Toyota', 'Dyna'),
('OLP-295', 'HDRWFJZXBGQTLFSVC', 350235, 0, 0, 0, 1, 'Isuzu', 'M21H'),
('OMH-990', 'H5T5WVMG0WQ2GSRLF', 390481, 0, 1, 0, 0, 'Toyota', 'Dyna'),
('OMN-527', '9MSLB4WJ2YK5TTD7V', 689507, 0, 0, 0, 0, 'Fiat', 'Ducato'),
('OPK-107', 'BM6I19Z8GJXRCNW8K', 301247, 1, 1, 0, 1, 'Isuzu', 'M21H'),
('PGJ-791', '1234567890abcdefg', 228678, 1, 1, 1, 1, 'Fiat', 'Ducato maxi'),
('PHJ-175', 'H5XWNEL4PUZTCIZY1', 664561, 1, 1, 1, 1, 'Toyota', 'Dyna'),
('PHK-119', 'FMHF7GXS93BO715SD', 120775, 0, 1, 0, 0, 'Toyota', 'Dyna'),
('PIP-334', 'XV6HC6GDEWUC4OOU5', 130788, 1, 1, 1, 1, 'Toyota', 'Dyna'),
('POL-169', '1234567890abcdeff', 45645, 1, 1, 1, 1, 'Fiat', 'Ducato maxi');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `felhtabla`
--

CREATE TABLE `felhtabla` (
  `idFelh` int(11) NOT NULL,
  `vezetekNev` mediumtext COLLATE utf8_hungarian_ci NOT NULL,
  `keresztNev` mediumtext COLLATE utf8_hungarian_ci NOT NULL,
  `varos` mediumtext COLLATE utf8_hungarian_ci DEFAULT NULL,
  `utcaHsz` mediumtext COLLATE utf8_hungarian_ci DEFAULT NULL,
  `telefon` varchar(13) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `belepesNev` mediumtext COLLATE utf8_hungarian_ci NOT NULL,
  `belepesJelszo` mediumtext COLLATE utf8_hungarian_ci NOT NULL,
  `soforE` tinyint(2) NOT NULL DEFAULT 0,
  `adminE` tinyint(2) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `felhtabla`
--

INSERT INTO `felhtabla` (`idFelh`, `vezetekNev`, `keresztNev`, `varos`, `utcaHsz`, `telefon`, `belepesNev`, `belepesJelszo`, `soforE`, `adminE`) VALUES
(1, 'Kiss', 'József', 'Szeged', 'Ősz utca 1/A', '06301234567', 'admin', 'admin', 0, 1),
(2, 'Tóth ', 'Imre', 'Mórahalom', 'Szél u. 1.', '+36301234567', 'Tóth', 'Imre', 1, 0),
(3, 'Joó', 'Krisztián', 'Zákányszék', 'Mező u. 1.', '+36201234567', '123456', '123456', 1, 1),
(4, 'Masa', 'Pista', 'Domaszék', 'Arany János u. 2.', '+36204567891', '234567', '234567', 1, 1),
(5, 'Kovács', 'László', 'Szeged', 'Kossuth Lajos  utca 64. ', '0630 9779922', 'LászlóSzeged', 'LászlóSzeged64', 1, 1),
(6, 'Tóth', 'István', 'Mórahalom', 'Arany János  tér 52. ', '0630 2492220', 'IstvánMórahalom', 'IstvánMórahalom52', 0, 1),
(7, 'Szabó', 'József', 'Hódmezővásárhely', 'Ady Endre utca  67. ', '0670 6567832', 'JózsefHódmezővásárhely', 'JózsefHódmezővásárhely67', 1, 1),
(8, 'Horváth', 'János', 'Domaszék', 'Dózsa György sgt. 17. ', '0630 2787781', 'JánosDomaszék', 'JánosDomaszék17', 0, 0),
(9, 'Varga', 'Zoltán', 'Szeged', 'Petőfi utca 74. ', '0630 303621', 'ZoltánSzeged', 'ZoltánSzeged74', 1, 0),
(10, 'Kiss', 'Sándor', 'Mórahalom', 'Rákóczi tér 65. ', '0620 9372927', 'SándorMórahalom', 'SándorMórahalom65', 0, 1),
(11, 'Molnár', 'Gábor', 'Szeged', 'József Attila utca 16. ', '0670 7616733', 'GáborSzeged', 'GáborSzeged16', 0, 1),
(12, 'Németh', 'Ferenc', 'Forráskút', 'Béke utca 19. ', '0670 647685', 'FerencForráskút', 'FerencForráskút19', 0, 0),
(13, 'Farkas', 'Attila', 'Szeged', 'Szabadság tér 41. ', '0630 7540042', 'AttilaSzeged', 'AttilaSzeged41', 0, 0),
(14, 'Balogh', 'Péter', 'Bordány', 'Damjanich utca  82. ', '0630 6679417', 'PéterBordány', 'PéterBordány82', 1, 0),
(15, 'Papp', 'Tamás', 'Öttömös', 'Szőlő sgt. 68. ', '0630 6397113', 'TamásÖttömös', 'TamásÖttömös68', 1, 0),
(16, 'Lakatos', 'Zsolt', 'Ópusztaszer', 'Vezér utca 6. ', '0670 9927847', 'ZsoltÓpusztaszer', 'ZsoltÓpusztaszer6', 1, 1),
(17, 'Takács', 'Tibor', 'Mórahalom', 'Millenium sétány 64. ', '0630 2634980', 'TiborMórahalom', 'TiborMórahalom64', 1, 0),
(18, 'Juhász', 'András', 'Szeged', 'Kossuth Lajos  utca 38. ', '0630 3148967', 'AndrásSzeged', 'AndrásSzeged38', 1, 1),
(19, 'Mészáros', 'Csaba', 'Szeged', 'Arany János  utca 77. ', '0620 7030782', 'CsabaSzeged', 'CsabaSzeged77', 0, 0),
(20, 'Oláh', 'Imre', 'Mórahalom', 'Ady Endre tér 61. ', '0670 1500113', 'ImreMórahalom', 'ImreMórahalom61', 0, 1),
(21, 'Simon', 'Lajos', 'Hódmezővásárhely', 'Dózsa György utca  50. ', '0670 137435', 'LajosHódmezővásárhely', 'LajosHódmezővásárhely50', 0, 1),
(22, 'Rácz', 'György', 'Domaszék', 'Petőfi sgt. 79. ', '0630 2518287', 'GyörgyDomaszék', 'GyörgyDomaszék79', 1, 0),
(23, 'Fekete', 'Balázs', 'Szeged', 'Rákóczi utca 23. ', '0630 8101467', 'BalázsSzeged', 'BalázsSzeged23', 0, 1),
(24, 'Gulyás', 'Gyula', 'Mórahalom', 'József Attila tér 65. ', '0630 2862758', 'GyulaMórahalom', 'GyulaMórahalom65', 1, 1),
(25, 'Biró', 'Mihály', 'Szeged', 'Béke utca 86. ', '0670 299475', 'MihálySzeged', 'MihálySzeged86', 1, 1),
(26, 'Király', 'Károly', 'Forráskút', 'Szabadság utca 69. ', '0630 7217125', 'KárolyForráskút', 'KárolyForráskút69', 1, 1),
(27, 'László', 'Róbert', 'Szeged', 'Damjanich tér 7. ', '0620 8601372', 'RóbertSzeged', 'RóbertSzeged7', 0, 0),
(28, 'Balog', 'Béla', 'Bordány', 'Szőlő utca  46. ', '0620 4428107', 'BélaBordány', 'BélaBordány46', 1, 1),
(29, 'Katona', 'Dávid', 'Szeged', 'Vezér sgt. 40. ', '0670 9200988', 'DávidSzeged', 'DávidSzeged40', 0, 0),
(30, 'Bogdán', 'Dániel', 'Ópusztaszer', 'Millenium utca 60. ', '0670 4131273', 'DánielÓpusztaszer', 'DánielÓpusztaszer60', 0, 1),
(31, 'Jakab', 'Ádám', 'Mórahalom', 'Kossuth Lajos  tér 76. ', '0630 9769103', 'ÁdámMórahalom', 'ÁdámMórahalom76', 0, 0),
(32, 'Sándor', 'ZOÉ', 'Szeged', 'Arany János  köz 84. ', '0630 1064106', 'ZOÉSzeged', 'ZOÉSzeged84', 0, 0),
(33, 'Boros', 'ANNA', 'Szeged', 'Ady Endre utca 68. ', '0630 9589146', 'ANNASzeged', 'ANNASzeged68', 1, 1),
(34, 'Váradi', 'EMMA', 'Mórahalom', 'Dózsa György tér 35. ', '0670 6346099', 'EMMAMórahalom', 'EMMAMórahalom35', 0, 1),
(35, 'Fazekas', 'LUCA', 'Hódmezővásárhely', 'Petőfi utca  98. ', '0630 3943338', 'LUCAHódmezővásárhely', 'LUCAHódmezővásárhely98', 1, 1),
(36, 'Kelemen', 'LÉNA', 'Domaszék', 'Rákóczi sgt. 91. ', '0630 3750566', 'LÉNADomaszék', 'LÉNADomaszék91', 0, 0),
(37, 'Antal', 'ZSÓFIA', 'Szeged', 'József Attila utca 49. ', '0620 2562391', 'ZSÓFIASzeged', 'ZSÓFIASzeged49', 0, 1),
(38, 'Orosz', 'BOGLÁRKA', 'Mórahalom', 'Béke tér 47. ', '0670 7050626', 'BOGLÁRKAMórahalom', 'BOGLÁRKAMórahalom47', 1, 1),
(39, 'Somogyi', 'JÁZMIN', 'Szeged', 'Szabadság utca 40. ', '0670 8167792', 'JÁZMINSzeged', 'JÁZMINSzeged40', 1, 0),
(40, 'Fülöp', 'LILI', 'Forráskút', 'Damjanich utca 38. ', '0630 50398', 'LILIForráskút', 'LILIForráskút38', 1, 1),
(41, 'Veres', 'NÓRA', 'Szeged', 'Szőlő tér 58. ', '0630 5117520', 'NÓRASzeged', 'NÓRASzeged58', 0, 0),
(42, 'Vincze', 'LAURA', 'Bordány', 'Vezér utca  12. ', '0630 3758203', 'LAURABordány', 'LAURABordány12', 1, 0),
(43, 'Szücs', 'MAJA', 'Öttömös', 'Millenium sgt. 72. ', '0670 5102852', 'MAJAÖttömös', 'MAJAÖttömös72', 0, 0),
(44, 'Hajdu', 'MIRA', 'Zsombó', 'Ág utca 97. ', '0630 1997527', 'MIRAZsombó', 'MIRAZsombó97', 1, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `muszakiallapottabla`
--

CREATE TABLE `muszakiallapottabla` (
  `idmuszakiAllapot` int(11) NOT NULL,
  `rendszamHOZ` varchar(7) COLLATE utf8_hungarian_ci NOT NULL,
  `matricaMegyei` tinyint(2) NOT NULL DEFAULT 0,
  `matricaOrszagos` tinyint(2) NOT NULL DEFAULT 0,
  `teligumi` tinyint(2) NOT NULL DEFAULT 0,
  `nyarigumi` tinyint(2) NOT NULL DEFAULT 1,
  `muszakiErv` date NOT NULL,
  `biztosErv` date NOT NULL,
  `evjarat` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `muszakiallapottabla`
--

INSERT INTO `muszakiallapottabla` (`idmuszakiAllapot`, `rendszamHOZ`, `matricaMegyei`, `matricaOrszagos`, `teligumi`, `nyarigumi`, `muszakiErv`, `biztosErv`, `evjarat`) VALUES
(1, 'PGJ-791', 0, 0, 1, 0, '2020-03-12', '2020-06-12', '2010-01-01'),
(2, 'POL-169', 0, 1, 1, 0, '2022-10-23', '2021-05-04', '2017-05-06'),
(3, 'NFG-116', 0, 0, 0, 1, '2020-01-23', '2020-01-25', '2015-05-07'),
(4, 'NFG-117', 0, 0, 0, 1, '2020-09-09', '2021-07-08', '2015-05-07'),
(5, 'NHH-651', 1, 0, 1, 0, '2021-12-14', '2020-11-06', '2019-10-12'),
(6, 'NNH-507', 1, 0, 1, 0, '2020-05-12', '2021-01-30', '2018-10-10'),
(7, 'NKP-942', 1, 0, 1, 0, '2021-08-25', '2021-01-30', '2016-04-01'),
(8, 'LLL-723', 0, 0, 1, 0, '2021-01-27', '2021-01-30', '2017-01-20'),
(9, 'LLN-817', 0, 0, 1, 0, '2020-08-04', '2020-08-21', '2019-07-19'),
(10, 'ILP-525', 0, 0, 0, 1, '2020-05-10', '2020-12-23', '2017-05-05'),
(11, 'IOP-678', 0, 0, 1, 0, '2021-06-13', '2021-01-30', '2015-02-05'),
(12, 'OLP-295', 1, 0, 1, 0, '2021-04-04', '2021-01-30', '2018-12-14'),
(13, 'JIH-255', 1, 0, 1, 0, '2020-08-25', '2021-01-30', '2016-06-09'),
(14, 'IOM-256', 0, 0, 1, 0, '2020-02-09', '2021-01-30', '2015-05-07'),
(15, 'MNP-865', 1, 0, 1, 0, '2021-06-05', '2021-01-30', '2019-01-23'),
(16, 'MNI-847', 0, 0, 0, 1, '2020-01-08', '2020-08-13', '2019-02-26'),
(17, 'LJM-815', 1, 0, 1, 0, '2021-09-20', '2020-07-08', '2018-04-16'),
(18, 'KJH-787', 1, 0, 1, 0, '2022-04-17', '2021-01-30', '2016-06-14'),
(19, 'MKL-994', 0, 0, 1, 0, '2020-05-10', '2021-01-30', '2019-04-27'),
(20, 'INP-152', 0, 0, 1, 0, '2020-03-22', '2021-01-30', '2016-07-14'),
(21, 'NMP-178', 1, 0, 0, 1, '2021-10-07', '2020-07-13', '2016-09-17'),
(22, 'KHM-434', 0, 0, 1, 0, '2020-09-13', '2021-01-30', '2017-05-14'),
(23, 'NIJ-461', 1, 0, 1, 0, '2020-10-06', '2021-01-30', '2017-05-22'),
(24, 'NJH-164', 1, 0, 1, 0, '2021-03-21', '2021-01-30', '2018-04-26'),
(25, 'IHN-760', 1, 0, 1, 0, '2021-05-04', '2020-10-11', '2018-06-15'),
(26, 'OPK-107', 1, 0, 0, 1, '2022-02-01', '2021-01-30', '2016-01-18'),
(27, 'LJN-175', 1, 0, 1, 0, '2022-04-18', '2021-01-30', '2018-05-01'),
(28, 'PIP-334', 1, 0, 1, 0, '2021-05-05', '2021-01-30', '2015-05-25'),
(29, 'PHJ-175', 0, 1, 1, 0, '2021-08-25', '2020-11-16', '2017-05-23'),
(30, 'JKH-298', 1, 1, 1, 0, '2020-08-23', '2021-01-30', '2016-07-27'),
(31, 'LKJ-453', 1, 1, 1, 0, '2020-09-17', '2020-12-27', '2018-03-05'),
(32, 'MMI-572', 0, 1, 0, 1, '2022-07-26', '2021-01-30', '2018-08-22'),
(33, 'KKK-117', 0, 1, 1, 0, '2022-08-07', '2021-01-30', '2016-10-14'),
(34, 'NPJ-208', 1, 1, 1, 0, '2022-08-26', '2021-01-30', '2018-06-09'),
(35, 'JOK-726', 1, 1, 1, 0, '2021-07-23', '2021-01-30', '2019-11-13'),
(36, 'OLO-872', 1, 1, 1, 0, '2021-12-01', '2021-01-30', '2015-08-07'),
(37, 'OMH-990', 1, 0, 1, 0, '2020-09-19', '2020-09-28', '2018-11-13'),
(38, 'MMK-645', 1, 0, 1, 0, '2022-11-25', '2021-01-30', '2018-03-27'),
(39, 'JNH-628', 0, 0, 0, 1, '2020-05-19', '2021-01-30', '2015-12-11'),
(40, 'KKJ-791', 0, 0, 1, 0, '2020-10-02', '2020-08-11', '2015-07-11'),
(41, 'OMN-527', 1, 0, 1, 0, '2022-09-04', '2020-08-30', '2016-07-01'),
(42, 'LML-948', 1, 0, 1, 0, '2020-10-22', '2021-01-30', '2017-05-28'),
(43, 'JJJ-834', 0, 0, 1, 0, '2022-10-14', '2021-01-30', '2015-01-08'),
(44, 'PHK-119', 0, 0, 1, 0, '2022-12-12', '2021-01-30', '2017-08-19');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `soforautojatabla`
--

CREATE TABLE `soforautojatabla` (
  `idsoforAutoja` int(11) NOT NULL,
  `idfelh` int(11) NOT NULL,
  `rendszam` varchar(7) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `soforautojatabla`
--

INSERT INTO `soforautojatabla` (`idsoforAutoja`, `idfelh`, `rendszam`) VALUES
(1, 3, 'NFG-116'),
(2, 2, 'NFG-117'),
(3, 4, 'PGJ-791'),
(4, 5, 'IOM-256'),
(5, 7, 'MNI-847'),
(6, 9, 'JKH-298'),
(7, 14, 'MMI-572'),
(8, 15, 'LJM-815'),
(9, 16, 'KKK-117'),
(10, 17, 'KJH-787'),
(11, 18, 'OLP-295'),
(12, 22, 'IHN-760'),
(13, 24, 'PIP-334'),
(14, 25, 'LLN-817'),
(15, 26, 'OLO-872'),
(16, 28, 'KHM-434'),
(17, 33, 'NJH-164'),
(18, 35, 'MMK-645'),
(19, 38, 'LLL-723'),
(20, 39, 'NIJ-461'),
(21, 40, 'JIH-255'),
(22, 42, 'NNH-507'),
(23, 44, 'ILP-525');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `szervizkonyvtabla`
--

CREATE TABLE `szervizkonyvtabla` (
  `idszervizkonyv` int(11) NOT NULL,
  `rendszamHOZ` varchar(7) COLLATE utf8_hungarian_ci NOT NULL,
  `idopont` date NOT NULL,
  `leiras` longtext COLLATE utf8_hungarian_ci DEFAULT NULL,
  `cascoE` tinyint(2) NOT NULL DEFAULT 0,
  `biztositasE` tinyint(2) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `szervizkonyvtabla`
--

INSERT INTO `szervizkonyvtabla` (`idszervizkonyv`, `rendszamHOZ`, `idopont`, `leiras`, `cascoE`, `biztositasE`) VALUES
(1, 'NFG-116', '2019-10-11', 'A mai napon az autó eleje törött őzkár következtében.', 1, 0),
(2, 'NFG-116', '2020-01-03', 'Az autón olajcsere került végrehajtásra.\r\nEgyéb hiba nem került feltárásra.', 0, 0),
(3, 'PGJ-791', '2019-10-09', 'Olajcsere.', 0, 0),
(4, 'NFG-117', '2020-01-10', 'Az autót ideiglenesen kivonták a forgalomból.', 0, 0),
(5, 'POL-169', '2020-01-02', 'Félretankolás történt, szerviz megtörtént.', 0, 0),
(6, 'NHH-651', '2019-08-02', 'Az első olajcsere megtörtént', 0, 0),
(7, 'NNH-507', '2018-02-17', 'Az első olajcsere megtörtént', 0, 0),
(8, 'NKP-942', '2018-11-12', 'Az első olajcsere megtörtént', 0, 0),
(9, 'LLN-817', '2019-10-04', 'Az első olajcsere megtörtént', 0, 0),
(10, 'IOP-678', '2019-07-26', 'Az első olajcsere megtörtént', 0, 0),
(11, 'OLP-295', '2017-08-13', 'Az első olajcsere megtörtént', 0, 0),
(12, 'JIH-255', '2019-05-23', 'Az első olajcsere megtörtént', 0, 0),
(13, 'MNP-865', '2019-04-17', 'Az első olajcsere megtörtént', 0, 0),
(14, 'IOM-256', '2017-12-01', 'Az első olajcsere megtörtént', 0, 0),
(15, 'MNI-847', '2018-01-23', 'Az első olajcsere megtörtént', 0, 0),
(16, 'LJM-815', '2018-04-12', 'Az első olajcsere megtörtént', 0, 0),
(17, 'MKL-994', '2017-07-03', 'Az első olajcsere megtörtént', 0, 0),
(18, 'NMP-178', '2016-09-15', 'Az első olajcsere megtörtént', 0, 0),
(19, 'KHM-434', '2019-01-31', 'Az első olajcsere megtörtént', 0, 0),
(20, 'NIJ-461', '2017-02-15', 'Az első olajcsere megtörtént', 0, 0),
(21, 'NJH-164', '2016-10-13', 'Az első olajcsere megtörtént', 0, 0),
(22, 'IHN-760', '2019-04-26', 'Az első olajcsere megtörtént', 0, 0),
(23, 'OPK-107', '2018-11-11', 'Az első olajcsere megtörtént', 0, 0),
(24, 'LJN-175', '2017-02-28', 'Az első olajcsere megtörtént', 0, 0),
(25, 'PIP-334', '2018-10-07', 'Az első olajcsere megtörtént', 0, 0),
(26, 'PHJ-175', '2016-05-30', 'Az első olajcsere megtörtént', 0, 0),
(27, 'LKJ-453', '2017-01-05', 'Az első olajcsere megtörtént', 0, 0),
(28, 'MMI-572', '2016-08-23', 'Az első olajcsere megtörtént', 0, 0),
(29, 'KKK-117', '2019-11-08', 'Az első olajcsere megtörtént', 0, 0),
(30, 'NPJ-208', '2020-01-28', 'Az első olajcsere megtörtént', 0, 0),
(31, 'JOK-726', '2020-02-16', 'Az első olajcsere megtörtént', 0, 0),
(32, 'OLO-872', '2016-03-05', 'Az első olajcsere megtörtént', 0, 0),
(33, 'OMH-990', '2016-02-16', 'Az első olajcsere megtörtént', 0, 0),
(34, 'MMK-645', '2020-02-27', 'Az első olajcsere megtörtént', 0, 0),
(35, 'JNH-628', '2018-12-06', 'Az első olajcsere megtörtént', 0, 0),
(36, 'KKJ-791', '2016-08-09', 'Az első olajcsere megtörtént', 0, 0),
(37, 'JJJ-834', '2020-02-16', 'Az első olajcsere megtörtént', 0, 0),
(38, 'PHK-119', '2016-10-21', 'Az első olajcsere megtörtént', 0, 0),
(39, 'KHM-434', '2020-01-05', 'A következő alkatrészek cseréje történt meg: fékbetét,  olajszűrő. ', 0, 0),
(40, 'NHH-651', '2010-04-02', 'A következő alkatrészek cseréje történt meg: porlasztófej,  izzók,  raktér világítás.', 0, 0),
(41, 'NKP-942', '2019-08-02', 'A következő alkatrészek cseréje történt meg: olajszűrő,  kárpit ', 0, 0),
(42, 'PIP-334', '2019-07-08', 'A következő alkatrészek cseréje történt meg: izzók,  fékbetét. ', 0, 0),
(43, 'OLP-295', '2018-07-27', 'A következő alkatrészek cseréje történt meg: kárpit,  olajszűrő. ', 0, 0),
(44, 'MNI-847', '2019-11-11', 'A következő alkatrészek cseréje történt meg: raktér világítás,  izzók. ', 0, 0),
(45, 'LJN-175', '2018-04-12', '\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"   ', 0, 1),
(46, 'MKL-994', '2018-09-09', '\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"   ', 0, 1),
(47, 'LJM-815', '2019-12-19', '\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"   ', 0, 1),
(48, 'NIJ-461', '2018-10-21', '\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"   ', 0, 1),
(49, 'NJH-164', '2017-11-04', '\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"   ', 1, 0),
(50, 'JNH-628', '2019-06-25', '\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"   ', 1, 0),
(51, 'KKK-117', '2020-02-22', '\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"   ', 1, 0),
(52, 'NNH-507', '2019-01-16', '\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"   ', 1, 0),
(53, 'JKH-298', '2020-04-30', 'Két autó koccant, másik fél a vétkes.   ', 0, 1),
(54, 'LKJ-453', '2018-02-04', 'Két autó koccant, másik sofőr a vétkes.   ', 0, 1),
(55, 'NMP-178', '2017-10-21', 'Két autó koccant, másik fél a vétkes sofőr.   ', 0, 1),
(56, 'OPK-107', '2019-03-09', 'Zakatoló  hang hallatszott az autóban, a szerviz nem talált hibát.  ', 0, 0),
(57, 'PHK-119', '2017-12-03', 'Kattogó  hang hallatszott az autóban, a szerviz nem talált hibát.  ', 0, 0),
(58, 'PHJ-175', '2017-05-10', 'Fütyülő  hang hallatszott az autóban, a szerviz nem talált hibát.  ', 0, 0),
(59, 'IOM-256', '2018-11-09', 'Sípoló  hang hallatszott az autóban, a szerviz nem talált hibát.  ', 0, 0),
(60, 'KHM-434', '2020-03-07', 'Az autó őzkár következtében törött.', 1, 0),
(61, 'NHH-651', '2020-10-27', 'Az autó őzkár következtében törött.', 1, 0),
(62, 'NKP-942', '2019-09-21', 'Az autó őzkár következtében törött.', 1, 0),
(63, 'PIP-334', '2019-07-17', 'Az autó őzkár következtében törött.', 1, 0),
(64, 'OLP-295', '2018-02-13', 'Az autó őzkár következtében törött.', 1, 0),
(65, 'MNI-847', '2019-02-11', 'Az autó őzkár következtében törött.', 1, 0),
(66, 'LJN-175', '2018-08-01', 'Az autó őzkár következtében törött.', 1, 0),
(67, 'MKL-994', '2018-04-09', 'A sofőr hibájából következően az autó fényezése megsérült.', 0, 0),
(68, 'LJM-815', '2019-07-10', 'A sofőr hibájából következően az autó fényezése megsérült.', 0, 0),
(69, 'NIJ-461', '2018-11-07', 'A sofőr hibájából következően az autó fényezése megsérült.', 0, 0),
(70, 'NJH-164', '2017-10-23', 'A sofőr hibájából következően az autó fényezése megsérült.', 0, 0),
(71, 'JNH-628', '2019-02-10', 'A sofőr hibájából következően az autó fényezése megsérült.', 0, 0),
(72, 'KKK-117', '2020-05-16', 'A sofőr hibájából következően az autó fényezése megsérült.', 0, 0),
(73, 'NNH-507', '2019-02-25', 'Az autó oldalán sérülés következett be. A sérülés nem a sofőr hibájából történt.', 0, 0),
(74, 'JKH-298', '2021-03-19', 'Az autó oldalán sérülés következett be. A sérülés nem a sofőr hibájából történt.', 0, 0),
(75, 'LKJ-453', '2018-07-14', 'Az autó oldalán sérülés következett be. A sérülés nem a sofőr hibájából történt.', 0, 1),
(76, 'NMP-178', '2017-04-09', 'Az autó eleje törött.', 0, 1),
(77, 'OPK-107', '2019-07-26', 'A gépjármű ajtaja nem csukódott, kenés vált szükségessé.', 0, 0),
(78, 'PHK-119', '2017-10-28', 'Izzócsere.', 0, 0),
(79, 'PHJ-175', '2017-11-17', 'Izzócsere.', 0, 0),
(80, 'IOM-256', '2018-03-09', 'Izzócsere.', 0, 0),
(81, 'MNP-865', '2020-02-17', 'A fék meghibásodott, fékcsere. Bevasalás megtörtént.', 0, 0),
(82, 'MMI-572', '2017-09-03', 'A fék meghibásodott, fékcsere. Bevasalás megtörtént.', 0, 0),
(83, 'OMH-990', '2017-03-10', 'A fék meghibásodott, fékcsere. Bevasalás megtörtént.', 0, 0),
(84, 'OLO-872', '2017-09-12', 'A fék meghibásodott, fékcsere. Bevasalás megtörtént.', 0, 0),
(85, 'KKJ-791', '2017-05-09', 'A fék meghibásodott, fékcsere. Bevasalás megtörtént.', 0, 0);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `autoktabla`
--
ALTER TABLE `autoktabla`
  ADD PRIMARY KEY (`rendszam`);

--
-- A tábla indexei `felhtabla`
--
ALTER TABLE `felhtabla`
  ADD PRIMARY KEY (`idFelh`);

--
-- A tábla indexei `muszakiallapottabla`
--
ALTER TABLE `muszakiallapottabla`
  ADD PRIMARY KEY (`idmuszakiAllapot`),
  ADD KEY `rendszamHOZ` (`rendszamHOZ`);

--
-- A tábla indexei `soforautojatabla`
--
ALTER TABLE `soforautojatabla`
  ADD PRIMARY KEY (`idsoforAutoja`),
  ADD KEY `idfelh` (`idfelh`),
  ADD KEY `rendszam` (`rendszam`);

--
-- A tábla indexei `szervizkonyvtabla`
--
ALTER TABLE `szervizkonyvtabla`
  ADD PRIMARY KEY (`idszervizkonyv`),
  ADD KEY `rendszamHOZ` (`rendszamHOZ`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `felhtabla`
--
ALTER TABLE `felhtabla`
  MODIFY `idFelh` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT a táblához `muszakiallapottabla`
--
ALTER TABLE `muszakiallapottabla`
  MODIFY `idmuszakiAllapot` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT a táblához `soforautojatabla`
--
ALTER TABLE `soforautojatabla`
  MODIFY `idsoforAutoja` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT a táblához `szervizkonyvtabla`
--
ALTER TABLE `szervizkonyvtabla`
  MODIFY `idszervizkonyv` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=86;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `muszakiallapottabla`
--
ALTER TABLE `muszakiallapottabla`
  ADD CONSTRAINT `muszakiallapottabla_ibfk_1` FOREIGN KEY (`rendszamHOZ`) REFERENCES `autoktabla` (`rendszam`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Megkötések a táblához `soforautojatabla`
--
ALTER TABLE `soforautojatabla`
  ADD CONSTRAINT `soforautojatabla_ibfk_1` FOREIGN KEY (`idfelh`) REFERENCES `felhtabla` (`idFelh`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `soforautojatabla_ibfk_2` FOREIGN KEY (`rendszam`) REFERENCES `autoktabla` (`rendszam`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Megkötések a táblához `szervizkonyvtabla`
--
ALTER TABLE `szervizkonyvtabla`
  ADD CONSTRAINT `rendszamHOZ` FOREIGN KEY (`rendszamHOZ`) REFERENCES `autoktabla` (`rendszam`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
