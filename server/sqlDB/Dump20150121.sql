CREATE DATABASE  IF NOT EXISTS `mmdametrobase` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `mmdametrobase`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win64 (x86_64)
--
-- Host: localhost    Database: mmdametrobase
-- ------------------------------------------------------
-- Server version	5.6.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `camera`
--

DROP TABLE IF EXISTS `camera`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `camera` (
  `cameraID` varchar(10) NOT NULL,
  `camIP` varchar(11) NOT NULL,
  `roadID` varchar(20) NOT NULL,
  `camType` varchar(45) NOT NULL,
  PRIMARY KEY (`cameraID`),
  UNIQUE KEY `camIP_UNIQUE` (`camIP`),
  UNIQUE KEY `roadID_UNIQUE` (`roadID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `camerastatus`
--

DROP TABLE IF EXISTS `camerastatus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `camerastatus` (
  `camID` varchar(45) NOT NULL,
  `density` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`camID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `clientstatus`
--

DROP TABLE IF EXISTS `clientstatus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientstatus` (
  `logID` int(11) NOT NULL,
  `deviceID` varchar(45) DEFAULT NULL,
  `type` varchar(10) DEFAULT NULL,
  `status` varchar(10) DEFAULT NULL,
  `timestamp` datetime DEFAULT NULL,
  PRIMARY KEY (`logID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `rdinfo`
--

DROP TABLE IF EXISTS `rdinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rdinfo` (
  `rdID` varchar(10) NOT NULL,
  `roadID` varchar(5) DEFAULT NULL,
  `ipAddress` varchar(45) DEFAULT NULL,
  `subnetMask` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`rdID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `rdlive`
--

DROP TABLE IF EXISTS `rdlive`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rdlive` (
  `roadID` varchar(5) NOT NULL,
  `trafficStat1` varchar(1) DEFAULT NULL,
  `trafficStat2` varchar(1) DEFAULT NULL,
  `trafficStat3` varchar(1) DEFAULT NULL,
  `weatherStat1` varchar(1) DEFAULT NULL,
  `weatherStat2` varchar(1) DEFAULT NULL,
  `weatherStat3` varchar(1) DEFAULT NULL,
  `advisory1` varchar(80) DEFAULT NULL,
  `advisory2` varchar(80) DEFAULT NULL,
  `advisory3` varchar(80) DEFAULT NULL,
  `advisory4` varchar(80) DEFAULT NULL,
  `advisory5` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`roadID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `realtime`
--

DROP TABLE IF EXISTS `realtime`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `realtime` (
  `idRealTime` int(11) NOT NULL,
  `roadID` varchar(20) NOT NULL,
  `density` varchar(45) DEFAULT NULL,
  `aveSpeed` int(3) DEFAULT NULL,
  `floodLevel` int(2) DEFAULT NULL,
  `warnings` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`roadID`,`idRealTime`),
  UNIQUE KEY `roadID_UNIQUE` (`roadID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `road`
--

DROP TABLE IF EXISTS `road`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `road` (
  `roadID` varchar(5) NOT NULL,
  `roadRegion` varchar(5) DEFAULT NULL,
  `gpsLat` varchar(255) DEFAULT NULL,
  `gpsLong` varchar(255) DEFAULT NULL,
  `roadName` varchar(45) DEFAULT NULL,
  `apiTSWrite` varchar(255) DEFAULT NULL,
  `apiTSRead` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`roadID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `sensor`
--

DROP TABLE IF EXISTS `sensor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sensor` (
  `sensorID` varchar(10) NOT NULL,
  `gsmNum` varchar(13) NOT NULL,
  `roadID` varchar(10) NOT NULL,
  `tsWriteAPI` varchar(45) DEFAULT NULL,
  `tsReadAPI` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`sensorID`),
  UNIQUE KEY `roadID_UNIQUE` (`roadID`),
  UNIQUE KEY `gsmNum_UNIQUE` (`gsmNum`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `sensorupdates`
--

DROP TABLE IF EXISTS `sensorupdates`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sensorupdates` (
  `roadID` varchar(40) NOT NULL,
  `sender` varchar(45) DEFAULT NULL,
  `rainStatus` varchar(45) DEFAULT NULL,
  `floodStatus` varchar(45) DEFAULT NULL,
  `floodLevel` varchar(45) DEFAULT NULL,
  `time` datetime DEFAULT NULL,
  PRIMARY KEY (`roadID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `idUSER` int(11) NOT NULL,
  `user` varchar(45) NOT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`user`),
  UNIQUE KEY `user_UNIQUE` (`user`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-01-21  1:37:19
