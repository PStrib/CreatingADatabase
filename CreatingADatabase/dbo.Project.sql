CREATE TABLE [dbo].[Project] (
    [ProjectCode]    INT             NOT NULL,
    [ProjectTitle]   VARCHAR (50)    NOT NULL,
    [ProjectManager] VARCHAR (50)    NOT NULL,
    [ProjectBudget]  DECIMAL (18, 2) NOT NULL,
    [ProjectStartDate] DATE NOT NULL, 
    [ProjectEndDate] DATE NOT NULL, 
    [ProjectCompleted] BIT NULL, 
    PRIMARY KEY CLUSTERED ([ProjectCode] ASC)
);

