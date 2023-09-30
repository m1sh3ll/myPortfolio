-- Database: 'cis367_wk4gp'
DROP DATABASE IF EXISTS cis367_wk4gp;
CREATE DATABASE cis367_wk4gp DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE cis367_wk4gp;

-- Table structure for table 'users'
DROP TABLE IF EXISTS users;
CREATE TABLE users (
  UserId int(11) AUTO_INCREMENT PRIMARY KEY,
  FirstName varchar(50) NOT NULL,
  LastName varchar(50) NOT NULL,
  EMail varchar(50) NOT NULL,
  Password varchar(60) NOT NULL,
  RegistrationDate date NOT NULL,
  UserLevel int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Data for table 'users'
INSERT INTO users (FirstName, LastName, EMail, Password, RegistrationDate, UserLevel) VALUES
('YourFirst', 'YourLast', 'you@you.com', 'Pa$$word1', '2021-01-31', 1),
('Sybil', 'Ludington', 'SLudington@you.com', 'Pa$$word1', '1775-04-18', 2),
('Rasmus', 'Lerdorf', 'RLerdorf@you.com', 'Pa$$word1', '1995-06-01', 1),
('Percy', 'Julian', 'PJulian@you.com', 'Pa$$word1', '1973-07-01', 2),
('Edith', 'Wilson', 'EWilson@you.com', 'Pa$$word1', '1919-10-01', 2);

-- Add user account: User ID: cis367gp_user Password: cis367gp_pw
CREATE USER IF NOT EXISTS cis367gp_user@'%' IDENTIFIED VIA mysql_native_password USING 'pass64';
GRANT ALL PRIVILEGES ON cis367_wk4gp.* TO cis367gp_user@'%' REQUIRE NONE WITH GRANT OPTION MAX_QUERIES_PER_HOUR 0 MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0;
