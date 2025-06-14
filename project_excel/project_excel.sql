USE [project_excel]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 5/21/2025 2:39:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[Id] [int] NOT NULL,
	[Nama] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GetPersons]    Script Date: 5/21/2025 2:39:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPersons]
AS
BEGIN
    WITH CTE_Persons AS (
        SELECT Id, Nama
        FROM Persons
    )
    SELECT * FROM CTE_Persons;
END
GO
