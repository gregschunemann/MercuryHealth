﻿/*
Deployment script for MercuryHealth.Sql

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "MercuryHealth.Sql"
:setvar DefaultFilePrefix "MercuryHealth.Sql"
:setvar DefaultDataPath "C:\Users\grschune\AppData\Local\Microsoft\VisualStudio\SSDT\MercuryHealth"
:setvar DefaultLogPath "C:\Users\grschune\AppData\Local\Microsoft\VisualStudio\SSDT\MercuryHealth"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                CURSOR_DEFAULT LOCAL 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET PAGE_VERIFY NONE,
                DISABLE_BROKER 
            WITH ROLLBACK IMMEDIATE;
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = AUTO, OPERATION_MODE = READ_WRITE) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
PRINT N'Creating [dbo].[__MigrationHistory]...';


GO
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId]    NVARCHAR (150)  NOT NULL,
    [ContextKey]     NVARCHAR (300)  NOT NULL,
    [Model]          VARBINARY (MAX) NOT NULL,
    [ProductVersion] NVARCHAR (32)   NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED ([MigrationId] ASC, [ContextKey] ASC)
);


GO
PRINT N'Creating [dbo].[AspNetRoles]...';


GO
CREATE TABLE [dbo].[AspNetRoles] (
    [Id]   NVARCHAR (128) NOT NULL,
    [Name] NVARCHAR (256) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[AspNetRoles].[RoleNameIndex]...';


GO
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex]
    ON [dbo].[AspNetRoles]([Name] ASC);


GO
PRINT N'Creating [dbo].[AspNetUserClaims]...';


GO
CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [UserId]     NVARCHAR (128) NOT NULL,
    [ClaimType]  NVARCHAR (MAX) NULL,
    [ClaimValue] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[AspNetUserClaims].[IX_UserId]...';


GO
CREATE NONCLUSTERED INDEX [IX_UserId]
    ON [dbo].[AspNetUserClaims]([UserId] ASC);


GO
PRINT N'Creating [dbo].[AspNetUserLogins]...';


GO
CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider] NVARCHAR (128) NOT NULL,
    [ProviderKey]   NVARCHAR (128) NOT NULL,
    [UserId]        NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED ([LoginProvider] ASC, [ProviderKey] ASC, [UserId] ASC)
);


GO
PRINT N'Creating [dbo].[AspNetUserLogins].[IX_UserId]...';


GO
CREATE NONCLUSTERED INDEX [IX_UserId]
    ON [dbo].[AspNetUserLogins]([UserId] ASC);


GO
PRINT N'Creating [dbo].[AspNetUserRoles]...';


GO
CREATE TABLE [dbo].[AspNetUserRoles] (
    [UserId] NVARCHAR (128) NOT NULL,
    [RoleId] NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED ([UserId] ASC, [RoleId] ASC)
);


GO
PRINT N'Creating [dbo].[AspNetUserRoles].[IX_RoleId]...';


GO
CREATE NONCLUSTERED INDEX [IX_RoleId]
    ON [dbo].[AspNetUserRoles]([RoleId] ASC);


GO
PRINT N'Creating [dbo].[AspNetUserRoles].[IX_UserId]...';


GO
CREATE NONCLUSTERED INDEX [IX_UserId]
    ON [dbo].[AspNetUserRoles]([UserId] ASC);


GO
PRINT N'Creating [dbo].[AspNetUsers]...';


GO
CREATE TABLE [dbo].[AspNetUsers] (
    [Id]                   NVARCHAR (128) NOT NULL,
    [Email]                NVARCHAR (256) NULL,
    [EmailConfirmed]       BIT            NOT NULL,
    [PasswordHash]         NVARCHAR (MAX) NULL,
    [SecurityStamp]        NVARCHAR (MAX) NULL,
    [PhoneNumber]          NVARCHAR (MAX) NULL,
    [PhoneNumberConfirmed] BIT            NOT NULL,
    [TwoFactorEnabled]     BIT            NOT NULL,
    [LockoutEndDateUtc]    DATETIME       NULL,
    [LockoutEnabled]       BIT            NOT NULL,
    [AccessFailedCount]    INT            NOT NULL,
    [UserName]             NVARCHAR (256) NOT NULL,
    [MemberProfile_Id]     INT            NULL,
    CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[AspNetUsers].[UserNameIndex]...';


GO
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex]
    ON [dbo].[AspNetUsers]([UserName] ASC);


GO
PRINT N'Creating [dbo].[AspNetUsers].[IX_MemberProfile_Id]...';


GO
CREATE NONCLUSTERED INDEX [IX_MemberProfile_Id]
    ON [dbo].[AspNetUsers]([MemberProfile_Id] ASC);


GO
PRINT N'Creating [dbo].[Exercises]...';


GO
CREATE TABLE [dbo].[Exercises] (
    [Id]              UNIQUEIDENTIFIER NOT NULL,
    [Name]            NVARCHAR (MAX)   NULL,
    [Description]     NVARCHAR (MAX)   NULL,
    [VideoUrl]        NVARCHAR (MAX)   NULL,
    [MusclesInvolved] NVARCHAR (MAX)   NULL,
    [Equipment]       NVARCHAR (MAX)   NULL,
    [Exercise_Id]     UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_dbo.Exercises] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Exercises].[IX_Exercise_Id]...';


GO
CREATE NONCLUSTERED INDEX [IX_Exercise_Id]
    ON [dbo].[Exercises]([Exercise_Id] ASC);


GO
PRINT N'Creating [dbo].[FoodLogEntries]...';


GO
CREATE TABLE [dbo].[FoodLogEntries] (
    [Id]                   INT             IDENTITY (1, 1) NOT NULL,
    [Description]          NVARCHAR (MAX)  NULL,
    [Quantity]             REAL            NOT NULL,
    [MealTime]             DATETIME        NOT NULL,
    [Tags]                 NVARCHAR (MAX)  NULL,
    [Calories]             INT             NOT NULL,
    [ProteinInGrams]       DECIMAL (18, 2) NOT NULL,
    [FatInGrams]           DECIMAL (18, 2) NOT NULL,
    [CarbohydratesInGrams] DECIMAL (18, 2) NOT NULL,
    [SodiumInGrams]        DECIMAL (18, 2) NOT NULL,
    [Color]                NVARCHAR (MAX)  NULL,
    [MemberProfile_Id]     INT             NULL,
    CONSTRAINT [PK_dbo.FoodLogEntries] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[FoodLogEntries].[IX_MemberProfile_Id]...';


GO
CREATE NONCLUSTERED INDEX [IX_MemberProfile_Id]
    ON [dbo].[FoodLogEntries]([MemberProfile_Id] ASC);


GO
PRINT N'Creating [dbo].[MemberProfiles]...';


GO
CREATE TABLE [dbo].[MemberProfiles] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [Birthdate]           DATETIME       NOT NULL,
    [Gender]              INT            NOT NULL,
    [Bio]                 NVARCHAR (MAX) NULL,
    [WeightInKilograms]   INT            NOT NULL,
    [HeightInCentimeters] INT            NOT NULL,
    CONSTRAINT [PK_dbo.MemberProfiles] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating unnamed constraint on [dbo].[Exercises]...';


GO
ALTER TABLE [dbo].[Exercises]
    ADD DEFAULT (newsequentialid()) FOR [Id];


GO
PRINT N'Creating [dbo].[FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]...';


GO
ALTER TABLE [dbo].[AspNetUserClaims] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE;


GO
PRINT N'Creating [dbo].[FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]...';


GO
ALTER TABLE [dbo].[AspNetUserLogins] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE;


GO
PRINT N'Creating [dbo].[FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]...';


GO
ALTER TABLE [dbo].[AspNetUserRoles] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[AspNetRoles] ([Id]) ON DELETE CASCADE;


GO
PRINT N'Creating [dbo].[FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]...';


GO
ALTER TABLE [dbo].[AspNetUserRoles] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE;


GO
PRINT N'Creating [dbo].[FK_dbo.AspNetUsers_dbo.MemberProfiles_MemberProfile_Id]...';


GO
ALTER TABLE [dbo].[AspNetUsers] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.AspNetUsers_dbo.MemberProfiles_MemberProfile_Id] FOREIGN KEY ([MemberProfile_Id]) REFERENCES [dbo].[MemberProfiles] ([Id]);


GO
PRINT N'Creating [dbo].[FK_dbo.Exercises_dbo.Exercises_Exercise_Id]...';


GO
ALTER TABLE [dbo].[Exercises] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.Exercises_dbo.Exercises_Exercise_Id] FOREIGN KEY ([Exercise_Id]) REFERENCES [dbo].[Exercises] ([Id]);


GO
PRINT N'Creating [dbo].[FK_dbo.FoodLogEntries_dbo.MemberProfiles_MemberProfile_Id]...';


GO
ALTER TABLE [dbo].[FoodLogEntries] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.FoodLogEntries_dbo.MemberProfiles_MemberProfile_Id] FOREIGN KEY ([MemberProfile_Id]) REFERENCES [dbo].[MemberProfiles] ([Id]);


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[AspNetUserClaims] WITH CHECK CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId];

ALTER TABLE [dbo].[AspNetUserLogins] WITH CHECK CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId];

ALTER TABLE [dbo].[AspNetUserRoles] WITH CHECK CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId];

ALTER TABLE [dbo].[AspNetUserRoles] WITH CHECK CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId];

ALTER TABLE [dbo].[AspNetUsers] WITH CHECK CHECK CONSTRAINT [FK_dbo.AspNetUsers_dbo.MemberProfiles_MemberProfile_Id];

ALTER TABLE [dbo].[Exercises] WITH CHECK CHECK CONSTRAINT [FK_dbo.Exercises_dbo.Exercises_Exercise_Id];

ALTER TABLE [dbo].[FoodLogEntries] WITH CHECK CHECK CONSTRAINT [FK_dbo.FoodLogEntries_dbo.MemberProfiles_MemberProfile_Id];


GO
PRINT N'Update complete.';


GO
