CREATE TABLE [dbo].[ProjectEmployee](
[ProjectCode] int NOT NULL,
[EmployeeNo] int NOT NULL ,
[HourlyRate] decimal(18,2) NOT NULL,
FOREIGN KEY ([ProjectCode]) REFERENCES Project,
FOREIGN KEY ([EmployeeNo]) REFERENCES Employee,
PRIMARY KEY ([EmployeeNo],[ProjectCode]));