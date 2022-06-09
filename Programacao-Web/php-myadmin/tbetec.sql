-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 09-Jun-2022 às 01:22
-- Versão do servidor: 10.4.21-MariaDB
-- versão do PHP: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bdetec`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbetec`
--

CREATE TABLE `tbetec` (
  `id` int(11) NOT NULL,
  `nome` varchar(40) NOT NULL,
  `datanascimento` date NOT NULL,
  `cpf` char(11) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tbetec`
--

INSERT INTO `tbetec` (`id`, `nome`, `datanascimento`, `cpf`, `email`) VALUES
(1, 'matheus', '1997-09-24', '47076662809', 'mattpolidoro@gmail.com'),
(2, 'ingrid', '1999-11-04', '468990998', 'ingrid@ingrid.com');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tbetec`
--
ALTER TABLE `tbetec`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tbetec`
--
ALTER TABLE `tbetec`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
