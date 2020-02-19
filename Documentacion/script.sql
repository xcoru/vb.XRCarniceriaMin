-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema xrcarniceriamin
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema xrcarniceriamin
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `xrcarniceriamin` DEFAULT CHARACTER SET utf8 ;
USE `xrcarniceriamin` ;

-- -----------------------------------------------------
-- Table `xrcarniceriamin`.`catalogo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `xrcarniceriamin`.`catalogo` (
  `id_catalogo` VARCHAR(20) NOT NULL,
  `descripcion` VARCHAR(120) NULL,
  `tipo` VARCHAR(20) NULL DEFAULT 'Granel',
  `precio` DECIMAL(10,2) NULL DEFAULT 0,
  `estado` INT NULL DEFAULT 1,
  PRIMARY KEY (`id_catalogo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `xrcarniceriamin`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `xrcarniceriamin`.`usuario` (
  `id_usuario` VARCHAR(20) NOT NULL,
  `nombre` VARCHAR(60) NULL,
  `password` VARCHAR(20) NULL,
  `estado` INT NULL DEFAULT 1,
  PRIMARY KEY (`id_usuario`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `xrcarniceriamin`.`negocio`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `xrcarniceriamin`.`negocio` (
  `id_negocio` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(120) NULL,
  `descripcion` VARCHAR(250) NULL,
  `direccion` VARCHAR(250) NULL,
  `telefono` VARCHAR(12) NULL,
  `logotipo` LONGBLOB NULL,
  PRIMARY KEY (`id_negocio`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `xrcarniceriamin`.`ventas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `xrcarniceriamin`.`ventas` (
  `id_venta` INT NOT NULL AUTO_INCREMENT,
  `folio` VARCHAR(20) NULL DEFAULT 0,
  `id_usuario` VARCHAR(20) NULL,
  `id_catalogo` VARCHAR(20) NULL,
  `cantidad` INT NULL DEFAULT 0,
  `peso` DECIMAL(10,2) NULL DEFAULT 0,
  `precio` DECIMAL(10,2) NULL,
  `total` DECIMAL(10,2) NULL,
  `hora` VARCHAR(20) NULL,
  `fecha` DATE NULL,
  `estado` INT NULL DEFAULT 1,
  PRIMARY KEY (`id_venta`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `xrcarniceriamin`.`config`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `xrcarniceriamin`.`config` (
  `id_config` INT NOT NULL AUTO_INCREMENT,
  `impresora` VARCHAR(120) NULL,
  PRIMARY KEY (`id_config`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
