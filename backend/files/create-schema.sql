
CREATE DATABASE `babelizer`

CREATE TABLE `translations` (
  `id` varchar(100) NOT NULL,
  `locale` varchar(10) NOT NULL,
  `text` varchar(256) NOT NULL,
  PRIMARY KEY (`id`,`locale`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

