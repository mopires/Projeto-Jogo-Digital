/*
SQLyog Community v12.12 (32 bit)
MySQL - 10.1.34-MariaDB : Database - jogo_atiradores
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`jogo_atiradores` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `jogo_atiradores`;

/*Table structure for table `atiradores` */

DROP TABLE IF EXISTS `atiradores`;

CREATE TABLE `atiradores` (
  `id_atirador` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) NOT NULL,
  `mira` int(11) DEFAULT NULL,
  `municao` int(11) DEFAULT NULL,
  `dinheiro` float DEFAULT NULL,
  `vitorias` int(11) DEFAULT NULL,
  `derrotas` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_atirador`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

/*Data for the table `atiradores` */

insert  into `atiradores`(`id_atirador`,`nome`,`mira`,`municao`,`dinheiro`,`vitorias`,`derrotas`) values (1,'Dimitri ',50,100,200,0,0),(2,'Nikolai ',80,20,300,0,0),(3,'Mikhail ',70,20,200,0,0),(4,'Boris ',60,150,100,0,0),(5,'Serguei',75,30,500,0,0),(6,'Samiro ',82,12,100,0,0);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
