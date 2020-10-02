-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 02, 2020 at 12:28 PM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bookingdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `bookedseats`
--

CREATE TABLE `bookedseats` (
  `ID` int(50) NOT NULL,
  `customerID` int(50) NOT NULL,
  `SeatNo` varchar(50) NOT NULL,
  `Date` varchar(50) NOT NULL,
  `Time` varchar(50) NOT NULL,
  `Screen` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bookedseats`
--

INSERT INTO `bookedseats` (`ID`, `customerID`, `SeatNo`, `Date`, `Time`, `Screen`) VALUES
(1, 1, ' 20,', '09-22-2020', '10:00 am - 12:00 pm', 'Screen 1'),
(2, 2, ' 123,', '09-22-2020', '10:00 am - 12:00 pm', 'Screen 1'),
(9, 9, ' 14, 18,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(10, 10, ' 16, 17,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(11, 11, ' 125,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(12, 12, ' 129,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(13, 13, ' 96,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(14, 14, ' 99,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(15, 15, ' 150,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(16, 16, ' 9,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(17, 17, ' 36,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(18, 18, ' 119,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(19, 19, ' 203,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(20, 20, ' 210,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(21, 21, ' 206,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(22, 22, ' 106,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(23, 23, ' 164,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(24, 24, ' 214,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(25, 25, ' 49,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(26, 26, ' 131,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(27, 27, ' 39,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(28, 28, ' 1,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(29, 29, ' 171,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(30, 30, ' 32,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(31, 31, ' 62,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(32, 32, ' 27,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(33, 33, ' 245,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(34, 34, ' 82,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(35, 35, ' 100,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(36, 36, ' 160,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(37, 37, ' 70,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(38, 38, ' 239,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(39, 39, ' 155,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(40, 40, ' 75,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(41, 41, ' 80,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(42, 42, ' 24,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(43, 43, ' 66,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(44, 44, ' 153,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(45, 45, ' 137,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(46, 46, ' 132,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(47, 47, ' 111,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(48, 48, ' 13,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(49, 49, ' 222,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(50, 50, ' 232,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(51, 51, ' 242, 243, 241,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(52, 52, ' 219, 218, 217, 64, 67, 66, 65,', '10-03-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(53, 53, ' 72, 73, 74,', '10-03-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(54, 54, ' 292, 293, 294,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(55, 55, ' 142, 170, 198, 171, 200, 172, 144, 146, 174, 202,', '10-03-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(56, 56, ' 203, 204, 176, 148, 156, 147,', '10-03-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(57, 57, ' 277,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1');

-- --------------------------------------------------------

--
-- Table structure for table `movieinfo`
--

CREATE TABLE `movieinfo` (
  `movieID` int(50) NOT NULL,
  `Title` varchar(50) NOT NULL,
  `Genre` varchar(50) NOT NULL,
  `Duration` varchar(20) NOT NULL,
  `Price` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `moviesched`
--

CREATE TABLE `moviesched` (
  `schedID` int(50) NOT NULL,
  `Date` varchar(50) NOT NULL,
  `Time` varchar(50) NOT NULL,
  `movieID` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tblcustomer`
--

CREATE TABLE `tblcustomer` (
  `customerID` int(50) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `ContactNo` varchar(15) NOT NULL,
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblcustomer`
--

INSERT INTO `tblcustomer` (`customerID`, `Name`, `ContactNo`, `Email`) VALUES
(1, 'Noli', '092166666', 'thisiemenoliiii'),
(2, 'Steve Austin', '09372941', 'steeeeeeveaustin'),
(9, 'nokia', '093123', 'nolss@gmail'),
(10, 'The Rock', '093123', 'nolss@gmail'),
(11, 'Undertaker', '093123', 'nolss@gmail'),
(12, 'Superman', '093123', 'nolss@gmail'),
(13, 'Jawny Scene', '093123', 'nolss@gmail'),
(14, 'Manny Pacman', '093123', 'nolss@gmail'),
(15, 'Mia Halika', '093123', 'nolss@gmail'),
(16, 'Lery Role', '093123', 'nolss@gmail'),
(17, 'Liana Road', '093123', 'nolss@gmail'),
(18, 'Jessica Soho', '093123', 'nolss@gmail'),
(19, 'Ed Caluag', '093123', 'nolss@gmail'),
(20, 'Pinnochio', '093123', 'nolss@gmail'),
(21, 'Eddie Siya', '093123', 'nolss@gmail'),
(22, 'eddie ako', '093123', 'nolss@gmail'),
(23, 'Erap ParasaMahirap', '093123', 'nolss@gmail'),
(24, 'John Paul', '093123', 'nolss@gmail'),
(25, 'Eddie Manalo', '093123', 'nolss@gmail'),
(26, 'Minions', '093123', 'nolss@gmail'),
(27, 'Banana', '093123', 'nolss@gmail'),
(28, 'dragon fruit', '093123', 'nolss@gmail'),
(29, 'Jose Rizal', '093123', 'nolss@gmail'),
(30, 'Apolinario', '093123', 'nolss@gmail'),
(31, 'Monkey D. Luffy', '093123', 'nolss@gmail'),
(32, 'Garp', '093123', 'nolss@gmail'),
(33, 'Michael Jackson', '093123', 'nolss@gmail'),
(34, 'Aguinaldo', '093123', 'nolss@gmail'),
(35, 'Dagohoy', '093123', 'nolss@gmail'),
(36, 'Lapu lapu', '093123', 'nolss@gmail'),
(37, 'Magellan', '093123', 'nolss@gmail'),
(38, 'Magellan', '093123', 'nolss@gmail'),
(39, 'April Boy', '093123', 'nolss@gmail'),
(40, 'Ogie alcasid', '093123', 'nolss@gmail'),
(41, 'Taylor Swift', '093123', 'nolss@gmail'),
(42, 'Hanna', '093123', 'nolss@gmail'),
(43, 'Post Malone', '093123', 'nolss@gmail'),
(44, 'Coldplay', '093123', 'nolss@gmail'),
(45, 'Chris Brown', '093123', 'nolss@gmail'),
(46, 'Bruno Mars', '093123', 'nolss@gmail'),
(47, 'Imagine Dragons', '093123', 'nolss@gmail'),
(48, 'American Authors', '093123', 'nolss@gmail'),
(49, 'Fallout Boys', '093123', 'nolss@gmail'),
(50, 'Panic! at the Disco', '093123', 'nolss@gmail'),
(51, 'Pentatonix', '093123', 'nolss@gmail'),
(52, 'Iron Man', '093123', 'nolss@gmail'),
(53, 'Captain America', '093123', 'nolss@gmail'),
(54, 'Black Widow', '093123', 'nolss@gmail'),
(55, 'Hulk', '093123', 'nolss@gmail'),
(56, 'Hawk Eye', '093123', 'nolss@gmail'),
(57, 'Quick Silver', '093123', 'nolss@gmail');

-- --------------------------------------------------------

--
-- Table structure for table `userfield`
--

CREATE TABLE `userfield` (
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Usertype` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `userfield`
--

INSERT INTO `userfield` (`Username`, `Password`, `Usertype`) VALUES
('janina', 'janina', 'Employee'),
('noli', 'noli', 'Admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bookedseats`
--
ALTER TABLE `bookedseats`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `customerID` (`customerID`);

--
-- Indexes for table `movieinfo`
--
ALTER TABLE `movieinfo`
  ADD PRIMARY KEY (`movieID`);

--
-- Indexes for table `moviesched`
--
ALTER TABLE `moviesched`
  ADD KEY `movieID` (`movieID`);

--
-- Indexes for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  ADD PRIMARY KEY (`customerID`);

--
-- Indexes for table `userfield`
--
ALTER TABLE `userfield`
  ADD PRIMARY KEY (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bookedseats`
--
ALTER TABLE `bookedseats`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- AUTO_INCREMENT for table `movieinfo`
--
ALTER TABLE `movieinfo`
  MODIFY `movieID` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  MODIFY `customerID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bookedseats`
--
ALTER TABLE `bookedseats`
  ADD CONSTRAINT `test` FOREIGN KEY (`customerID`) REFERENCES `tblcustomer` (`customerID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
