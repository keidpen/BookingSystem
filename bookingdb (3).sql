-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 26, 2020 at 04:26 PM
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
(21, 'End Game', 'John', 'Action, ', '12:12:12', 'Iron man is dead', 300, 'false', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\Avengers Endgame.jpg'),
(23, 'para', 'Batman', 'Action, ', '12:12:10', 'Helllo Everyone', 124, 'true', 'C:\\Users\\Noli\\Pictures\\MoviePoster\\Parasyte.jpg');

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
(13, ' 2,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 3, 'true'),
(14, ' 3,', 'Nov 08,2020 --to-- Nov 14,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 3, 'true'),
(15, ' 5,', 'Nov 15,2020 --to-- Nov 21,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 21, 'false'),
(16, ' 12,', 'Nov 15,2020 --to-- Nov 21,2020', '0000-00-00', '0000-00-00', '10:00 AM to 1:00 PM', 'Screen 1', 6, 'false'),
(17, ' 20,', 'Nov 15,2020 --to-- Nov 21,2020', '0000-00-00', '0000-00-00', '1:00 PM to 4:00 PM', 'Screen 1', 2, 'true'),
(18, ' 21,', 'Nov 15,2020 --to-- Nov 21,2020', '0000-00-00', '0000-00-00', '1:00 PM to 4:00 PM', 'Screen 1', 2, 'true'),
(19, ' 27,', 'Nov 15,2020 --to-- Nov 21,2020', '0000-00-00', '0000-00-00', '4:00 PM to 7:00 PM', 'Screen 1', 5, 'false'),
(20, ' 28,', 'Nov 15,2020 --to-- Nov 21,2020', '0000-00-00', '0000-00-00', '4:00 PM to 7:00 PM', 'Screen 1', 5, 'false'),
(21, ' 8,', 'Nov 22,2020 --to-- Nov 28,2020', '0000-00-00', '0000-00-00', '10:00 AM to 1:00 PM', 'Screen 1', 2, 'false'),
(22, ' 10,', 'Nov 22,2020 --to-- Nov 28,2020', '0000-00-00', '0000-00-00', '10:00 AM to 1:00 PM', 'Screen 1', 1, 'false'),
(23, ' 9,', 'Nov 22,2020 --to-- Nov 28,2020', '0000-00-00', '0000-00-00', '10:00 AM to 1:00 PM', 'Screen 1', 5, 'false'),
(24, ' 2,', 'Nov 22,2020 --to-- Nov 28,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', '', 3, 'true'),
(25, ' 2,', 'Nov 22,2020 --to-- Nov 28,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 2, 'false'),
(26, ' 3,', 'Nov 22,2020 --to-- Nov 28,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 6, 'true'),
(27, ' 1,', 'Nov 29,2020 --to-- Dec 05,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 3, 'true'),
(28, ' 2,', 'Nov 29,2020 --to-- Dec 05,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 3, 'true'),
(29, ' 3,', 'Nov 29,2020 --to-- Dec 05,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 3, 'true'),
(30, ' 6,', 'Nov 29,2020 --to-- Dec 05,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 3, 'true'),
(31, ' 7,', 'Nov 29,2020 --to-- Dec 05,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 3, 'true'),
(32, ' 6,', 'Nov 22,2020 --to-- Nov 28,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 3, 'false'),
(33, ' 5,', 'Nov 22,2020 --to-- Nov 28,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 3, 'false'),
(34, ' 12,', 'Nov 22,2020 --to-- Nov 28,2020', '0000-00-00', '0000-00-00', '10:00 AM to 1:00 PM', 'Screen 1', 2, 'false'),
(35, ' 4,', 'Nov 22,2020 --to-- Nov 28,2020', '0000-00-00', '0000-00-00', '7:00 AM to 10:00 AM', 'Screen 1', 5, 'false'),
(36, ' 14,', 'Nov 22,2020 --to-- Nov 28,2020', '0000-00-00', '0000-00-00', '10:00 AM to 1:00 PM', 'Screen 1', 12, 'false'),
(37, ' 24,', 'Nov 22,2020 --to-- Nov 28,2020', '0000-00-00', '0000-00-00', '4:00 PM to 7:00 PM', 'Screen 1', 5, 'false'),
(38, ' 25,', 'Nov 22,2020 --to-- Nov 28,2020', '0000-00-00', '0000-00-00', '4:00 PM to 7:00 PM', 'Screen 1', 5, 'false'),
(39, ' 26,', 'Nov 22,2020 --to-- Nov 28,2020', '0000-00-00', '0000-00-00', '4:00 PM to 7:00 PM', 'Screen 1', 5, 'false');

-- --------------------------------------------------------

--
-- Table structure for table `tblbookedseats`
--

CREATE TABLE `tblbookedseats` (
  `SeatNoID` int(50) NOT NULL,
  `ORNO` varchar(50) NOT NULL,
  `customerID` int(50) NOT NULL,
  `Date` varchar(50) NOT NULL,
  `Time` varchar(50) NOT NULL,
  `Screen` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblbookedseats`
--

INSERT INTO `tblbookedseats` (`SeatNoID`, `ORNO`, `customerID`, `Date`, `Time`, `Screen`) VALUES
(1, 'OR-1', 1, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(2, 'OR-2', 182, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(3, 'OR-3', 183, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(4, 'OR-4', 184, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(5, 'OR-5', 185, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(6, 'OR-6', 186, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(7, 'OR-7', 187, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(8, 'OR-8', 188, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(9, 'OR-9', 189, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(10, 'OR-10', 190, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(11, 'OR-11', 191, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(12, 'OR-12', 192, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(13, 'OR-13', 193, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(14, 'OR-14', 194, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(15, 'OR-15', 195, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1'),
(16, 'OR-16', 196, '2020-11-25', '4:00 PM to 7:00 PM', 'Screen 1');

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
(153, 'asd', 'asd', 'asd'),
(154, 'Noli', '0921453', 'Noli@gmail.Com'),
(155, 'noli', '0921412', 'noli@gmail.Com'),
(156, 'ka', '2135', 'haha@gmail.com'),
(157, 'Noliasd', '025561', 'mans@gmail.com'),
(158, 'asdf', 'asd', 'asd'),
(159, 'noli', '2345', '12'),
(160, 'ef', 'qw', '12'),
(161, '9io', '789', '789'),
(162, 'n', '123', '123'),
(163, 'dqw', '123', '123'),
(164, 'noli', '1231', '@gmail'),
(165, 'noli112', '312', '123'),
(166, 'noli', '1234', '112'),
(167, 'noli', '123', 'vw'),
(168, 'f', 'q', '4'),
(169, 'noli', '02941', 'noli312'),
(170, 'nli', '09812', 'Dmao@gmail.com'),
(171, 'bw', 'qw', '123'),
(172, 'bs', '253', 'sdf'),
(173, '789li', 'iulu', 'luti'),
(174, 'Noli', '0923113', 'noli@gmail.com'),
(175, 'no', '4881', 'haha@gmail.com'),
(176, 'ad', '12', '123'),
(177, 'ff', 'a23', '123'),
(178, 'n', '123', '123'),
(179, 'noli', '09214', '@ham'),
(180, '8', '578', '78'),
(181, 'hh', '8', '467'),
(182, '86', 'ghj', '5'),
(183, 'noli', '223', '@hand'),
(184, 'noli', '12', '31'),
(185, 'noli', '123', 'noi'),
(186, 'nooli', '31', '234'),
(187, 'dca', '31', '31'),
(188, 'noli', '123', '12'),
(189, 're', '12', '4'),
(190, 'moli', '1231', '123'),
(191, 'noli', '1351', '24'),
(192, 'noli23', '23', '41'),
(193, 'noliasd', '123', '123'),
(194, 'noli', '123', '13'),
(195, 'noli', '123', '41'),
(196, 'vds', 'as', 'er');

-- --------------------------------------------------------

--
-- Table structure for table `tblseatcategory`
--

CREATE TABLE `tblseatcategory` (
  `ID` int(11) NOT NULL,
  `SeatCat` varchar(1) NOT NULL,
  `Price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblseatcategory`
--

INSERT INTO `tblseatcategory` (`ID`, `SeatCat`, `Price`) VALUES
(1, 'A', '500.21'),
(2, 'B', '550.00'),
(3, 'C', '400.00'),
(4, 'D', '200.00'),
(5, 'E', '500.00'),
(6, 'F', '550.00'),
(7, 'G', '200.00');

-- --------------------------------------------------------

--
-- Table structure for table `tblseatno`
--

CREATE TABLE `tblseatno` (
  `SeatNoID` varchar(5) NOT NULL,
  `SeatNo` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblseatno`
--

INSERT INTO `tblseatno` (`SeatNoID`, `SeatNo`, `Date`, `Status`) VALUES
('1', 1, '2020-11-25', 'occupied'),
('1', 12, '2020-11-25', 'occupied'),
('1', 2, '0000-00-00', '3'),
('3', 2, '0000-00-00', '3'),
('3', 2, '0000-00-00', '3'),
('3', 2, '0000-00-00', '3'),
('4', 18, '2020-11-25', 'occupied'),
('5', 41, '2020-11-25', 'occupied'),
('5', 43, '2020-11-25', 'occupied'),
('5', 45, '2020-11-25', 'occupied'),
('6', 97, '2020-11-25', 'occupied'),
('7', 91, '2020-11-25', 'occupied'),
('7', 119, '2020-11-25', 'occupied'),
('7', 121, '2020-11-25', 'occupied'),
('7', 93, '2020-11-25', 'occupied'),
('8', 123, '2020-11-25', 'occupied'),
('8', 130, '2020-11-25', 'occupied'),
('8', 103, '2020-11-25', 'occupied'),
('9', 214, '2020-11-25', 'occupied'),
('9', 189, '2020-11-25', 'occupied'),
('10', 101, '2020-11-25', 'occupied'),
('10', 24, '2020-11-25', 'occupied'),
('11', 99, '2020-11-25', 'occupied'),
('11', 194, '2020-11-25', 'occupied'),
('12', 211, '2020-11-25', 'occupied'),
('13', 137, '2020-11-25', 'occupied'),
('13', 110, '2020-11-25', 'occupied'),
('14', 80, '2020-11-25', 'occupied'),
('14', 107, '2020-11-25', 'occupied'),
('15', 206, '2020-11-25', 'occupied'),
('15', 181, '2020-11-25', 'occupied'),
('15', 22, '2020-11-25', 'occupied'),
('16', 271, '2020-11-25', 'occupied'),
('16', 262, '2020-11-25', 'occupied');

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
(2, 'false', '2020-12-17'),
(3, 'false', '2020-12-31'),
(4, 'false', '2021-01-14'),
(5, 'false', '2020-12-25'),
(7, 'false', '2021-02-11'),
(8, 'false', '2021-02-26'),
(9, 'false', '2020-12-16'),
(10, 'false', '2021-01-01'),
(11, 'false', '2021-01-20'),
(12, 'false', '2021-01-23'),
(13, 'false', '2021-01-15'),
(14, 'false', '2021-01-28'),
(15, 'false', '2021-01-27'),
(16, 'false', '2021-01-21'),
(17, 'false', '2020-12-23'),
(18, 'false', '2020-12-18'),
(19, 'false', '2022-01-19'),
(25, 'false', '2020-11-26'),
(28, 'false', '2020-11-24');

-- --------------------------------------------------------

--
-- Table structure for table `tbltransaction`
--

CREATE TABLE `tbltransaction` (
  `ID` int(11) NOT NULL,
  `ORNO` varchar(50) NOT NULL,
  `Ammount` int(11) NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
-- Indexes for table `tblbookedseats`
--
ALTER TABLE `tblbookedseats`
  ADD PRIMARY KEY (`SeatNoID`),
  ADD KEY `customerID` (`customerID`);

--
-- Indexes for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  ADD PRIMARY KEY (`customerID`);

--
-- Indexes for table `tblseatcategory`
--
ALTER TABLE `tblseatcategory`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `SeatCat` (`SeatCat`);

--
-- Indexes for table `tblsocialdistancing`
--
ALTER TABLE `tblsocialdistancing`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbltransaction`
--
ALTER TABLE `tbltransaction`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `userfield`
--
ALTER TABLE `userfield`
  ADD PRIMARY KEY (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `movieinfo`
--
ALTER TABLE `movieinfo`
  MODIFY `movieID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `moviesched`
--
ALTER TABLE `moviesched`
  MODIFY `schedID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT for table `tblbookedseats`
--
ALTER TABLE `tblbookedseats`
  MODIFY `SeatNoID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  MODIFY `customerID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=197;

--
-- AUTO_INCREMENT for table `tblseatcategory`
--
ALTER TABLE `tblseatcategory`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tblsocialdistancing`
--
ALTER TABLE `tblsocialdistancing`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `tbltransaction`
--
ALTER TABLE `tbltransaction`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tblbookedseats`
--
ALTER TABLE `tblbookedseats`
  ADD CONSTRAINT `test` FOREIGN KEY (`customerID`) REFERENCES `tblcustomer` (`customerID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
