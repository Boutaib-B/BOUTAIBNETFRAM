CREATE TABLE [dbo].[Sport] (
    [Id_sport]     INT          IDENTITY (1, 1) NOT NULL,
    [lib_sport]    VARCHAR (50) NULL,
    [prix]         INT          NULL,
    [Id_spratique] INT          NULL,
    PRIMARY KEY CLUSTERED ([Id_sport] ASC)
);

