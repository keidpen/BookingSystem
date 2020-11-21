-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 21, 2020 at 08:51 AM
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
(1, 'OR-1', 122, ' 67, 99, 102, 75,', '2020-11-09', '', 'Screen 1'),
(2, 'OR-2', 123, ' 41, 18, 22, 50,', '2020-11-09', '', 'Screen 1'),
(3, 'OR-3', 124, ' 25, 53,', '2020-11-09', '', 'Screen 1'),
(4, 'OR-4', 125, ' 14, 16, 44,', '2020-11-09', '', 'Screen 1'),
(5, 'OR-5', 126, ' 156, 157,', '2020-11-09', '', 'Screen 1'),
(6, 'OR-6', 127, ' 98, 126, 128,', '2020-11-09', '', 'Screen 1'),
(7, 'OR-7', 128, ' 21, 49, 105,', '2020-11-09', '', 'Screen 1'),
(8, 'OR-8', 129, ' 39, 40,', '2020-11-09', '', 'Screen 1'),
(9, 'OR-9', 130, ' 20, 48,', '2020-11-09', '', 'Screen 1'),
(10, 'OR-10', 131, ' 94, 122, 123,', '2020-11-09', '', 'Screen 1'),
(11, 'OR-11', 132, ' 134, 135, 136,', '2020-11-09', '', 'Screen 1'),
(12, 'OR-12', 133, ' 214, 189, 217,', '2020-11-09', '', 'Screen 1'),
(13, 'OR-13', 134, ' 118, 90, 119, 91,', '2020-11-09', '', 'Screen 1'),
(14, 'OR-14', 135, ' 104, 132,', '2020-11-09', '', 'Screen 1'),
(15, 'OR-15', 136, ' 46, 47, 19, 45, 17,', '2020-11-09', '', 'Screen 1'),
(16, 'OR-16', 137, ' 71, 72, 100,', '2020-11-09', '', 'Screen 1'),
(17, 'OR-17', 138, ' 24, 52,', '2020-11-09', '', 'Screen 1'),
(18, 'OR-18', 139, ' 82, 139,', '2020-11-09', '', 'Screen 1'),
(19, 'OR-19', 140, ' 117, 145, 173, 202,', '2020-11-09', '', 'Screen 1'),
(20, 'OR-20', 141, ' 149, 179, 180,', '2020-11-09', '', 'Screen 1'),
(21, 'OR-21', 142, ' 211, 212, 213,', '2020-11-09', '', 'Screen 1'),
(22, 'OR-22', 143, ' 289, 264, 267,', '2020-11-09', '', 'Screen 1'),
(23, 'OR-23', 144, ' 130, 131, 103,', '2020-11-09', '', 'Screen 1'),
(24, 'OR-24', 145, ' 165, 193, 221, 194, 222, 166,', '2020-11-09', '', 'Screen 1'),
(25, 'OR-25', 146, ' 80, 108, 109,', '2020-11-09', '', 'Screen 1'),
(26, 'OR-26', 147, ' 124, 97, 69, 125,', '2020-11-09', '', 'Screen 1'),
(27, 'OR-27', 148, ' 2, 30, 31, 3,', '2020-11-09', '', 'Screen 1'),
(28, 'OR-28', 149, ' 271, 273, 275, 248,', '2020-11-09', '', 'Screen 1'),
(29, 'OR-29', 150, ' 87, 115, 114, 86,', '2020-11-09', '', 'Screen 1'),
(30, 'OR-30', 151, ' 78, 107, 106, 79, 51, 23, 26, 55, 54, 27,', '2020-11-09', '', 'Screen 1'),
(31, 'OR-31', 152, ' 127, 155,', '2020-11-09', '', 'Screen 1'),
(32, 'OR-32', 153, ' 37, 7, 36, 8, 10, 38,', '2020-11-09', '', 'Screen 1');

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
(1, 'Wonder Woman : Courage', 'Kim Jung Un', 'Action, Romance, Thriller, ', '10:00:00', 'Damn', 400, 'false', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\WonderWoman.jpg'),
(2, 'Harry Potter', 'Jose Marichanss', 'Adventure, Drama, Fantasy, Romance, ', '2:00:00', 'Hello Marichan21', 240, 'false', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\Harry Potter and the Sorcerers Stone.png'),
(3, 'Vanguard', 'Jackie Chan', 'Adventure, Action, Comedy, ', '2:40:30', 'They jump in the river', 500, 'false', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\Vangurad.jpg'),
(5, 'Aquaman', 'Me', 'Adventure, Action, Sci-Fi, ', '01:30:00', 'FishMan', 200, 'false', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\Aquaman.jpg'),
(6, 'Scooby Doo Instinct', 'sfa', 'Action, Drama, ', 'asd', 'asd', 123, 'false', 'C:\\Users\\Noli\\Pictures\\SPIDEY\\sean-raiko-tay-lord-savior-shaggy.jpg'),
(7, 'US', 'asd', 'Horror, Thriller, ', '2:00:00', 'Twins', 213, 'false', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\US.jpg'),
(8, 'Aladdin', 'Disney', 'Adventure, Drama, Romance, ', '02:12:11', 'Alladin ', 500, 'false', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\Alladin.jpg'),
(11, 'The Beauty and The Beast', 'mister', 'Drama, Romance, Thriller, ', '12:00:30', 'Maganda si emma watson', 500, 'true', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\The Beauty and The Beast.jpg'),
(12, 'The Greatest Showman', 'Mrloor', 'Drama, Romance, ', '12:00:90', 'Hashahdasd', 3432, 'false', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\greatestShowman.jpg'),
(13, 'Joker', 'asd', 'Action, Drama, Horror, Romance, Thriller, ', '12:43:21', 'Clown', 590, 'false', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\Joker.jpg'),
(14, 'Parasyte', 'asd', 'Horror, Sci-Fi, Thriller, ', '12:00:12', 'Worms', 200, 'false', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\Parasyte.jpg'),
(19, 'Spider Man: Into Spider-Verse', 'asd', 'Adventure, Action, Drama, Fantasy, Sci-Fi, ', '12:32:23', 'Uncle Ben?', 900, 'false', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\spiderman_into_the_spiderverse.jpg'),
(20, 'John Wick 2', 'Mema', 'Action, ', '12:12:12', 'kill my ddog i kill you', 12000, 'false', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\John Wick 2.jpg'),
(21, 'End Game', 'John', 'Action, ', '12:12:12', 'Iron man is dead', 300, 'false', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\Avengers Endgame.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `moviesched`
--

CREATE TABLE `moviesched` (
  `schedID` int(50) NOT NULL,
  `SchedPosition` varchar(99) NOT NULL,
  `Date` varchar(100) NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `Time` varchar(50) NOT NULL,
  `Screen` varchar(10) NOT NULL,
  `movieID` int(50) NOT NULL,
  `isDeleted` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `moviesched`
--

INSERT INTO `moviesched` (`schedID`, `SchedPosition`, `Date`, `StartDate`, `EndDate`, `Time`, `Screen`, `movieID`, `isDeleted`) VALUES
(1, ' 2,', 'Nov 15,2020 --to-- Nov 21,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 11, 'true'),
(2, ' 4,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 11, 'true'),
(3, ' 6,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 11, 'true'),
(4, ' 2,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 3, 'true'),
(5, ' 2,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 2, 'true'),
(6, ' 3,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 2, 'true'),
(7, ' 4,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 19, 'true'),
(8, ' 5,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 2, 'true'),
(9, ' 6,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 2, 'true'),
(10, ' 7,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 2, 'true'),
(11, ' 3,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 2, 'true'),
(12, ' 4,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 7, 'false'),
(13, ' 2,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 3, 'false'),
(14, ' 3,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 3, 'true'),
(15, ' 5,', 'Nov 15,2020 --to-- Nov 21,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 21, 'false'),
(16, ' 12,', 'Nov 15,2020 --to-- Nov 21,2020', '0000-00-00', '0000-00-00', '10:00 AM to 1:00 PM', 'Screen 1', 6, 'false'),
(17, ' 20,', 'Nov 15,2020 --to-- Nov 21,2020', '0000-00-00', '0000-00-00', '1:00 PM to 4:00 PM', 'Screen 1', 2, 'true'),
(18, ' 21,', 'Nov 15,2020 --to-- Nov 21,2020', '0000-00-00', '0000-00-00', '1:00 PM to 4:00 PM', 'Screen 1', 2, 'true'),
(19, ' 27,', 'Nov 15,2020 --to-- Nov 21,2020', '0000-00-00', '0000-00-00', '4:00 PM to 7:00 PM', 'Screen 1', 5, 'false'),
(20, ' 28,', 'Nov 15,2020 --to-- Nov 21,2020', '0000-00-00', '0000-00-00', '4:00 PM to 7:00 PM', 'Screen 1', 5, 'false');

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
(97, 'noli', '123', '@aaad'),
(98, 'l.', 'l8', 'uki'),
(99, 'sd', 'asd', 'asd'),
(100, 'erw', 'qer', 'qwr'),
(101, 'noli', '12332', '12313'),
(102, '234', '1234', '14'),
(103, 'noli', '123132', '@gmail.com'),
(104, '1324', 'feafs', 'asd'),
(105, 'th', 'dsfs', 'sdfs'),
(106, 'sgds', 'asdfas', 'afa'),
(107, 'qrd', 'sdfs', 'asdas'),
(108, 'fdaf', 'asfd', 'asd'),
(109, 'asd', 'asd', 'asd'),
(110, '1243', '123', '123'),
(111, 'asd', 'asd', 'asd'),
(112, 'asd', 'asd', 'asd'),
(113, 'hgfj', 'ghj', 'gfhj'),
(114, 'Noli', '09312341', 'haha@gmail.Com'),
(115, 'asd', 'asd', 'asd'),
(116, 'sdf', 'sdf', 'asd'),
(117, 'asd', 'asd', 'asd'),
(118, 'asd', 'asd', 'asd'),
(119, 'asd', 'asd', 'asd'),
(120, 'qwe', 'qwe', 'qwe'),
(121, '123', '12312', '23'),
(122, '123', '123', '123'),
(123, '142', '123', '123'),
(124, '123', '123', '123'),
(125, 'asd', 'asd', 'asd'),
(126, '213', '123', '123'),
(127, 'ac', 'asd', 'asd'),
(128, 'asd', 'asdasdasd', 'asd'),
(129, '312', '123', '123'),
(130, '213', '123', '123'),
(131, 'wqeq', 'ewqqwe', 'qwe'),
(132, 'gf', 'sdf', 'asd'),
(133, 'asfd', 'asd', 'asd'),
(134, 'asd', 'asd', 'asd'),
(135, 'asd', 'asd', 'asd'),
(136, '123', '123', '123'),
(137, 'dsf', 'asf', 'asd'),
(138, 'daf', 'asf', 'afs'),
(139, 'asd', 'asd', 'd'),
(140, 'asd', 'asd', 'asd'),
(141, 'd', 'asd', 'asd'),
(142, 'asd', 'asd', 'asd'),
(143, 'sad', 'sd', 'asd'),
(144, 'qwe', 'qwe', 'qwe'),
(145, 'asdas', 'asd', 'sd'),
(146, 'asd', 'asd', 'asd'),
(147, 'asdasd', 'asd', 'asd'),
(148, 'asd', 'asd', 'asd'),
(149, 'asdasd', 'asd', 'sd'),
(150, 'asd', 'asdas', 'asd'),
(151, 'asd', 'asd', 'asd'),
(152, 'ad', 'asda', 'sad'),
(153, 'asd', 'asd', 'asd');

-- --------------------------------------------------------

--
-- Table structure for table `tblsocialdistancing`
--

CREATE TABLE `tblsocialdistancing` (
  `id` int(11) NOT NULL,
  `sdmode` varchar(6) NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblsocialdistancing`
--

INSERT INTO `tblsocialdistancing` (`id`, `sdmode`, `Date`) VALUES
(1, 'true', '2020-12-09'),
(2, 'true', '2020-11-25'),
(3, 'true', '2020-12-23'),
(4, 'true', '2021-01-13'),
(5, 'true', '2021-01-27'),
(6, 'true', '2021-02-25'),
(7, 'true', '2020-12-24'),
(8, 'true', '2021-01-21'),
(9, 'true', '2021-02-18'),
(10, 'true', '2020-12-17'),
(11, 'true', '2021-01-14'),
(12, 'true', '2020-11-28'),
(13, 'true', '2021-03-24'),
(14, 'true', '2021-06-08'),
(15, 'true', '2022-01-13'),
(16, 'true', '2020-12-27'),
(17, 'true', '2020-11-27');

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
('Admin', 'Admin', 'Admin'),
('Employee', 'Employee', 'Employee');

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
-- Indexes for table `tblsocialdistancing`
--
ALTER TABLE `tblsocialdistancing`
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
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `movieinfo`
--
ALTER TABLE `movieinfo`
  MODIFY `movieID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `moviesched`
--
ALTER TABLE `moviesched`
  MODIFY `schedID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  MODIFY `customerID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=154;

--
-- AUTO_INCREMENT for table `tblsocialdistancing`
--
ALTER TABLE `tblsocialdistancing`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

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
