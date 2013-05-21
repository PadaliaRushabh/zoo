-- phpMyAdmin SQL Dump
-- version 4.0.0-rc1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 18, 2013 at 01:40 PM
-- Server version: 5.5.31-0ubuntu0.13.04.1
-- PHP Version: 5.4.9-4ubuntu2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `zoo`
--

-- --------------------------------------------------------

--
-- Table structure for table `Alert_details_tb`
--

CREATE TABLE IF NOT EXISTS `Alert_details_tb` (
  `ID_alert_details` int(11) NOT NULL AUTO_INCREMENT,
  `ID_code` varchar(10) NOT NULL,
  `ID_cage` int(11) DEFAULT NULL,
  `admin_message` text NOT NULL,
  `isopen` tinyint(1) NOT NULL,
  `time_start` datetime NOT NULL,
  `time_end` datetime DEFAULT NULL,
  PRIMARY KEY (`ID_alert_details`),
  KEY `ID_code` (`ID_code`),
  KEY `ID_cage` (`ID_cage`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `AnimalRecords_tb`
--

CREATE TABLE IF NOT EXISTS `AnimalRecords_tb` (
  `ID_animalrecord` int(11) NOT NULL AUTO_INCREMENT,
  `name_animal` char(40) NOT NULL,
  PRIMARY KEY (`ID_animalrecord`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `AnimalRecords_tb`
--

INSERT INTO `AnimalRecords_tb` (`ID_animalrecord`, `name_animal`) VALUES
(1, 'tiger');

-- --------------------------------------------------------

--
-- Table structure for table `Animal_tb`
--

CREATE TABLE IF NOT EXISTS `Animal_tb` (
  `ID_animal` int(11) NOT NULL AUTO_INCREMENT,
  `ID_cage` int(11) NOT NULL,
  `ID_animalrecord` int(11) NOT NULL,
  PRIMARY KEY (`ID_animal`),
  KEY `ID_animalrecord` (`ID_animalrecord`),
  KEY `ID_cage` (`ID_cage`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

-- --------------------------------------------------------

--
-- Table structure for table `Cage_tb`
--

CREATE TABLE IF NOT EXISTS `Cage_tb` (
  `ID_cage` int(11) NOT NULL AUTO_INCREMENT,
  `name` char(30) NOT NULL,
  `size_height` int(11) NOT NULL,
  `size_width` int(11) NOT NULL,
  `size_length` int(11) NOT NULL,
  `location_latitude` float NOT NULL,
  `location_longitude` float NOT NULL,
  `doors` int(11) NOT NULL,
  `isopen` tinyint(1) NOT NULL,
  `human_inside` tinyint(1) NOT NULL,
  `exhibit_inside` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID_cage`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

-- --------------------------------------------------------

--
-- Table structure for table `Code_tb`
--

CREATE TABLE IF NOT EXISTS `Code_tb` (
  `ID_code` varchar(10) NOT NULL DEFAULT '',
  `description` text NOT NULL,
  PRIMARY KEY (`ID_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Maintance_person_tb`
--

CREATE TABLE IF NOT EXISTS `Maintance_person_tb` (
  `ID_person` int(11) NOT NULL AUTO_INCREMENT,
  `name_person` char(20) NOT NULL,
  PRIMARY KEY (`ID_person`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `User_tb`
--

CREATE TABLE IF NOT EXISTS `User_tb` (
  `user_name` char(20) NOT NULL DEFAULT '',
  `password` char(20) NOT NULL,
  PRIMARY KEY (`user_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Alert_details_tb`
--
ALTER TABLE `Alert_details_tb`
  ADD CONSTRAINT `Alert_details_tb_ibfk_1` FOREIGN KEY (`ID_code`) REFERENCES `Code_tb` (`ID_code`),
  ADD CONSTRAINT `Alert_details_tb_ibfk_2` FOREIGN KEY (`ID_cage`) REFERENCES `Cage_tb` (`ID_cage`);

--
-- Constraints for table `Animal_tb`
--
ALTER TABLE `Animal_tb`
  ADD CONSTRAINT `Animal_tb_ibfk_1` FOREIGN KEY (`ID_animalrecord`) REFERENCES `AnimalRecords_tb` (`ID_animalrecord`),
  ADD CONSTRAINT `Animal_tb_ibfk_2` FOREIGN KEY (`ID_cage`) REFERENCES `Cage_tb` (`ID_cage`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
