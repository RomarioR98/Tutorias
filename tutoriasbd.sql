-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: localhost    Database: tutorias
-- ------------------------------------------------------
-- Server version	8.0.12

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `alumno`
--

DROP TABLE IF EXISTS `alumno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `alumno` (
  `NumeroControl` varchar(8) NOT NULL,
  `Nombres` varchar(50) NOT NULL,
  `ApPaterno` varchar(30) NOT NULL,
  `ApMaterno` varchar(30) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Contraseña` varchar(200) NOT NULL,
  `IdSemestre` int(11) NOT NULL,
  `IdCarrera` int(11) NOT NULL,
  `IdRol` int(11) NOT NULL,
  `Activo` bit(1) NOT NULL,
  PRIMARY KEY (`NumeroControl`),
  KEY `fkAlumnoCarrera` (`IdCarrera`),
  KEY `fkAlumnoSemestre` (`IdSemestre`),
  KEY `fkAlumnosRoles` (`IdRol`),
  CONSTRAINT `fkAlumnoCarrera` FOREIGN KEY (`IdCarrera`) REFERENCES `carrera` (`id`),
  CONSTRAINT `fkAlumnoSemestre` FOREIGN KEY (`IdSemestre`) REFERENCES `semestre` (`id`),
  CONSTRAINT `fkAlumnosRoles` FOREIGN KEY (`IdRol`) REFERENCES `roles` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alumno`
--

LOCK TABLES `alumno` WRITE;
/*!40000 ALTER TABLE `alumno` DISABLE KEYS */;
INSERT INTO `alumno` VALUES ('151G0242','pstty','salazar','De Leon','pattyguiselle@hotmail.com','kdlkkd',3,3,1,_binary '\0'),('161g023','patty','Garcia','De Leon','pattyguiselle89@hotmail.com','b5bcb826e0e4f6e130443cda06903d72',1,4,1,_binary '\0'),('161G0241','Roma','Rodriguez','Anguiano','romar98@hotmail.com','aec6500cec2a7aea5d70d829fd8cba9e',1,4,1,_binary '\0'),('161G0242','patty','salazar','De León','pattyguiselle@hotmail.com','ldckdñl',1,4,1,_binary '\0'),('161g0248','Alejandro','Garcia','De León','pattyguiselle897@hotmail.com','a105be819c569edb0a428e03d80e7265',1,4,1,_binary '\0'),('161G089','Alejandro','Garcia','Cardona','pattyguiselle@hotmail.com','lcvlkclkñ',10,1,1,_binary '\0');
/*!40000 ALTER TABLE `alumno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alumnosmateria`
--

DROP TABLE IF EXISTS `alumnosmateria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `alumnosmateria` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `IdMateria` varchar(8) NOT NULL,
  `IdAlumno` varchar(8) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fkAlumnoMateria` (`IdAlumno`),
  KEY `fkMateriaAlumno` (`IdMateria`),
  CONSTRAINT `fkAlumnoMateria` FOREIGN KEY (`IdAlumno`) REFERENCES `alumno` (`NumeroControl`),
  CONSTRAINT `fkMateriaAlumno` FOREIGN KEY (`IdMateria`) REFERENCES `materia` (`clave`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alumnosmateria`
--

LOCK TABLES `alumnosmateria` WRITE;
/*!40000 ALTER TABLE `alumnosmateria` DISABLE KEYS */;
/*!40000 ALTER TABLE `alumnosmateria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `carrera`
--

DROP TABLE IF EXISTS `carrera`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `carrera` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Carrera` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carrera`
--

LOCK TABLES `carrera` WRITE;
/*!40000 ALTER TABLE `carrera` DISABLE KEYS */;
INSERT INTO `carrera` VALUES (1,'Mecatronica'),(2,'Electromecanica'),(3,'Sistemas Computacionales'),(4,'Administración'),(5,'Petrolera'),(6,'Industrial');
/*!40000 ALTER TABLE `carrera` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maestro`
--

DROP TABLE IF EXISTS `maestro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `maestro` (
  `NumeroControl` varchar(4) NOT NULL,
  `Nombres` varchar(50) NOT NULL,
  `ApPaterno` varchar(30) NOT NULL,
  `ApMaterno` varchar(30) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Contraseña` varchar(16) NOT NULL,
  `IdRol` int(11) NOT NULL,
  `Activo` bit(1) NOT NULL,
  PRIMARY KEY (`NumeroControl`),
  KEY `fkMaestrosRoles` (`IdRol`),
  CONSTRAINT `fkMaestrosRoles` FOREIGN KEY (`IdRol`) REFERENCES `roles` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maestro`
--

LOCK TABLES `maestro` WRITE;
/*!40000 ALTER TABLE `maestro` DISABLE KEYS */;
/*!40000 ALTER TABLE `maestro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maestrosmateria`
--

DROP TABLE IF EXISTS `maestrosmateria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `maestrosmateria` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `IdMateria` varchar(8) NOT NULL,
  `IdMaestro` varchar(4) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fkMaestroMateria` (`IdMaestro`),
  KEY `fkMateriaMestro` (`IdMateria`),
  CONSTRAINT `fkMaestroMateria` FOREIGN KEY (`IdMaestro`) REFERENCES `maestro` (`numerocontrol`),
  CONSTRAINT `fkMateriaMestro` FOREIGN KEY (`IdMateria`) REFERENCES `materia` (`clave`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maestrosmateria`
--

LOCK TABLES `maestrosmateria` WRITE;
/*!40000 ALTER TABLE `maestrosmateria` DISABLE KEYS */;
/*!40000 ALTER TABLE `maestrosmateria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materia`
--

DROP TABLE IF EXISTS `materia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `materia` (
  `Clave` varchar(8) NOT NULL,
  `Materia` varchar(50) NOT NULL,
  `IdSemestre` int(11) NOT NULL,
  `Activo` bit(1) NOT NULL,
  PRIMARY KEY (`Clave`),
  KEY `fkMateriaSemestre` (`IdSemestre`),
  CONSTRAINT `fkMateriaSemestre` FOREIGN KEY (`IdSemestre`) REFERENCES `semestre` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materia`
--

LOCK TABLES `materia` WRITE;
/*!40000 ALTER TABLE `materia` DISABLE KEYS */;
/*!40000 ALTER TABLE `materia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `roles` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `rol` varchar(40) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Alumno'),(2,'Maestro');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `semestre`
--

DROP TABLE IF EXISTS `semestre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `semestre` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `No_sem` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `semestre`
--

LOCK TABLES `semestre` WRITE;
/*!40000 ALTER TABLE `semestre` DISABLE KEYS */;
INSERT INTO `semestre` VALUES (1,1),(2,2),(3,3),(4,4),(5,5),(6,6),(7,7),(8,8),(9,9),(10,10);
/*!40000 ALTER TABLE `semestre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'tutorias'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-02-17 19:41:12
