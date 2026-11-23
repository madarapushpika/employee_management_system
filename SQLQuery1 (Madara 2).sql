
CREATE TABLE Employees
(
    Emp_No VARCHAR(20) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Address VARCHAR(250) NOT NULL,
    Gender CHAR(1) NOT NULL,
    Status CHAR(1) NOT NULL
);

SELECT * FROM Employees;
SELECT * FROM Employees;

CREATE TABLE EmployeePerformance
(
    Emp_No VARCHAR(20) PRIMARY KEY,
    Score INT NOT NULL CHECK (Score BETWEEN 0 AND 100),
    Category VARCHAR(50) NOT NULL,
    Remarks VARCHAR(250) NULL,

    FOREIGN KEY (Emp_No) REFERENCES Employees(Emp_No)
);