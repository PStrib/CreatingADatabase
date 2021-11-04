CREATE TABLE [dbo].[Project](
[ProjectCode] int PRIMARY KEY,
[ProjectTitle] varchar(50) NOT NULL,
[ProjectManager] varchar(50) NOT NULL,
[ProjectBudget] decimal (18,2) NOT NULL);