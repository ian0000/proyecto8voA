-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema proyectopd2
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `proyectopd2` ;

-- -----------------------------------------------------
-- Schema proyectopd2
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `proyectopd2` DEFAULT CHARACTER SET utf8 ;
USE `proyectopd2` ;

-- -----------------------------------------------------
-- Table `proyectopd2`.`tbasevotantes`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `proyectopd2`.`tbasevotantes` ;

CREATE TABLE IF NOT EXISTS `proyectopd2`.`tbasevotantes` (
  `bas_cedula_identidad` VARCHAR(15) NOT NULL,
  `bas_nombres` VARCHAR(100) NOT NULL,
  `bas__apellidos` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`bas_cedula_identidad`),
  UNIQUE INDEX `bas_cedula_identidad_UNIQUE` (`bas_cedula_identidad` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `proyectopd2`.`tpartidopolitico`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `proyectopd2`.`tpartidopolitico` ;

CREATE TABLE IF NOT EXISTS `proyectopd2`.`tpartidopolitico` (
  `par_id` INT NOT NULL AUTO_INCREMENT,
  `par_logo` LONGBLOB NOT NULL,
  `par_nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`par_id`),
  UNIQUE INDEX `par_id_UNIQUE` (`par_id` ASC) ,
  UNIQUE INDEX `par_nombre_UNIQUE` (`par_nombre` ASC) )
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `proyectopd2`.`tcandidato`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `proyectopd2`.`tcandidato` ;

CREATE TABLE IF NOT EXISTS `proyectopd2`.`tcandidato` (
  `can_id` INT NOT NULL AUTO_INCREMENT,
  `can_rol` VARCHAR(45) NOT NULL,
  `can_foto` LONGBLOB NULL DEFAULT NULL,
  `FK_votantes_candidato` VARCHAR(15) NOT NULL,
  `FK_partidopolitico_candidato` INT NOT NULL,
  PRIMARY KEY (`can_id`),
  UNIQUE INDEX `can_cedula_identidad_UNIQUE` (`can_id` ASC) ,
  INDEX `fk_tcandidato_tbasevotantes1_idx` (`FK_votantes_candidato` ASC) ,
  INDEX `fk_tcandidato_tpartidopolitico1_idx` (`FK_partidopolitico_candidato` ASC) ,
  CONSTRAINT `fk_tcandidato_tbasevotantes1`
    FOREIGN KEY (`FK_votantes_candidato`)
    REFERENCES `proyectopd2`.`tbasevotantes` (`bas_cedula_identidad`),
  CONSTRAINT `fk_tcandidato_tpartidopolitico1`
    FOREIGN KEY (`FK_partidopolitico_candidato`)
    REFERENCES `proyectopd2`.`tpartidopolitico` (`par_id`))
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `proyectopd2`.`tvoto`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `proyectopd2`.`tvoto` ;

CREATE TABLE IF NOT EXISTS `proyectopd2`.`tvoto` (
  `voto_id` INT NOT NULL AUTO_INCREMENT,
  `FK_partidopolitico_voto` INT NOT NULL,
  `FK_votantes_voto` VARCHAR(15) NOT NULL,
  PRIMARY KEY (`voto_id`),
  UNIQUE INDEX `voto_id_UNIQUE` (`voto_id` ASC) ,
  INDEX `fk_tvoto_tpartidopolitico1_idx` (`FK_partidopolitico_voto` ASC) ,
  INDEX `fk_tvoto_tbasevotantes1_idx` (`FK_votantes_voto` ASC) ,
  CONSTRAINT `fk_tvoto_tbasevotantes1`
    FOREIGN KEY (`FK_votantes_voto`)
    REFERENCES `proyectopd2`.`tbasevotantes` (`bas_cedula_identidad`),
  CONSTRAINT `fk_tvoto_tpartidopolitico1`
    FOREIGN KEY (`FK_partidopolitico_voto`)
    REFERENCES `proyectopd2`.`tpartidopolitico` (`par_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

INSERT INTO tbasevotantes VALUES('9999999999','Master','Root');
INSERT INTO `tpartidopolitico`(`par_id`, `par_logo`, `par_nombre`) VALUES (1,'null','NULO');