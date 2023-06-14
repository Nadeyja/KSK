CREATE DATABASE  IF NOT EXISTS `ksk` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `ksk`;
-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: ksk
-- ------------------------------------------------------
-- Server version	8.0.33

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `klient`
--

DROP TABLE IF EXISTS `klient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `klient` (
  `ID_Klient` int NOT NULL,
  `ID_Uzytkownik` int DEFAULT NULL,
  `imie` varchar(100) DEFAULT NULL,
  `nazwisko` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID_Klient`),
  KEY `klient_uzytkownicy_ID_Uzytkownik_fk` (`ID_Uzytkownik`),
  CONSTRAINT `klient_uzytkownicy_ID_Uzytkownik_fk` FOREIGN KEY (`ID_Uzytkownik`) REFERENCES `uzytkownicy` (`ID_Uzytkownik`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `klient`
--

LOCK TABLES `klient` WRITE;
/*!40000 ALTER TABLE `klient` DISABLE KEYS */;
INSERT INTO `klient` VALUES (1,1,'Asd','Asd'),(2,3,'Klient','Klientowski'),(3,5,'Klient','Klientelski'),(4,6,'Nadzieja','Hamerlak');
/*!40000 ALTER TABLE `klient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pracownik`
--

DROP TABLE IF EXISTS `pracownik`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pracownik` (
  `ID_Pracownik` int NOT NULL,
  `ID_Uzytkownik` int DEFAULT NULL,
  `imię` varchar(100) DEFAULT NULL,
  `nazwisko` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID_Pracownik`),
  KEY `pracownik_użytkownicy_ID_Użytkownik_fk` (`ID_Uzytkownik`),
  CONSTRAINT `pracownik_użytkownicy_ID_Użytkownik_fk` FOREIGN KEY (`ID_Uzytkownik`) REFERENCES `uzytkownicy` (`ID_Uzytkownik`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pracownik`
--

LOCK TABLES `pracownik` WRITE;
/*!40000 ALTER TABLE `pracownik` DISABLE KEYS */;
INSERT INTO `pracownik` VALUES (1,2,'Karol','Wojtyła'),(2,4,'Andrzej','Duda');
/*!40000 ALTER TABLE `pracownik` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `termin`
--

DROP TABLE IF EXISTS `termin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `termin` (
  `ID_Termin` int NOT NULL,
  `data` datetime DEFAULT NULL,
  `status` varchar(100) DEFAULT NULL,
  `ID_Klient` int DEFAULT NULL,
  PRIMARY KEY (`ID_Termin`),
  KEY `termin_klient_ID_Klient_fk` (`ID_Klient`),
  CONSTRAINT `termin_klient_ID_Klient_fk` FOREIGN KEY (`ID_Klient`) REFERENCES `klient` (`ID_Klient`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `termin`
--

LOCK TABLES `termin` WRITE;
/*!40000 ALTER TABLE `termin` DISABLE KEYS */;
INSERT INTO `termin` VALUES (1,'2023-06-14 02:48:08','Niezaakceptowany',4),(2,'2023-06-29 02:48:08','Niezaakceptowany',4),(3,'2023-07-01 02:48:08','Niezaakceptowany',3);
/*!40000 ALTER TABLE `termin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transport`
--

DROP TABLE IF EXISTS `transport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transport` (
  `ID_Transport` int NOT NULL,
  `data` datetime DEFAULT NULL,
  `trasa` varchar(200) DEFAULT NULL,
  `ID_Pracownik` int DEFAULT NULL,
  PRIMARY KEY (`ID_Transport`),
  KEY `ID_Pracownik` (`ID_Pracownik`),
  CONSTRAINT `ID_Pracownik` FOREIGN KEY (`ID_Pracownik`) REFERENCES `pracownik` (`ID_Pracownik`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transport`
--

LOCK TABLES `transport` WRITE;
/*!40000 ALTER TABLE `transport` DISABLE KEYS */;
/*!40000 ALTER TABLE `transport` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ulga`
--

DROP TABLE IF EXISTS `ulga`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ulga` (
  `stopień` int DEFAULT NULL,
  `ID_Klient` int DEFAULT NULL,
  KEY `ulga_klient_ID_Klient_fk` (`ID_Klient`),
  CONSTRAINT `ulga_klient_ID_Klient_fk` FOREIGN KEY (`ID_Klient`) REFERENCES `klient` (`ID_Klient`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ulga`
--

LOCK TABLES `ulga` WRITE;
/*!40000 ALTER TABLE `ulga` DISABLE KEYS */;
INSERT INTO `ulga` VALUES (1,1),(0,2),(2,3),(3,4);
/*!40000 ALTER TABLE `ulga` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uzytkownicy`
--

DROP TABLE IF EXISTS `uzytkownicy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `uzytkownicy` (
  `login` varchar(100) DEFAULT NULL,
  `haslo` varchar(100) DEFAULT NULL,
  `ID_Uzytkownik` int NOT NULL,
  PRIMARY KEY (`ID_Uzytkownik`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uzytkownicy`
--

LOCK TABLES `uzytkownicy` WRITE;
/*!40000 ALTER TABLE `uzytkownicy` DISABLE KEYS */;
INSERT INTO `uzytkownicy` VALUES ('klient','asd',1),('pracownik1','qwert',2),('klient2','zxcv',3),('prac','qwerty',4),('kli','asd',5),('nadeya','nadeya',6);
/*!40000 ALTER TABLE `uzytkownicy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wyniki_badan`
--

DROP TABLE IF EXISTS `wyniki_badan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `wyniki_badan` (
  `ID_Badanie` int NOT NULL,
  `grupa_krwi` varchar(10) DEFAULT NULL,
  `informacja_zwrotna` varchar(200) DEFAULT NULL,
  `ID_Klient` int DEFAULT NULL,
  PRIMARY KEY (`ID_Badanie`),
  KEY `ID_Klient` (`ID_Klient`),
  CONSTRAINT `ID_Klient` FOREIGN KEY (`ID_Klient`) REFERENCES `klient` (`ID_Klient`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wyniki_badan`
--

LOCK TABLES `wyniki_badan` WRITE;
/*!40000 ALTER TABLE `wyniki_badan` DISABLE KEYS */;
INSERT INTO `wyniki_badan` VALUES (1,'AB RH+','W normie',1),(2,'0 RH-','W normie',4),(3,'A RH-','Podwyższone leukocyty',2),(4,'AB RH+','W normie',3);
/*!40000 ALTER TABLE `wyniki_badan` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-14  3:41:48