-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: localhost    Database: tutoriasbd
-- ------------------------------------------------------
-- Server version	8.0.13

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
  `IdSemestre` int(11) NOT NULL,
  `IdCarrera` int(11) NOT NULL,
  PRIMARY KEY (`NumeroControl`),
  KEY `fkAlumnoCarrera` (`IdCarrera`),
  KEY `fkAlumnoSemestre` (`IdSemestre`),
  CONSTRAINT `fkAlumnoCarrera` FOREIGN KEY (`IdCarrera`) REFERENCES `carrera` (`id`),
  CONSTRAINT `fkAlumnoSemestre` FOREIGN KEY (`IdSemestre`) REFERENCES `semestre` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alumno`
--

LOCK TABLES `alumno` WRITE;
/*!40000 ALTER TABLE `alumno` DISABLE KEYS */;
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
  CONSTRAINT `fkAlumnoMateria` FOREIGN KEY (`IdAlumno`) REFERENCES `alumno` (`numerocontrol`),
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carrera`
--

LOCK TABLES `carrera` WRITE;
/*!40000 ALTER TABLE `carrera` DISABLE KEYS */;
INSERT INTO `carrera` VALUES (1,'Sistemas Computacionales'),(2,'Mecatronica'),(3,'Industrial'),(4,'Electromecanica'),(5,'Petrolera'),(6,'Administracion');
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
  PRIMARY KEY (`NumeroControl`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maestro`
--

LOCK TABLES `maestro` WRITE;
/*!40000 ALTER TABLE `maestro` DISABLE KEYS */;
INSERT INTO `maestro` VALUES ('2345','Ernestina','Leija','Ramirez','ernestina@itesrc.com'),('3456','Ignacio','Martinez','Garcia','nacho@itesrc.com');
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maestrosmateria`
--

LOCK TABLES `maestrosmateria` WRITE;
/*!40000 ALTER TABLE `maestrosmateria` DISABLE KEYS */;
INSERT INTO `maestrosmateria` VALUES (1,'FDP-0001','2345'),(2,'MAD-0001','3456'),(3,'RED-0005','3456');
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
INSERT INTO `materia` VALUES ('CAL-0001','Calculo Diferencial',1),('FDP-0001','Fundamentos de Programacion',1),('MAD-0001','Matematicas Discretas',1),('RED-0005','Redes',5);
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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `semestre`
--

LOCK TABLES `semestre` WRITE;
/*!40000 ALTER TABLE `semestre` DISABLE KEYS */;
INSERT INTO `semestre` VALUES (1,1),(2,2),(3,3),(4,4),(5,5),(6,6),(7,7),(8,8),(9,9);
/*!40000 ALTER TABLE `semestre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `usuarios` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `NumeroControl` varchar(8) NOT NULL,
  `Contraseña` varchar(16) NOT NULL,
  `Rol` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fkAlumnoUsuario` (`NumeroControl`),
  KEY `fkUsuariosRoles` (`Rol`),
  CONSTRAINT `fkAlumnoUsuario` FOREIGN KEY (`NumeroControl`) REFERENCES `alumno` (`numerocontrol`),
  CONSTRAINT `fkMaestroUsuario` FOREIGN KEY (`NumeroControl`) REFERENCES `maestro` (`numerocontrol`),
  CONSTRAINT `fkUsuariosRoles` FOREIGN KEY (`Rol`) REFERENCES `roles` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-02-09 14:35:27
