-- phpMyAdmin SQL Dump
-- version 3.4.11.1deb1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Mar 14, 2013 at 09:23 PM
-- Server version: 5.5.29
-- PHP Version: 5.4.6-1ubuntu1.2

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
-- Table structure for table `alert_details`
--

CREATE TABLE IF NOT EXISTS `alert_details` (
  `ID_Code` varchar(10) NOT NULL,
  `ID_cage` varchar(10) NOT NULL,
  `admin_message` text,
  `alert_status` tinyint(1) DEFAULT NULL,
  `time_start` datetime NOT NULL,
  `time_end` datetime DEFAULT NULL,
  KEY `ID_cage` (`ID_cage`),
  KEY `ID_Code` (`ID_Code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `animal_master`
--

CREATE TABLE IF NOT EXISTS `animal_master` (
  `ID_Animal` varchar(10) NOT NULL,
  `ID_cage` varchar(10) NOT NULL,
  `name_animal` text NOT NULL,
  `quantity_animal` int(11) NOT NULL,
  PRIMARY KEY (`ID_Animal`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cage_master`
--

CREATE TABLE IF NOT EXISTS `cage_master` (
  `ID_cage` varchar(10) NOT NULL,
  `name_cage` text NOT NULL,
  `ID_type_cage` varchar(10) NOT NULL,
  `size_height` int(11) NOT NULL,
  `size_width` int(11) NOT NULL,
  `size_length` int(11) NOT NULL,
  `location_longitude` int(11) NOT NULL,
  `location_latitude` int(11) NOT NULL,
  `doors_cage` int(11) NOT NULL,
  PRIMARY KEY (`ID_cage`),
  KEY `ID_type_cage` (`ID_type_cage`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cage_status`
--

CREATE TABLE IF NOT EXISTS `cage_status` (
  `ID_cage` varchar(10) NOT NULL,
  `cage_status` tinyint(1) NOT NULL,
  `human_detector` tinyint(1) NOT NULL,
  `exhibit_inside` tinyint(1) NOT NULL,
  KEY `ID_cage` (`ID_cage`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cage_type_master`
--

CREATE TABLE IF NOT EXISTS `cage_type_master` (
  `ID_type_cage` varchar(10) NOT NULL,
  `description_type_cage` text NOT NULL,
  `quantity_type_cage` int(11) NOT NULL,
  PRIMARY KEY (`ID_type_cage`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `code_master`
--

CREATE TABLE IF NOT EXISTS `code_master` (
  `ID_code` varchar(10) NOT NULL,
  `description_code` text NOT NULL,
  PRIMARY KEY (`ID_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `maintance_person_master`
--

CREATE TABLE IF NOT EXISTS `maintance_person_master` (
  `ID_person` varchar(10) NOT NULL,
  `name_person` text NOT NULL,
  PRIMARY KEY (`ID_person`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `user_action_log`
--

CREATE TABLE IF NOT EXISTS `user_action_log` (
  `ID_code` varchar(10) NOT NULL,
  `ID_animal` varchar(10) DEFAULT NULL,
  `ID_cage` varchar(10) DEFAULT NULL,
  KEY `ID_code` (`ID_code`),
  KEY `ID_animal` (`ID_animal`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `alert_details`
--
ALTER TABLE `alert_details`
  ADD CONSTRAINT `alert_details_ibfk_2` FOREIGN KEY (`ID_Code`) REFERENCES `code_master` (`ID_code`),
  ADD CONSTRAINT `alert_details_ibfk_1` FOREIGN KEY (`ID_cage`) REFERENCES `cage_master` (`ID_cage`);

--
-- Constraints for table `cage_master`
--
ALTER TABLE `cage_master`
  ADD CONSTRAINT `cage_master_ibfk_1` FOREIGN KEY (`ID_type_cage`) REFERENCES `cage_type_master` (`ID_type_cage`);

--
-- Constraints for table `cage_status`
--
ALTER TABLE `cage_status`
  ADD CONSTRAINT `cage_status_ibfk_1` FOREIGN KEY (`ID_cage`) REFERENCES `cage_master` (`ID_cage`);

--
-- Constraints for table `user_action_log`
--
ALTER TABLE `user_action_log`
  ADD CONSTRAINT `user_action_log_ibfk_2` FOREIGN KEY (`ID_animal`) REFERENCES `animal_master` (`ID_Animal`),
  ADD CONSTRAINT `user_action_log_ibfk_1` FOREIGN KEY (`ID_code`) REFERENCES `code_master` (`ID_code`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
