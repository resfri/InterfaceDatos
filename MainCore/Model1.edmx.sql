
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/02/2015 18:05:07
-- Generated from EDMX file: C:\Users\Fabian\Source\Repos\InterfaceDatos2\MainCore\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PacienteImagenes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImagenesSet] DROP CONSTRAINT [FK_PacienteImagenes];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteHistoriaClinica]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HistoriaClinicaSet] DROP CONSTRAINT [FK_PacienteHistoriaClinica];
GO
IF OBJECT_ID(N'[dbo].[FK_MPATImagenes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImagenesSet] DROP CONSTRAINT [FK_MPATImagenes];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PacienteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PacienteSet];
GO
IF OBJECT_ID(N'[dbo].[ImagenesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ImagenesSet];
GO
IF OBJECT_ID(N'[dbo].[HistoriaClinicaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HistoriaClinicaSet];
GO
IF OBJECT_ID(N'[dbo].[MPATSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MPATSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PacienteSet'
CREATE TABLE [dbo].[PacienteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DNI] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Edad] int  NOT NULL,
    [Sexo] int  NOT NULL,
    [Ubicacion] nvarchar(max)  NOT NULL,
    [FechaRegistro] datetime  NOT NULL
);
GO

-- Creating table 'ImagenesSet'
CREATE TABLE [dbo].[ImagenesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NumeroCiclos] int  NOT NULL,
    [NumeroToma] int  NOT NULL,
    [Cara] int  NOT NULL,
    [IdPaciente] int  NOT NULL,
    [IdMPAT] int  NOT NULL
);
GO

-- Creating table 'HistoriaClinicaSet'
CREATE TABLE [dbo].[HistoriaClinicaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Odontograma] nvarchar(max)  NOT NULL,
    [NumeroCariados] int  NOT NULL,
    [NumeroDientesPerdidos] int  NOT NULL,
    [NumeroDientesObturados] int  NOT NULL,
    [Ortodoncia] nvarchar(max)  NOT NULL,
    [Protesis] nvarchar(max)  NOT NULL,
    [Implantes] int  NOT NULL,
    [ParesAntagPerdidos] int  NOT NULL,
    [GradoEdentulismo] int  NOT NULL,
    [EstadoSaludGeneral] bit  NOT NULL,
    [EnfermedadCardioVascular] bit  NOT NULL,
    [EnfermedadRenal] bit  NOT NULL,
    [ICTUS] bit  NOT NULL,
    [ACV] bit  NOT NULL,
    [ParalisisFacial] bit  NOT NULL,
    [GradoDesnutricion] int  NOT NULL,
    [IdPaciente] int  NOT NULL
);
GO

-- Creating table 'MPATSet'
CREATE TABLE [dbo].[MPATSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [WikiURL] nvarchar(max)  NOT NULL,
    [AlimentoPrueba] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PacienteSet'
ALTER TABLE [dbo].[PacienteSet]
ADD CONSTRAINT [PK_PacienteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ImagenesSet'
ALTER TABLE [dbo].[ImagenesSet]
ADD CONSTRAINT [PK_ImagenesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HistoriaClinicaSet'
ALTER TABLE [dbo].[HistoriaClinicaSet]
ADD CONSTRAINT [PK_HistoriaClinicaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MPATSet'
ALTER TABLE [dbo].[MPATSet]
ADD CONSTRAINT [PK_MPATSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdPaciente] in table 'ImagenesSet'
ALTER TABLE [dbo].[ImagenesSet]
ADD CONSTRAINT [FK_PacienteImagenes]
    FOREIGN KEY ([IdPaciente])
    REFERENCES [dbo].[PacienteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteImagenes'
CREATE INDEX [IX_FK_PacienteImagenes]
ON [dbo].[ImagenesSet]
    ([IdPaciente]);
GO

-- Creating foreign key on [IdPaciente] in table 'HistoriaClinicaSet'
ALTER TABLE [dbo].[HistoriaClinicaSet]
ADD CONSTRAINT [FK_PacienteHistoriaClinica]
    FOREIGN KEY ([IdPaciente])
    REFERENCES [dbo].[PacienteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteHistoriaClinica'
CREATE INDEX [IX_FK_PacienteHistoriaClinica]
ON [dbo].[HistoriaClinicaSet]
    ([IdPaciente]);
GO

-- Creating foreign key on [IdMPAT] in table 'ImagenesSet'
ALTER TABLE [dbo].[ImagenesSet]
ADD CONSTRAINT [FK_MPATImagenes]
    FOREIGN KEY ([IdMPAT])
    REFERENCES [dbo].[MPATSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MPATImagenes'
CREATE INDEX [IX_FK_MPATImagenes]
ON [dbo].[ImagenesSet]
    ([IdMPAT]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------