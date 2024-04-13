-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 13, 2024 at 08:50 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bookbase`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `author` varchar(255) NOT NULL,
  `publisher` varchar(255) NOT NULL,
  `year_published` int(4) NOT NULL,
  `image_url` varchar(255) DEFAULT NULL,
  `shelf_location` varchar(255) NOT NULL,
  `added_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`id`, `title`, `author`, `publisher`, `year_published`, `image_url`, `shelf_location`, `added_at`) VALUES
(1, 'Clara Callan', 'Richard Bruce Wright', 'HarperFlamingo Canada', 2001, 'https://upload.wikimedia.org/wikipedia/en/3/3c/Clara_Callan_book_cover.png', 'Literature section, Shelf 2A', '2024-04-08 22:02:43'),
(2, 'Decision in Normandy', 'Carlo D\'Este', 'HarperPerennial', 1991, 'https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1387347202i/1508654.jpg', 'Military History section, Shelf 4C', '2024-04-08 22:02:43'),
(3, 'Where You\'ll Find Me', 'Ann Beattie', 'Scribner', 2002, 'https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439660982i/260487.jpg', 'Short Stories section, Shelf 3D', '2024-04-08 22:02:43'),
(4, 'Classical Mythology', 'Mark P. O. Morford', 'Oxford University Press', 2002, 'https://cdn.kobo.com/book-images/482989cc-1c08-48f8-9817-2744b234e07a/1200/1200/False/classical-mythology-a-to-z-1.jpg', 'Mythology section, Shelf 5B', '2024-04-08 22:02:43'),
(5, 'Flu: The Great Influenza Pandemic', 'Gina Bari Kolata', 'Farrar Straus Giroux', 1999, 'https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1440930349i/763331.jpg', 'Medicine section, Shelf 6A', '2024-04-08 22:02:43'),
(6, 'The Mummies of Urumchi', 'E. J. W. Barber', 'W. W. Norton &amp; Company', 1999, 'https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1347263564i/590434.jpg', 'Archaeology section, Shelf 7C', '2024-04-08 22:02:43'),
(7, 'The Kitchen God\'s Wife', 'Amy Tan', 'Putnam Pub Group', 1991, 'https://www.publishersweekly.com/cover/9780804107532', 'Literature section, Shelf 2A', '2024-04-08 22:02:43'),
(8, 'PLEADING GUILTY', 'Scott Turow', 'Audioworks', 1993, 'https://archive.org/services/img/isbn_9780670852758/full/pct:200/0/default.jpg', 'Legal Thrillers section, Shelf 4D', '2024-04-08 22:02:43');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `title` (`title`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=679425609;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
