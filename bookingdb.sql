-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 26, 2020 at 10:59 AM
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
  `SeatNo` varchar(50) NOT NULL,
  `Date` varchar(50) NOT NULL,
  `Time` varchar(50) NOT NULL,
  `Screen` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bookedseats`
--

INSERT INTO `bookedseats` (`ID`, `SeatNo`, `Date`, `Time`, `Screen`) VALUES
(1, '20', '09-22-2020', '10:00 am - 12:00 pm', 'Screen 1'),
(2, '21', '09-22-2020', '10:00 am - 12:00 pm', 'Screen 1'),
(3, '1', '09-22-2020', '10:00 am - 12:00 pm', 'Screen 2'),
(4, '123', '09-22-2020', '10:00 am - 12:00 pm', 'Screen 2'),
(5, '29', '09-23-2020', '10:00 am - 12:00 pm', 'Screen 1'),
(6, '10', '09-24-2020', '10:00 am - 12:00 pm', 'Screen 2');

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

--
-- Dumping data for table `movieinfo`
--

INSERT INTO `movieinfo` (`movieID`, `Title`, `Genre`, `Duration`, `Price`) VALUES
(1, 'The Vanguard', 'Action', '2:40', 500),
(2, 'Justice League', 'Action', '2:55', 550);

-- --------------------------------------------------------

--
-- Table structure for table `moviesched`
--

CREATE TABLE `moviesched` (
  `Date` varchar(50) NOT NULL,
  `Time` varchar(50) NOT NULL,
  `movieID` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `moviesched`
--

INSERT INTO `moviesched` (`Date`, `Time`, `movieID`) VALUES
('09-22-2020', '10:00 am - 01:00 pm', 1);

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
  ADD PRIMARY KEY (`ID`);

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
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `movieinfo`
--
ALTER TABLE `movieinfo`
  MODIFY `movieID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
