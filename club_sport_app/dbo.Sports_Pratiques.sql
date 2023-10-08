CREATE TABLE [dbo].[Sports Pratiques] (
    [Id_spratique] INT          IDENTITY (1, 1) NOT NULL,
    [nom_Sport]    VARCHAR (50) NULL,
    [num_Adherent] INT          NULL,
    [date_Debut]   DATE         NULL,
    [date_Fin]     DATE         NULL,
    PRIMARY KEY CLUSTERED ([Id_spratique] ASC)
);

