USE master;

IF DB_ID(N'SchoolDB') IS NOT NULL DROP DATABASE SchoolDB;

CREATE DATABASE SchoolDB;

GO

USE SchoolDB;

GO

-- Creating the Student table
CREATE TABLE Student (
    studentId INT NOT NULL IDENTITY,
    studentName VARCHAR(100) NOT NULL,
    CONSTRAINT pk_student PRIMARY KEY (studentId)
);

-- Creating the Course table with a foreign key constraint
CREATE TABLE Course (
    courseId INT NOT NULL IDENTITY,
    courseTitle VARCHAR(100) NOT NULL,
    semesterOffered VARCHAR(20),
    studentId INT NOT NULL,  -- Added studentId column to reference
    CONSTRAINT pk_course PRIMARY KEY (courseId),
    CONSTRAINT fk_course_student FOREIGN KEY (studentId) 
    REFERENCES Student(studentId)
);