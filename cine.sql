-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-12-2024 a las 02:13:16
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `cine`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `products`
--

CREATE TABLE `products` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Img` varchar(255) NOT NULL,
  `About` varchar(255) NOT NULL,
  `Precio` float NOT NULL,
  `Stock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `products`
--

INSERT INTO `products` (`ID`, `Name`, `Img`, `About`, `Precio`, `Stock`) VALUES
(1, 'Back To The Future', 'backToTheFuture.jpg', 'Relata las aventuras de Marty McFly, un adolescente rebelde e impulsivo que vive con sus padres y viaja accidentalmente al pasado desde 1985, su época, a 1955, la época en que sus padres se conocieron.', 120, 0),
(2, 'Emma', 'emma.jpg', 'Una chica normal', 123, 5),
(3, 'Ferris Bueller\'s Day Off', 'ferris.jpg', 'Narra la historia de un joven de 17 años que decide tomarse un día libre de la escuela para disfrutar de la ciudad con su mejor amigo y su novia.', 160, 1),
(4, 'Gone Girl', 'goneGirl.jpg', 'Cuenta la historia de la desaparición de Amy Dunne, la esposa de Nick Dunne, el día de su quinto aniversario de bodas', 120.5, 1),
(5, 'Knives Out', 'knivesOut.jpg', 'Es una película de comedia y misterio que trata sobre un detective que investiga la muerte de un novelista de misterio', 130.5, 1),
(6, 'La La Land', 'lalaLand.jpg', 'Trata sobre el romance entre una aspirante a actriz y un pianista de jazz que luchan por triunfar en Los Ángeles', 132.6, 1),
(8, 'Shreck', 'shreck.jpg', 'Una película maravillosa de ogros', 120, 50);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sweets`
--

CREATE TABLE `sweets` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Stock` int(11) NOT NULL,
  `About` varchar(255) NOT NULL,
  `Price` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `sweets`
--

INSERT INTO `sweets` (`ID`, `Name`, `Stock`, `About`, `Price`) VALUES
(1, 'Palomitas de Matequilla chicas', 12, 'Crujientes y deliciosas palomitas de mantequilla.', 96),
(2, 'Palomitas de caramelo chicas', 10, 'Crujientes y deliciosas palomitas de caramelo', 98),
(3, 'Refresco de maquina', 100, 'Elige de la varidad de refrescos ofrecidos por la marca coca cola.', 55),
(4, 'Palomitas de Mantequilla Grandes', 10, 'Crujientes y deliciosas palomitas de mantequilla.', 110),
(5, 'Palomitas de Caramelo Grandes', 10, 'Crujientes y deliciosas palomitas de caramelo.', 112),
(6, 'Nachos', 9, 'Deliciosos y calientitos nachs con queso fundido. ', 90);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `users`
--

CREATE TABLE `users` (
  `ID` int(11) NOT NULL,
  `Cuenta` varchar(255) NOT NULL,
  `Nombre` varchar(255) NOT NULL,
  `Pword` varchar(255) NOT NULL,
  `Monto` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `users`
--

INSERT INTO `users` (`ID`, `Cuenta`, `Nombre`, `Pword`, `Monto`) VALUES
(1, 'admin', 'Admin', 'admin2024', 0),
(2, 'isabelA', 'Isabel Alvarado de la Huerta', 'usuario2', 0),
(3, 'dannaC', 'Danna Cristina Castro Hernandez', 'usuario3', 0),
(4, 'darelyQ', 'Darely Quezada Guerrero', 'usuario4', 56),
(5, 'ferV', 'Celia Fernanda Vela Uribe', 'usuario5', 58),
(6, 'cesarZ', 'Cesar Andres Zuleta Malanco', 'usuario6', 922.66),
(7, 'guest', 'guest', 'guest2024', 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `sweets`
--
ALTER TABLE `sweets`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
