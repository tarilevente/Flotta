-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Feb 13. 16:09
-- Kiszolgáló verziója: 10.4.8-MariaDB
-- PHP verzió: 7.3.11

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
('NFG-116', '1234567890abcdefg', 465112, 1, 1, 1, 1, 'Isuzu', 'N1R'),
('NFG-117', 'abcdefghijklmnopq', 466678, 1, 1, 1, 1, 'Isuzu', 'N1R'),
('PGJ-791', '1234567890abcdefg', 228678, 1, 1, 1, 1, 'Fiat', 'Ducato maxi'),
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
(5, 'Papp ', 'Erzsébet', 'Makó', 'Mező u. 1.', '+36305656561', 'PappErzsi95', '12345678', 0, 0),
(6, 'Tari ', 'Olivér', 'Szeged', 'Makkos-erdő sor 28/a', '+36303030301', 'morbydance', 'morbyoliver', 0, 0);

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
(4, 'NFG-117', 0, 0, 0, 1, '2020-09-09', '2021-07-08', '2015-05-07');

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
(3, 4, 'PGJ-791');

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
(6, 'POL-169', '2020-01-02', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent pellentesque, neque et condimentum fermentum, lorem libero fringilla augue, vel commodo lorem lectus vitae metus. Ut rutrum est eros, ac bibendum nibh aliquet vitae. Vestibulum posuere ut mauris sit amet tristique. Nullam nec viverra magna. Praesent ac ipsum turpis. In et purus non nisl fringilla sagittis vel vel lacus. Vestibulum scelerisque, lectus ut lacinia vestibulum, ex nisi ornare tellus, eu luctus elit velit ut elit. Ut vehicula a odio vitae blandit. Quisque vulputate enim velit, sed blandit ipsum congue nec. Aenean venenatis nibh ante, quis gravida risus facilisis in. Quisque varius a quam eget imperdiet. Proin tristique, ex condimentum fermentum dictum, erat lectus iaculis felis, vitae cursus urna nisl vel odio. Sed nunc mi, feugiat ac dolor id, blandit gravida[...]', 0, 0),
(7, 'NFG-116', '2020-01-02', '\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"', 1, 0),
(8, 'NFG-116', '2020-01-09', '\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"', 0, 1),
(9, 'PGJ-791', '2019-10-02', 'INSERT INTO `szervizkonyvtabla` (`idszervizkonyv`, `rendszamHOZ`, `idopont`, `leiras`, `cascoE`, `biztositasE`) VALUES (NULL, \'NFG-116\', \'2020-01-02\', \'\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\', \'1\', \'0\'), (NULL, \'NFG-116\', \'2020-01-09\', \'\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\', \'0\', \'1\');INSERT INTO `szervizkonyvtabla` (`idszervizkonyv`, `rendszamHOZ`, `idopont`, `leiras`, `cascoE`, `biztositasE`) VALUES (NULL, \'NFG-116\', \'2020-01-02\', \'\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\', \'1\', \'0\'), (NULL, \'NFG-116\', \'2020-01-09\', \'\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\', \'0\', \'1\');INSERT INTO `szervizkonyvtabla` (`idszervizkonyv`, `rendszamHOZ`, `idopont`, `leiras`, `cascoE`, `biztositasE`) VALUES (NULL, \'NFG-116\', \'2020-01-02\', \'\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\', \'1\', \'0\'), (NULL, \'NFG-116\', \'2020-01-09\', \'\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\', \'0\', \'1\');INSERT INTO `szervizkonyvtabla` (`idszervizkonyv`, `rendszamHOZ`, `idopont`, `leiras`, `cascoE`, `biztositasE`) VALUES (NULL, \'NFG-116\', \'2020-01-02\', \'\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\', \'1\', \'0\'), (NULL, \'NFG-116\', \'2020-01-09\', \'\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\', \'0\', \'1\');', 0, 0),
(10, 'PGJ-791', '2020-01-04', 'INSERT INTO `szervizkonyvtabla` (`idszervizkonyv`, `rendszamHOZ`, `idopont`, `leiras`, `cascoE`, `biztositasE`) VALUES (NULL, \'NFG-116\', \'2020-01-02\', \'\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\', \'1\', \'0\'), (NULL, \'NFG-116\', \'2020-01-09\', \'\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\\\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\\\"\', \'0\', \'1\');', 0, 0);

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
  MODIFY `idFelh` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `muszakiallapottabla`
--
ALTER TABLE `muszakiallapottabla`
  MODIFY `idmuszakiAllapot` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT a táblához `soforautojatabla`
--
ALTER TABLE `soforautojatabla`
  MODIFY `idsoforAutoja` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `szervizkonyvtabla`
--
ALTER TABLE `szervizkonyvtabla`
  MODIFY `idszervizkonyv` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

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
