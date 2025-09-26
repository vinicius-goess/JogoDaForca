-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 26/09/2025 às 19:07
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `jogodafortuna`
--
CREATE DATABASE IF NOT EXISTS `jogodafortuna` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `jogodafortuna`;

-- --------------------------------------------------------

--
-- Estrutura para tabela `palavras`
--

CREATE TABLE IF NOT EXISTS `palavras` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `palavra` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `palavras`
--

INSERT INTO `palavras` (`id`, `palavra`) VALUES
(1, 'MARIA'),
(2, 'JOÃO'),
(3, 'PEDRO'),
(4, 'ANA'),
(5, 'LUIZA'),
(6, 'GABRIEL'),
(7, 'FERNANDA'),
(8, 'RAFAEL'),
(9, 'JULIANA'),
(10, 'BRUNO'),
(11, 'CAROLINA'),
(12, 'DANIEL'),
(13, 'ISABELA'),
(14, 'LUCAS'),
(15, 'MARIANA'),
(16, 'THIAGO'),
(17, 'PATRÍCIA'),
(18, 'GUSTAVO'),
(19, 'AMANDA'),
(20, 'FELIPE'),
(21, 'RENATA'),
(22, 'LEONARDO'),
(23, 'VITÓRIA'),
(24, 'MATEUS'),
(25, 'CLARA');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
