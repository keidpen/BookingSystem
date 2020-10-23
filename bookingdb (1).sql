-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 23, 2020 at 01:42 PM
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
  `ORNO` varchar(50) NOT NULL,
  `customerID` int(50) NOT NULL,
  `SeatNo` varchar(50) NOT NULL,
  `Date` varchar(50) NOT NULL,
  `Time` varchar(50) NOT NULL,
  `Screen` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bookedseats`
--

INSERT INTO `bookedseats` (`ID`, `ORNO`, `customerID`, `SeatNo`, `Date`, `Time`, `Screen`) VALUES
(1, '', 1, ' 20,', '09-22-2020', '10:00 am - 12:00 pm', 'Screen 1'),
(2, '', 2, ' 123,', '09-22-2020', '10:00 am - 12:00 pm', 'Screen 1'),
(9, '', 9, ' 14, 18,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(10, '', 10, ' 16, 17,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(11, '', 11, ' 125,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(12, '', 12, ' 129,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(13, '', 13, ' 96,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(14, '', 14, ' 99,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(15, '', 15, ' 150,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(16, '', 16, ' 9,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(17, '', 17, ' 36,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(18, '', 18, ' 119,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(19, '', 19, ' 203,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(20, '', 20, ' 210,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(21, '', 21, ' 206,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(22, '', 22, ' 106,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(23, '', 23, ' 164,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(24, '', 24, ' 214,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(25, '', 25, ' 49,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(26, '', 26, ' 131,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(27, '', 27, ' 39,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(28, '', 28, ' 1,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(29, '', 29, ' 171,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(30, '', 30, ' 32,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(31, '', 31, ' 62,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(32, '', 32, ' 27,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(33, '', 33, ' 245,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(34, '', 34, ' 82,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(35, '', 35, ' 100,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(36, '', 36, ' 160,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(37, '', 37, ' 70,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(38, '', 38, ' 239,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(39, '', 39, ' 155,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(40, '', 40, ' 75,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(41, '', 41, ' 80,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(42, '', 42, ' 24,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(43, '', 43, ' 66,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(44, '', 44, ' 153,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(45, '', 45, ' 137,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(46, '', 46, ' 132,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(47, '', 47, ' 111,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(48, '', 48, ' 13,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(49, '', 49, ' 222,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(50, '', 50, ' 232,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(51, '', 51, ' 242, 243, 241,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(52, '', 52, ' 219, 218, 217, 64, 67, 66, 65,', '10-03-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(53, '', 53, ' 72, 73, 74,', '10-03-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(54, '', 54, ' 292, 293, 294,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(55, '', 55, ' 142, 170, 198, 171, 200, 172, 144, 146, 174, 202,', '10-03-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(56, '', 56, ' 203, 204, 176, 148, 156, 147,', '10-03-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(57, '', 57, ' 277,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(58, '', 58, ' 300, 301, 302,', '10-02-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(59, '', 59, ' 8, 9, 10,', '10-03-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(60, '', 60, ' 15, 17, 19,', '10-03-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(61, '', 61, ' 45, 46,', '10-03-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(62, '', 62, ' 125, 126, 127, 129, 130, 131, 132, 133, 134, 135,', '10-03-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(68, 'OR-68', 78, ' 47,', '10-12-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(69, 'OR-69', 79, ' 130,', '10-12-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(71, 'OR-70', 81, ' 95,', '10-12-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(72, 'OR-72', 82, ' 17,', '10-12-2020', '10:00 am - 12:30 pm', 'Screen 1'),
(73, 'OR-73', 83, ' 5,', '2020-10-12', '10:00 am - 12:30 pm', 'Screen 1'),
(74, 'OR-74', 84, ' 73, 74, 103, 102, 75, 101, 129, 130, 131, 128,', '2020-10-12', '10:00 am - 12:30 pm', 'Screen 1'),
(75, 'OR-75', 85, ' 14, 15, 16,', '2020-10-12', '2:00 pm - 4:00 pm', 'Screen 1'),
(79, 'OR-76', 89, ' 10, 39, 40,', '2020-10-14', '10:00 am - 12:00 pm', 'Screen 1'),
(80, 'OR-80', 90, ' 14, 15, 16,', '2020-10-22', '', 'Screen 1'),
(81, 'OR-81', 91, ' 38, 39, 67, 68,', '2020-10-22', '', 'Screen 1'),
(82, 'OR-82', 92, ' 73, 101, 129,', '2020-10-22', '', 'Screen 1'),
(83, 'OR-83', 93, ' 122, 123, 124, 125,', '2020-10-22', '', 'Screen 1'),
(84, 'OR-84', 94, ' 151, 179, 207, 208,', '2020-10-22', '', 'Screen 1'),
(85, 'OR-85', 95, ' 49, 50, 51,', '2020-10-22', '', 'Screen 1'),
(86, 'OR-86', 96, ' 61, 89, 117,', '2020-10-22', '', 'Screen 1'),
(87, 'OR-87', 97, ' 211, 212, 213,', '2020-10-22', '', 'Screen 1');

-- --------------------------------------------------------

--
-- Table structure for table `movieinfo`
--

CREATE TABLE `movieinfo` (
  `movieID` int(50) NOT NULL,
  `Title` varchar(50) NOT NULL,
  `Director` varchar(50) NOT NULL,
  `Genre` varchar(50) NOT NULL,
  `Duration` varchar(20) NOT NULL,
  `Synopsis` varchar(99) NOT NULL,
  `Price` int(50) NOT NULL,
  `isDeleted` varchar(6) NOT NULL,
  `imgPath` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `movieinfo`
--

INSERT INTO `movieinfo` (`movieID`, `Title`, `Director`, `Genre`, `Duration`, `Synopsis`, `Price`, `isDeleted`, `imgPath`) VALUES
(1, 'The Rocket', 'Kim Jung Un', 'Adventure, Action, Drama, ', '10:00', 'Kim activated the Nuke', 200, 'true', 'C:\\Users\\Noli\\Pictures\\SPIDEY\\wall\\si-un-18-0523-2.jpg'),
(2, 'Chixx Sa Sabidsa', 'Jose Marichanss', 'Drama, Documentary, ', '2:00:00', 'Hello Marichan21', 240, 'false', 'C:\\Users\\Noli\\Pictures\\SPIDEY\\alejandro-burdisio-congurbano-la-yoli-as.jpg'),
(3, 'The Vanguard', 'Jackie Chan', 'Drama, Documentary, Comedy, ', '2:40:30', 'They jump in the river', 500, 'false', 'C:\\Users\\Noli\\Pictures\\SPIDEY\\yuhki-demers-peni-graphics-0000-layer-comp-1.jpg'),
(5, 'The girl', 'Me', 'Drama, Documentary, ', '123', 'the girl in unif', 200, 'false', 'C:\\Users\\Noli\\Pictures\\SPIDEY\\wall\\si-un-18-0523-2.jpg'),
(6, 'The siht', 'sfa', 'Action, Drama, ', 'asd', 'asd', 123, 'false', 'C:\\Users\\Noli\\Pictures\\SPIDEY\\sean-raiko-tay-lord-savior-shaggy.jpg'),
(7, 'Thew', 'asd', 'Drama, ', '2', 'asd', 213, 'false', 'C:\\Users\\Noli\\Pictures\\SPIDEY\\david-noren-hillbillygys2.jpg'),
(8, 'Test', 'direvtor', 'Action, Drama, ', 'qw', 'asdf', 123, 'false', 'C:\\Users\\Noli\\Pictures\\SPIDEY\\jelly.jpg'),
(11, 'The Hawk', 'mister', 'Action, Drama, ', '12:00:30', 'Santo nino puno ka ng grasya', 123, 'false', 'C:\\Users\\Noli\\Pictures\\SPIDEY\\wall\\guilherme-borba-fashion1.jpg'),
(12, 'the look', 'Mrloor', 'Drama, Documentary, ', '12:00:90', 'Hashahdasd', 3432, 'true', 'C:\\Users\\Noli\\Pictures\\SPIDEY\\wall\\leandro-franci-jponesinha-001.jpg'),
(13, 'THe rixal', 'asd', 'Adventure, Action, Documentary, ', '124321', 'Noli ', 190, 'false', 'C:\\Users\\Noli\\Pictures\\SPIDEY\\wall\\leandro-franci-jponesinha-001.jpg'),
(14, 'asd', 'asd', 'Drama, Documentary, ', 'sd', 'asd', 0, 'false', 'C:\\Users\\Noli\\Pictures\\SPIDEY\\jelly.jpg'),
(19, 'The rocke a', 'asd', 'Action, Drama, ', '12:32:23', 'chixx', 12341, 'false', 'C:\\Users\\Noli\\Pictures\\SPIDEY\\atey-ghailan-orange2b.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `moviesched`
--

CREATE TABLE `moviesched` (
  `schedID` int(50) NOT NULL,
  `StartDate` datetime NOT NULL,
  `EndDate` datetime NOT NULL,
  `Time` varchar(50) NOT NULL,
  `Screen` varchar(10) NOT NULL,
  `movieID` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `moviesched`
--

INSERT INTO `moviesched` (`schedID`, `StartDate`, `EndDate`, `Time`, `Screen`, `movieID`) VALUES
(1, '2020-10-20 18:00:00', '2020-10-24 20:00:00', ' 06:00 PM -  08:00 PM', 'Screen 2', 5),
(2, '2020-10-20 21:00:00', '2020-10-26 23:00:00', ' 09:00 PM -  11:00 PM', 'Screen 1', 0),
(3, '2020-10-20 18:07:00', '2020-10-20 18:07:00', ' 06:07 PM -  06:07 PM', 'Screen 2', 0);

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
(57, 'Quick Silver', '093123', 'nolss@gmail'),
(58, 'Vision', '093123', 'nolss@gmail'),
(59, 'Batman', '093123', 'nolss@gmail'),
(60, 'Robin', '093123', 'nolss@gmail'),
(61, 'Wonder Woman', '093123', 'nolss@gmail'),
(62, 'Harley Quin', '093123', 'nolss@gmail'),
(65, 'asd', 'asd', 'asd'),
(66, 'poli', 'nizarro', '@hahaha'),
(67, 'poli', 'nizarro', '@hahaha'),
(68, 'noli', 'pizarro', '@bobo'),
(69, 'noli', 'pizarro', '@bobo'),
(70, 'noli', 'piz', '@bobo'),
(72, 'asd', 'fa', 'sd'),
(73, 'asdfasd', 'asdfas', 'asdff'),
(74, 'asgsc', 'vwreg', 'ertqas'),
(75, 'asd', 'erwe', 'qdf'),
(76, 'aczxc', 'saeas', 'asdc'),
(77, 'dfve', 'wsd', 'asdf'),
(78, 'asgher', 'sdfxcas', 'fdsgv'),
(79, '12sad', 'ewrdf', 'asd'),
(81, 'noli', '124', '@yahoooo'),
(82, 'noli', 'lio', 'gd'),
(83, 'ASDASDA', 'ADASA', 'QWE'),
(84, 'noli', 'moli', 'boli'),
(85, 'noli', 'nli', 'sad'),
(86, 'dswer', 'werq', 'e'),
(87, 'noli', 'noli', 'noli'),
(88, 'Nene', 'qwe', 'sda'),
(89, 'n', 'n', 'n'),
(90, 'noli', '123', 'Q134'),
(91, 'Boli', '123', '@gmail'),
(92, 'noli', '14312', '@gmail'),
(93, 'noli', '@gmail', '1231'),
(94, '21', 'sdf', '12'),
(95, 'noli', 'noli', 'noli'),
(96, 'noli', 'moli', '123'),
(97, 'noli', '123', '@aaad');

-- --------------------------------------------------------

--
-- Table structure for table `tblsettings`
--

CREATE TABLE `tblsettings` (
  `id` int(11) NOT NULL,
  `sdmode` varchar(6) NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblsettings`
--

INSERT INTO `tblsettings` (`id`, `sdmode`, `StartDate`, `EndDate`) VALUES
(1, 'false', '2020-10-14', '2020-10-20');

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
  ADD PRIMARY KEY (`movieID`),
  ADD UNIQUE KEY `Title` (`Title`);

--
-- Indexes for table `moviesched`
--
ALTER TABLE `moviesched`
  ADD PRIMARY KEY (`schedID`),
  ADD KEY `movieID` (`movieID`);

--
-- Indexes for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  ADD PRIMARY KEY (`customerID`);

--
-- Indexes for table `tblsettings`
--
ALTER TABLE `tblsettings`
  ADD PRIMARY KEY (`id`);

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
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=88;

--
-- AUTO_INCREMENT for table `movieinfo`
--
ALTER TABLE `movieinfo`
  MODIFY `movieID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `moviesched`
--
ALTER TABLE `moviesched`
  MODIFY `schedID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  MODIFY `customerID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=98;

--
-- AUTO_INCREMENT for table `tblsettings`
--
ALTER TABLE `tblsettings`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

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
