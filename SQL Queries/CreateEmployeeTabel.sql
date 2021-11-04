CREATE TABLE [dbo].[Employee](
[EmployeeNo] int NOT NULL PRIMARY KEY,
[EmployeeName] varchar(50) NOT NULL,
[DepartmentNo] int NOT NULL,
FOREIGN KEY ([DepartmentNo]) REFERENCES Department);