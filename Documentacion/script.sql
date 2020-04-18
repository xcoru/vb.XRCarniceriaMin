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
-- Table `xrcarniceriamin`.`articulo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `xrcarniceriamin`.`articulo` (
  `id_articulo` VARCHAR(20) NOT NULL,
  `descripcion` VARCHAR(120) NULL,
  `tipo` VARCHAR(20) NULL DEFAULT 'Granel',
  `precio` DECIMAL(10,2) NULL DEFAULT 0,
  `imagen` VARCHAR(500) NULL,
  `estado` INT NULL DEFAULT 1,
  PRIMARY KEY (`id_articulo`))
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
  `id_negocio` INT NOT NULL,
  `nombre` VARCHAR(120) NULL,
  `descripcion` VARCHAR(250) NULL,
  `direccion` VARCHAR(250) NULL,
  `telefono` VARCHAR(12) NULL,
  `logotipo` VARCHAR(500) NULL,
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
  `id_config` INT NOT NULL,
  `impresora` VARCHAR(120) NULL,
  PRIMARY KEY (`id_config`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `xrcarniceriamin`.`egreso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `xrcarniceriamin`.`egreso` (
  `id_egreso` INT NOT NULL AUTO_INCREMENT,
  `id_usuario` VARCHAR(20) NULL,
  `concepto` VARCHAR(250) NULL,
  `monto` DECIMAL(10,2) NULL,
  `hora` VARCHAR(20) NULL,
  `fecha` DATE NULL,
  PRIMARY KEY (`id_egreso`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Data for table `xrcarniceriamin`.`usuario`
-- -----------------------------------------------------
START TRANSACTION;
USE `xrcarniceriamin`;
INSERT INTO `xrcarniceriamin`.`usuario` (`id_usuario`, `nombre`, `password`, `estado`) VALUES ('admin', 'Administrador', 'admin', 1);

COMMIT;


-- -----------------------------------------------------
-- Data for table `xrcarniceriamin`.`negocio`
-- -----------------------------------------------------
START TRANSACTION;
USE `xrcarniceriamin`;
INSERT INTO `xrcarniceriamin`.`negocio` (`id_negocio`, `nombre`, `descripcion`, `direccion`, `telefono`, `logotipo`) VALUES (1, 'Carniceria', '\"Nombre Carniceria\"', 'Dirección', '000-000-0000', NULL);

COMMIT;


-- -----------------------------------------------------
-- Data for table `xrcarniceriamin`.`config`
-- -----------------------------------------------------
START TRANSACTION;
USE `xrcarniceriamin`;
INSERT INTO `xrcarniceriamin`.`config` (`id_config`, `impresora`) VALUES (1, 'POST-58');

COMMIT;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
