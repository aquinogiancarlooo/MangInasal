-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 08, 2024 at 02:10 PM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbkiosk`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbadmin`
--

CREATE TABLE IF NOT EXISTS `tbadmin` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `userrole` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbadmin`
--

INSERT INTO `tbadmin` (`username`, `password`, `userrole`) VALUES
('cashier', 'cash', 'cashier'),
('manager', 'manager', 'manager'),
('admin', 'admin123', 'admin'),
('all', 'all', 'all');

-- --------------------------------------------------------

--
-- Table structure for table `tbinventory`
--

CREATE TABLE IF NOT EXISTS `tbinventory` (
  `prodid` int(100) NOT NULL AUTO_INCREMENT,
  `prodname` varchar(100) NOT NULL,
  `category` varchar(100) NOT NULL,
  `price` int(100) NOT NULL,
  `stock` int(100) NOT NULL,
  `productdesc` varchar(10000) NOT NULL,
  `path` varchar(1000) NOT NULL,
  PRIMARY KEY (`prodid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=29 ;

--
-- Dumping data for table `tbinventory`
--

INSERT INTO `tbinventory` (`prodid`, `prodname`, `category`, `price`, `stock`, `productdesc`, `path`) VALUES
(1, 'Chicken Inasal Regular Family Size', 'Group Meals', 538, 123, '6 pcs Ihaw-Sarap marinated chicken, expertly grilled to perfection\r\n', 'C:\\images\\cimeal5.png'),
(2, 'Paa Large Family Size', 'Group Meals', 524, 456, '4 pieces Ihaw-Sarap marinated chicken quarters (Paa) expertly grilled to perfection.', 'C:\\images\\gmeal2.png'),
(3, 'Pecho Large Family Size', 'Group Meals', 615, 143, '4 pieces Ihaw-Sarap marinated chicken quarters (Pecho) expertly grilled to perfection.', 'C:\\images\\gmeal3.png'),
(4, 'Pecho Large Buddy Size', 'Group Meals', 316, 143, '2 pieces Ihaw-Sarap marinated chicken quarters (Pecho) expertly grilled to perfection.', 'C:\\images\\gmeal5.png'),
(5, 'Chicken Inasal & Pork BBQ Family Fiesta', 'Group Meals', 745, 143, '3 pcs Chicken Inasal Paa Large, 6 pcs Pork BBQ with Peanut Sauce, Java Rice Platter', 'C:\\images\\gmeal6.png'),
(6, 'Chicken Inasal & Grilled Liempo Family Fiesta', 'Group Meals', 709, 143, '4 pcs Chicken Inasal Paa Large, 2 Grilled Liempo, Java Rice Platter', ''),
(7, 'Chicken Inasal & 1 pc Pork BBQ Solo Fiesta', 'Chicken Inasal', 245, 143, '1 pc Chicken Inasal Paa Large, 1 pc Pork BBQ, 1 pc Lumpiang Togue, Half Palabok, Java Rice, Soup', 'C:\\images\\cimeal1.png'),
(8, 'Chicken Inasal Solo Fiesta', 'Chicken Inasal', 188, 143, '1 pc Chicken Inasal Paa Large, 1pc Lumpiang Togue, Half Palabok, Java Rice, Soup', 'C:\\images\\cimeal2.png'),
(9, 'Paa Large PM1', 'Chicken Inasal', 142, 143, '1 pc Ihaw-Sarap marinated chicken quarters. Expertly grilled the Mang Inasal way served with a cup of rice.', ''),
(10, 'Pecho Large PM2', 'Chicken Inasal', 169, 143, '1 pc Ihaw-Sarap marinated chicken quarters. Expertly grilled the Mang Inasal way served with a cup of rice.\r\n\r\n', 'C:\\images\\cimeal4.png'),
(11, 'Todo Solb Paa Large', 'Chicken Inasal', 245, 143, 'Hearty combination of delicious Mang Inasal favorites – Expertly grilled Chicken Inasal Large with rice, flavorful & sauce half Palabok and soup', 'C:\\images\\cimeal5.png'),
(12, 'Todo Solb Pecho Large', 'Chicken Inasal', 249, 133, 'Hearty combination of delicious Mang Inasal favorites – expertly grilled Chicken Inasal Large with rice, flavorful & sauce half Palabok and soup', 'C:\\images\\cimeal6.png'),
(13, 'Chicken Inasal Regular', 'Chicken Inasal', 111, 745, 'Ihaw-Sarap 1-piece Chicken Inasal. Expertly grilled the Mang Inasal way served with a cup of rice.', 'C:\\images\\cimeal7.png'),
(14, 'Fiesta Meal', 'Chicken Inasal', 216, 424, 'Ihaw-Sarap marinated chicken quarters. Expertly grilled the Mang Inasal way and served with three (3) Rice, three (3) Chicken Oil Sachets, two (2) Toyomansi Sachets, and Soup', 'C:\\images\\cimeal8.png'),
(15, '2 pc pork BBQ Solo Fiesta', 'Grilled Pork', 172, 143, '2 pcs Pork BBQ, 1 pc lumpiang Togue, Half Palabok, Java Rice, Soup', 'C:\\images\\cat4.png'),
(16, '1 pc Pork BBQ with Peanut Sauce and Java Rice', 'Grilled Pork', 144, 544, 'One stick of juicy-lambot Pork BBQ served with sweet and savory Peanut Sauce and a cup of Java Rice.', 'C:\\images\\gpmeal2.png'),
(17, '2 pcs Pork BBQ with Peanut Sauce and Java Rice', 'Grilled Pork', 172, 456, 'Two stick of juicy-lambot Pork BBQ served with sweet and savory Peanut Sauce and a cup of Java Rice.', 'C:\\images\\gpmeal3.png'),
(18, '2 pcs pork BBQ with spiced vinegar', 'Grilled Pork', 645, 461, 'Two sticks of juicy-lambot Pork BBQ served with spiced vinegar and plain rice.', 'C:\\images\\gpmeal4.png'),
(19, 'Pork BBQ Family Size', 'Grilled Pork', 542, 45, '10 sticks of juicy-lambot Pork BBQ served with sweet and savory peanut sauce', 'C:\\images\\gpmeal5.png'),
(20, 'Pork BBQ Buddy Size', 'Grilled Pork', 385, 65, '4 sticks of juicy-lambot Pork BBQ served with sweet and savory Peanut Sauce', 'C:\\images\\gpmeal6.png'),
(21, '1 pc pork BBQ Alacarte', 'Grilled Pork', 85, 55, 'One stick of tender-grilled Pork BBQ served with sweet and savory Peanut Sauce and a cup of Java Rice', 'C:\\images\\gpmeal7.png'),
(22, 'Grilled Liempo', 'Grilled Pork', 306, 21, 'Grilled marinated pork belly, salty and sour with right blend of spices served with unlimited or one serving of rice.', 'C:\\images\\gpmeal8.png');

-- --------------------------------------------------------

--
-- Table structure for table `tbqueing`
--

CREATE TABLE IF NOT EXISTS `tbqueing` (
  `orderno` int(20) NOT NULL AUTO_INCREMENT,
  `orders` varchar(1000) NOT NULL,
  `totalamount` int(100) NOT NULL,
  `status` varchar(100) NOT NULL,
  PRIMARY KEY (`orderno`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `tbqueing`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbrecords`
--

CREATE TABLE IF NOT EXISTS `tbrecords` (
  `ordernum` int(100) NOT NULL AUTO_INCREMENT,
  `orders` varchar(1000) NOT NULL,
  `status` varchar(100) NOT NULL,
  `totalamount` int(100) NOT NULL,
  `payment` int(100) NOT NULL,
  `change` int(100) NOT NULL,
  PRIMARY KEY (`ordernum`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `tbrecords`
--

INSERT INTO `tbrecords` (`ordernum`, `orders`, `status`, `totalamount`, `payment`, `change`) VALUES
(1, 'DADASDA', 'DINE IN', 1233, 13333, 546545);
