-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-05-2021 a las 17:58:43
-- Versión del servidor: 10.4.17-MariaDB
-- Versión de PHP: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `proyectopd2`
--
CREATE DATABASE IF NOT EXISTS `proyectopd2` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `proyectopd2`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbasevotantes`
--

CREATE TABLE `tbasevotantes` (
  `bas_cedula_identidad` varchar(15) NOT NULL,
  `bas_nombres` varchar(100) NOT NULL,
  `bas__apellidos` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tcandidato`
--

CREATE TABLE `tcandidato` (
  `can_id` int(11) NOT NULL,
  `can_rol` varchar(45) NOT NULL,
  `can_foto` longblob DEFAULT NULL,
  `FK_votantes_candidato` varchar(15) NOT NULL,
  `FK_partidopolitico_candidato` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tpartidopolitico`
--

CREATE TABLE `tpartidopolitico` (
  `par_id` int(11) NOT NULL,
  `par_logo` longblob NOT NULL,
  `par_nombre` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tvoto`
--

CREATE TABLE `tvoto` (
  `voto_id` int(11) NOT NULL,
  `FK_partidopolitico_voto` int(11) NOT NULL,
  `FK_votantes_voto` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbasevotantes`
--
ALTER TABLE `tbasevotantes`
  ADD PRIMARY KEY (`bas_cedula_identidad`),
  ADD UNIQUE KEY `bas_cedula_identidad_UNIQUE` (`bas_cedula_identidad`);

--
-- Indices de la tabla `tcandidato`
--
ALTER TABLE `tcandidato`
  ADD PRIMARY KEY (`can_id`),
  ADD UNIQUE KEY `can_cedula_identidad_UNIQUE` (`can_id`),
  ADD KEY `fk_tcandidato_tbasevotantes1_idx` (`FK_votantes_candidato`),
  ADD KEY `fk_tcandidato_tpartidopolitico1_idx` (`FK_partidopolitico_candidato`);

--
-- Indices de la tabla `tpartidopolitico`
--
ALTER TABLE `tpartidopolitico`
  ADD PRIMARY KEY (`par_id`),
  ADD UNIQUE KEY `par_id_UNIQUE` (`par_id`),
  ADD UNIQUE KEY `par_nombre_UNIQUE` (`par_nombre`);

--
-- Indices de la tabla `tvoto`
--
ALTER TABLE `tvoto`
  ADD PRIMARY KEY (`voto_id`),
  ADD UNIQUE KEY `voto_id_UNIQUE` (`voto_id`),
  ADD KEY `fk_tvoto_tpartidopolitico1_idx` (`FK_partidopolitico_voto`),
  ADD KEY `fk_tvoto_tbasevotantes1_idx` (`FK_votantes_voto`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tcandidato`
--
ALTER TABLE `tcandidato`
  MODIFY `can_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tpartidopolitico`
--
ALTER TABLE `tpartidopolitico`
  MODIFY `par_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tcandidato`
--
ALTER TABLE `tcandidato`
  ADD CONSTRAINT `fk_tcandidato_tbasevotantes1` FOREIGN KEY (`FK_votantes_candidato`) REFERENCES `tbasevotantes` (`bas_cedula_identidad`),
  ADD CONSTRAINT `fk_tcandidato_tpartidopolitico1` FOREIGN KEY (`FK_partidopolitico_candidato`) REFERENCES `tpartidopolitico` (`par_id`);

--
-- Filtros para la tabla `tvoto`
--
ALTER TABLE `tvoto`
  ADD CONSTRAINT `fk_tvoto_tbasevotantes1` FOREIGN KEY (`FK_votantes_voto`) REFERENCES `tbasevotantes` (`bas_cedula_identidad`),
  ADD CONSTRAINT `fk_tvoto_tpartidopolitico1` FOREIGN KEY (`FK_partidopolitico_voto`) REFERENCES `tpartidopolitico` (`par_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

insert into tbasevotantes (bas_cedula_identidad,bas_nombres,bas__apellidos)values ('9999999989','Master','Root');