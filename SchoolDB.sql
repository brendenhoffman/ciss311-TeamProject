-- Create the SchoolDB database if it doesn't exist
USE master;
IF DB_ID(N'SchoolDB') IS NOT NULL
    DROP DATABASE SchoolDB;
GO

CREATE DATABASE SchoolDB;
GO

USE SchoolDB;
GO

-- Students table
CREATE TABLE Student (
    StudentId NVARCHAR(50) NOT NULL PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Gpa FLOAT NOT NULL,
    Hours FLOAT NOT NULL
);

-- Courses table
CREATE TABLE Course (
    CourseId NVARCHAR(50) NOT NULL PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    Instructor NVARCHAR(100) NOT NULL,
    Semester NVARCHAR(50) NOT NULL
);

-- Enrollments table (many-to-many link between students and courses)
CREATE TABLE Enrollment (
    StudentId NVARCHAR(50) NOT NULL,
    CourseId NVARCHAR(50) NOT NULL,
    PRIMARY KEY (StudentId, CourseId),
    FOREIGN KEY (StudentId) REFERENCES Student(StudentId),
    FOREIGN KEY (CourseId) REFERENCES Course(CourseId)
);
