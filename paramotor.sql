-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 24 May 2023, 23:44:53
-- Sunucu sürümü: 10.4.27-MariaDB
-- PHP Sürümü: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `paramotor`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `about`
--

CREATE TABLE `about` (
  `id` int(11) NOT NULL,
  `title` varchar(250) DEFAULT NULL,
  `subtitle` varchar(250) DEFAULT NULL,
  `detail` varchar(500) DEFAULT NULL,
  `image` varchar(250) DEFAULT NULL,
  `isview` tinyint(1) DEFAULT NULL,
  `order` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `about`
--

INSERT INTO `about` (`id`, `title`, `subtitle`, `detail`, `image`, `isview`, `order`) VALUES
(1, 'Road to Success', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed eiusmod tempor incididunt							labore dolore magna aliqua enim minim veniam quis nostrud.', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed eiusmod tempor incididunt							labore dolore magna aliqua enim minim veniam quis nostrud.', 'mission-1.jpg', 1, 0),
(2, 'Road to Success2', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed eiusmod tempor incididunt							labore dolore magna aliqua enim minim veniam quis nostrud.2', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed eiusmod tempor incididunt							labore dolore magna aliqua enim minim veniam quis nostrud.', 'mission-1.jpg', 1, 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `portfolio`
--

CREATE TABLE `portfolio` (
  `id` int(11) NOT NULL,
  `title` varchar(50) DEFAULT NULL,
  `subtitle` varchar(250) DEFAULT NULL,
  `detail` varchar(250) DEFAULT NULL,
  `image` varchar(250) DEFAULT NULL,
  `type` varchar(50) DEFAULT NULL,
  `rating` int(5) DEFAULT NULL,
  `client` varchar(50) DEFAULT NULL,
  `website` varchar(250) DEFAULT NULL,
  `complated` varchar(250) DEFAULT NULL,
  `facebook` varchar(250) DEFAULT NULL,
  `twitter` varchar(250) DEFAULT NULL,
  `instagram` varchar(250) DEFAULT NULL,
  `linkedin` varchar(250) DEFAULT NULL,
  `isview` tinyint(1) DEFAULT NULL,
  `order` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `portfolio`
--

INSERT INTO `portfolio` (`id`, `title`, `subtitle`, `detail`, `image`, `type`, `rating`, `client`, `website`, `complated`, `facebook`, `twitter`, `instagram`, `linkedin`, `isview`, `order`) VALUES
(1, 'Exotic Mangrove1', 'Lorem ipsum dolor sit amet,1 consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.', 'Voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium dol', 'project-1.jpg', 'Lifestyle/People', 5, 'paramotorturkey', 'paramotorturkey.com', '24 May 2023', 'facebook', 'facebook', 'facebook', 'facebook', 1, 1),
(2, 'Exotic Mangrove', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.', 'Voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium dol', 'project-2.jpg', 'Lifestyle/People', 5, 'deneme', 'deneme', '25 May 2023', 'facebook', 'facebook', 'facebook', 'facebook', 1, 2),
(3, 'Exotic Mangrove', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.', 'Voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium dol', 'project-3.jpg', 'Lifestyle/People', 5, 'paramotorturkey', 'paramotorturkey.com', '24 May 2023', 'facebook', 'facebook', 'facebook', 'facebook', 1, 3),
(4, 'Exotic Mangrove', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.', 'Voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium dol', 'project-4.jpg', 'Lifestyle/People', 5, 'paramotorturkey', 'paramotorturkey.com', '24 May 2023', 'facebook', 'facebook', 'facebook', 'facebook', 1, 4),
(5, 'Exotic Mangrove', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.', 'Voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium dol', 'project-5.jpg', 'Lifestyle/People', 5, 'paramotorturkey', 'paramotorturkey.com', '24 May 2023', 'facebook', 'facebook', 'facebook', 'facebook', 1, 5),
(6, 'Exotic Mangrove', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.', 'Voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium dol', 'project-6.jpg', 'Lifestyle/People', 5, 'paramotorturkey', 'paramotorturkey.com', '24 May 2023', 'facebook', 'facebook', 'facebook', 'facebook', 1, 6);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `site`
--

CREATE TABLE `site` (
  `id` int(11) NOT NULL,
  `title` varchar(250) NOT NULL,
  `url` varchar(250) NOT NULL,
  `email` varchar(250) NOT NULL,
  `description` longtext NOT NULL,
  `facebook` varchar(250) NOT NULL,
  `twitter` varchar(250) NOT NULL,
  `instagram` varchar(250) NOT NULL,
  `youtube` varchar(250) NOT NULL,
  `logoImage` varchar(250) NOT NULL,
  `favicon` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `site`
--

INSERT INTO `site` (`id`, `title`, `url`, `email`, `description`, `facebook`, `twitter`, `instagram`, `youtube`, `logoImage`, `favicon`) VALUES
(1, 'Paramotor', 'Paramotor', 'support@paramotor.com', 'Paramotor', 'https://www.facebook.com/', 'https://twitter.com/', 'https://instagram.com/', 'https://www.youtube.com/channel/UCJwdrKH68GuyFj2o14eoDsw', 'logo.png', 'favicon.png');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `slide`
--

CREATE TABLE `slide` (
  `id` int(11) NOT NULL,
  `title` varchar(250) DEFAULT NULL,
  `subtitle` text DEFAULT NULL,
  `url` varchar(250) DEFAULT NULL,
  `urltext` varchar(250) DEFAULT NULL,
  `image` varchar(250) DEFAULT NULL,
  `isTarget` varchar(50) DEFAULT NULL,
  `isView` tinyint(1) DEFAULT 0,
  `order` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `slide`
--

INSERT INTO `slide` (`id`, `title`, `subtitle`, `url`, `urltext`, `image`, `isTarget`, `isView`, `order`) VALUES
(1, 'Business with Finance', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod										tempor incididunt ut labore et dolore magna aliqua.', '/blog', 'Explore Us', 'slider-1.jpg', '_blank', 1, 1),
(2, 'Business with Finance2', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod										tempor incididunt ut labore et dolore magna aliqua.2', '/', 'Explore Us', 'slider-2.jpg', '_self', 1, 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `team`
--

CREATE TABLE `team` (
  `id` int(11) NOT NULL,
  `title` varchar(250) DEFAULT NULL,
  `subtitle` varchar(250) DEFAULT NULL,
  `image` varchar(250) DEFAULT NULL,
  `facebook` varchar(250) DEFAULT NULL,
  `instagram` varchar(250) DEFAULT NULL,
  `twitter` varchar(250) DEFAULT NULL,
  `youtube` varchar(250) DEFAULT NULL,
  `linkedin` varchar(250) DEFAULT NULL,
  `isview` tinyint(1) DEFAULT NULL,
  `order` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `team`
--

INSERT INTO `team` (`id`, `title`, `subtitle`, `image`, `facebook`, `instagram`, `twitter`, `youtube`, `linkedin`, `isview`, `order`) VALUES
(1, 'GLENN WATSON', 'Managing Director (Sales)', 'team-1.jpg', 'https://www.facebook.com/glennwatson', 'https://www.instagram.com/glennwatson', 'https://www.twitter.com/glennwatson', 'https://www.youtube.com/glennwatson', 'https://www.linkedin.com/glennwatson', 1, 2),
(2, 'Ahmet Emir Çetin', 'Fullstack Developer', 'amed.jpg', 'https://www.facebook.com/amed', 'https://www.instagram.com/amed', 'https://www.twitter.com/amed', 'https://www.youtube.com/amed', 'https://www.linkedin.com/amed', 1, 1);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `about`
--
ALTER TABLE `about`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `portfolio`
--
ALTER TABLE `portfolio`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `site`
--
ALTER TABLE `site`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `slide`
--
ALTER TABLE `slide`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `team`
--
ALTER TABLE `team`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `about`
--
ALTER TABLE `about`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tablo için AUTO_INCREMENT değeri `portfolio`
--
ALTER TABLE `portfolio`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Tablo için AUTO_INCREMENT değeri `site`
--
ALTER TABLE `site`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `slide`
--
ALTER TABLE `slide`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tablo için AUTO_INCREMENT değeri `team`
--
ALTER TABLE `team`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
