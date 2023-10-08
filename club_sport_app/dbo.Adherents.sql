CREATE TABLE [dbo].[Adherents] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [Nom]       VARCHAR (50)    NULL,
    [Prenom]    VARCHAR (50)    NULL,
    [CNE]       VARCHAR (50)    NULL,
    [Age]       INT             NULL,
    [Adresse]   VARBINARY (MAX) NULL,
    [Ville]     VARCHAR (50)    NULL,
    [Telephone] VARCHAR (50)    NULL,
    [Email]     VARCHAR (50)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

