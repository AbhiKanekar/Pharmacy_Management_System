CREATE TABLE medic (
    id INT PRIMARY KEY,
    mid VARCHAR(250) NOT NULL,
    mname VARCHAR(250) NOT NULL,
    mnumber VARCHAR(250) NOT NULL,
    mDate VARCHAR(250) NOT NULL,
    eDate VARCHAR(250) NOT NULL,
    quantity BIGINT NOT NULL,
    perUnit BIGINT NOT NULL
);

CREATE TABLE users (
    id INT PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    UserName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(15) NOT NULL,
    Role NVARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL
);

CREATE TABLE manufacturer (
    id INT PRIMARY KEY,
    name VARCHAR(70) NOT NULL,
    address VARCHAR(70) NOT NULL,
    phoneNo VARCHAR(20) NOT NULL,
    email VARCHAR(50) NOT NULL,
    ownerName VARCHAR(50) NOT NULL,
    mobileNo VARCHAR(20) NOT NULL
);

CREATE TABLE customer (
    id INT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    address VARCHAR(70) NOT NULL,
    age VARCHAR(10) NOT NULL,
    email VARCHAR(20) NOT NULL,
    mobileNo VARCHAR(15) NOT NULL
);
