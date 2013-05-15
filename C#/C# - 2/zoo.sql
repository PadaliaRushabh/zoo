-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 03, 2013 at 07:04 AM
-- Server version: 5.5.27
-- PHP Version: 5.4.7

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
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
-- Table structure for table `alert_details_tb`
--

CREATE TABLE IF NOT EXISTS `alert_details_tb` (
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
-- Table structure for table `animalrecords_tb`
--

CREATE TABLE IF NOT EXISTS `animalrecords_tb` (
  `ID_animalrecord` int(11) NOT NULL AUTO_INCREMENT,
  `name_animal` char(40) NOT NULL,
  PRIMARY KEY (`ID_animalrecord`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `animalrecords_tb`
--

INSERT INTO `animalrecords_tb` (`ID_animalrecord`, `name_animal`) VALUES
(1, 'Tiger'),
(2, 'Dragon'),
(3, 'Chicken');

-- --------------------------------------------------------

--
-- Table structure for table `animal_tb`
--

CREATE TABLE IF NOT EXISTS `animal_tb` (
  `ID_animal` int(11) NOT NULL AUTO_INCREMENT,
  `ID_cage` int(11) NOT NULL,
  `ID_animalrecord` int(11) NOT NULL,
  PRIMARY KEY (`ID_animal`),
  KEY `ID_animalrecord` (`ID_animalrecord`),
  KEY `ID_cage` (`ID_cage`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `cage_tb`
--

CREATE TABLE IF NOT EXISTS `cage_tb` (
  `ID_cage` int(11) NOT NULL AUTO_INCREMENT,
  `name` char(30) NOT NULL,
  `size_height` int(11) NOT NULL,
  `size_width` int(11) NOT NULL,
  `size_length` int(11) NOT NULL,
  `location_latitude` float NOT NULL,
  `location_longitude` float NOT NULL,
  `doors` int(11) NOT NULL,
  `animal_limit` int(11) NOT NULL,
  `people_limit` int(11) NOT NULL,
  `isopen` tinyint(1) NOT NULL,
  `human_inside` int(11) NOT NULL,
  `exhibit_inside` int(11) NOT NULL,
  PRIMARY KEY (`ID_cage`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

-- --------------------------------------------------------

--
-- Table structure for table `code_tb`
--

CREATE TABLE IF NOT EXISTS `code_tb` (
  `ID_code` varchar(10) NOT NULL DEFAULT '',
  `description` text NOT NULL,
  PRIMARY KEY (`ID_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `maintance_person_tb`
--

CREATE TABLE IF NOT EXISTS `maintance_person_tb` (
  `ID_person` int(11) NOT NULL AUTO_INCREMENT,
  `name_person` char(20) NOT NULL,
  PRIMARY KEY (`ID_person`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `user_tb`
--

CREATE TABLE IF NOT EXISTS `user_tb` (
  `user_name` char(20) NOT NULL DEFAULT '',
  `password` char(20) NOT NULL,
  PRIMARY KEY (`user_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_tb`
--

INSERT INTO `user_tb` (`user_name`, `password`) VALUES
('abc', '123');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `alert_details_tb`
--
ALTER TABLE `alert_details_tb`
  ADD CONSTRAINT `Alert_details_tb_ibfk_1` FOREIGN KEY (`ID_code`) REFERENCES `code_tb` (`ID_code`),
  ADD CONSTRAINT `Alert_details_tb_ibfk_2` FOREIGN KEY (`ID_cage`) REFERENCES `cage_tb` (`ID_cage`);

--
-- Constraints for table `animal_tb`
--
ALTER TABLE `animal_tb`
  ADD CONSTRAINT `Animal_tb_ibfk_1` FOREIGN KEY (`ID_animalrecord`) REFERENCES `animalrecords_tb` (`ID_animalrecord`),
  ADD CONSTRAINT `Animal_tb_ibfk_2` FOREIGN KEY (`ID_cage`) REFERENCES `cage_tb` (`ID_cage`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
