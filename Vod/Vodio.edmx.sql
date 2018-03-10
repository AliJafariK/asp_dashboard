
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/03/2018 16:28:21
-- Generated from EDMX file: C:\Users\Ali Jafari\Desktop\ASP\Vod\Vod\Vodio.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Vodio];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MovieImage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Movies] DROP CONSTRAINT [FK_MovieImage];
GO
IF OBJECT_ID(N'[dbo].[FK_HomeBundle_Home]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HomeBundle] DROP CONSTRAINT [FK_HomeBundle_Home];
GO
IF OBJECT_ID(N'[dbo].[FK_HomeBundle_Bundle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HomeBundle] DROP CONSTRAINT [FK_HomeBundle_Bundle];
GO
IF OBJECT_ID(N'[dbo].[FK_BundleMovie_Bundle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BundleMovie] DROP CONSTRAINT [FK_BundleMovie_Bundle];
GO
IF OBJECT_ID(N'[dbo].[FK_BundleMovie_Movie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BundleMovie] DROP CONSTRAINT [FK_BundleMovie_Movie];
GO
IF OBJECT_ID(N'[dbo].[FK_BundleBanner_Bundle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BundleBanner] DROP CONSTRAINT [FK_BundleBanner_Bundle];
GO
IF OBJECT_ID(N'[dbo].[FK_BundleBanner_Banner]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BundleBanner] DROP CONSTRAINT [FK_BundleBanner_Banner];
GO
IF OBJECT_ID(N'[dbo].[FK_MovieCategory_Movie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieCategory] DROP CONSTRAINT [FK_MovieCategory_Movie];
GO
IF OBJECT_ID(N'[dbo].[FK_MovieCategory_Category]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieCategory] DROP CONSTRAINT [FK_MovieCategory_Category];
GO
IF OBJECT_ID(N'[dbo].[FK_MovieGenre_Movie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieGenre] DROP CONSTRAINT [FK_MovieGenre_Movie];
GO
IF OBJECT_ID(N'[dbo].[FK_MovieGenre_Genre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieGenre] DROP CONSTRAINT [FK_MovieGenre_Genre];
GO
IF OBJECT_ID(N'[dbo].[FK_RoleMovie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Roles] DROP CONSTRAINT [FK_RoleMovie];
GO
IF OBJECT_ID(N'[dbo].[FK_RoleAgent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Roles] DROP CONSTRAINT [FK_RoleAgent];
GO
IF OBJECT_ID(N'[dbo].[FK_CommentMovie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comments] DROP CONSTRAINT [FK_CommentMovie];
GO
IF OBJECT_ID(N'[dbo].[FK_RateMovie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rates] DROP CONSTRAINT [FK_RateMovie];
GO
IF OBJECT_ID(N'[dbo].[FK_RateUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rates] DROP CONSTRAINT [FK_RateUser];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoryGenreCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CategoryGenres] DROP CONSTRAINT [FK_CategoryGenreCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoryGenreGenre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CategoryGenres] DROP CONSTRAINT [FK_CategoryGenreGenre];
GO
IF OBJECT_ID(N'[dbo].[FK_PurchaseUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Purchases] DROP CONSTRAINT [FK_PurchaseUser];
GO
IF OBJECT_ID(N'[dbo].[FK_PurchaseMovie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Purchases] DROP CONSTRAINT [FK_PurchaseMovie];
GO
IF OBJECT_ID(N'[dbo].[FK_UserFactor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Factors] DROP CONSTRAINT [FK_UserFactor];
GO
IF OBJECT_ID(N'[dbo].[FK_FactorPurchase]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Purchases] DROP CONSTRAINT [FK_FactorPurchase];
GO
IF OBJECT_ID(N'[dbo].[FK_MessageUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Messages] DROP CONSTRAINT [FK_MessageUser];
GO
IF OBJECT_ID(N'[dbo].[FK_UserComment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comments] DROP CONSTRAINT [FK_UserComment];
GO
IF OBJECT_ID(N'[dbo].[FK_PanelUserMovie_PanelUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PanelUserMovie] DROP CONSTRAINT [FK_PanelUserMovie_PanelUser];
GO
IF OBJECT_ID(N'[dbo].[FK_PanelUserMovie_Movie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PanelUserMovie] DROP CONSTRAINT [FK_PanelUserMovie_Movie];
GO
IF OBJECT_ID(N'[dbo].[FK_MovieMovie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Movies] DROP CONSTRAINT [FK_MovieMovie];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Movies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Movies];
GO
IF OBJECT_ID(N'[dbo].[Images]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Images];
GO
IF OBJECT_ID(N'[dbo].[Homes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Homes];
GO
IF OBJECT_ID(N'[dbo].[Bundles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bundles];
GO
IF OBJECT_ID(N'[dbo].[Banners]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Banners];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[Genres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Genres];
GO
IF OBJECT_ID(N'[dbo].[Agents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Agents];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Comments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comments];
GO
IF OBJECT_ID(N'[dbo].[Rates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rates];
GO
IF OBJECT_ID(N'[dbo].[CategoryGenres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategoryGenres];
GO
IF OBJECT_ID(N'[dbo].[Purchases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Purchases];
GO
IF OBJECT_ID(N'[dbo].[Factors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Factors];
GO
IF OBJECT_ID(N'[dbo].[Messages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Messages];
GO
IF OBJECT_ID(N'[dbo].[PanelUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PanelUsers];
GO
IF OBJECT_ID(N'[dbo].[Emails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Emails];
GO
IF OBJECT_ID(N'[dbo].[HomeBundle]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HomeBundle];
GO
IF OBJECT_ID(N'[dbo].[BundleMovie]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BundleMovie];
GO
IF OBJECT_ID(N'[dbo].[BundleBanner]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BundleBanner];
GO
IF OBJECT_ID(N'[dbo].[MovieCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MovieCategory];
GO
IF OBJECT_ID(N'[dbo].[MovieGenre]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MovieGenre];
GO
IF OBJECT_ID(N'[dbo].[PanelUserMovie]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PanelUserMovie];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Movies'
CREATE TABLE [dbo].[Movies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Duration] bigint  NOT NULL,
    [Rate] float  NOT NULL,
    [RatedUsers] int  NOT NULL,
    [CommentId] int  NOT NULL,
    [Visit] int  NOT NULL,
    [Year] int  NOT NULL,
    [DateCreated] datetime  NOT NULL,
    [ThumbUps] int  NOT NULL,
    [ThumbDowns] int  NOT NULL,
    [Featured] bit  NOT NULL,
    [Price] int  NOT NULL,
    [Qualities] nvarchar(max)  NOT NULL,
    [Downloadables] nvarchar(max)  NOT NULL,
    [Teaser] nvarchar(max)  NOT NULL,
    [FolderName] nvarchar(max)  NOT NULL,
    [Disable] bit  NOT NULL,
    [EditorialRate] float  NOT NULL,
    [Filter] bit  NOT NULL,
    [Thumbnail_Id] int  NOT NULL,
    [Parent_Id] int  NULL
);
GO

-- Creating table 'Images'
CREATE TABLE [dbo].[Images] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Url] nvarchar(max)  NOT NULL,
    [Width] int  NOT NULL,
    [Height] int  NOT NULL
);
GO

-- Creating table 'Homes'
CREATE TABLE [dbo].[Homes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Bundles'
CREATE TABLE [dbo].[Bundles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NULL,
    [CateroryId] nvarchar(max)  NULL,
    [GenreId] nvarchar(max)  NULL,
    [Type] smallint  NOT NULL
);
GO

-- Creating table 'Banners'
CREATE TABLE [dbo].[Banners] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Url] nvarchar(max)  NOT NULL,
    [Width] int  NOT NULL,
    [Height] int  NOT NULL,
    [UrlToClick] nvarchar(max)  NULL,
    [MovieId] int  NULL,
    [CategoryId] int  NULL,
    [GenreId] int  NULL,
    [ListName] nvarchar(max)  NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Genres'
CREATE TABLE [dbo].[Genres] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Agents'
CREATE TABLE [dbo].[Agents] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Bio] nvarchar(max)  NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Movie_Id] int  NOT NULL,
    [Agent_Id] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Msisdn] nvarchar(max)  NOT NULL,
    [Token] uniqueidentifier  NULL,
    [LastLogin] datetime  NULL,
    [Platform] nvarchar(max)  NOT NULL,
    [Code] int  NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [CodeSentTime] datetime  NOT NULL,
    [RetryCodeSent] int  NOT NULL,
    [FailedCodeTry] smallint  NOT NULL
);
GO

-- Creating table 'Comments'
CREATE TABLE [dbo].[Comments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [UserId] int  NOT NULL,
    [Movie_Id] int  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'Rates'
CREATE TABLE [dbo].[Rates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ThumbUp] bit  NOT NULL,
    [ThumbDown] bit  NOT NULL,
    [Movie_Id] int  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'CategoryGenres'
CREATE TABLE [dbo].[CategoryGenres] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Category_Id] int  NOT NULL,
    [Genre_Id] int  NOT NULL
);
GO

-- Creating table 'Purchases'
CREATE TABLE [dbo].[Purchases] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL,
    [MovieId] int  NOT NULL,
    [DateTime] datetime  NOT NULL,
    [Factor_Id] int  NOT NULL
);
GO

-- Creating table 'Factors'
CREATE TABLE [dbo].[Factors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DateTime] datetime  NOT NULL,
    [TransactionId] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL,
    [MovieID] int  NOT NULL,
    [Amount] int  NOT NULL,
    [Result] bit  NOT NULL,
    [CompleteDateTime] datetime  NOT NULL
);
GO

-- Creating table 'Messages'
CREATE TABLE [dbo].[Messages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DateTime] datetime  NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [MediaId] int  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'PanelUsers'
CREATE TABLE [dbo].[PanelUsers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Token] uniqueidentifier  NULL,
    [Role] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Emails'
CREATE TABLE [dbo].[Emails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EmailAddress] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HomeBundle'
CREATE TABLE [dbo].[HomeBundle] (
    [Homes_Id] int  NOT NULL,
    [Bundles_Id] int  NOT NULL
);
GO

-- Creating table 'BundleMovie'
CREATE TABLE [dbo].[BundleMovie] (
    [Bundles_Id] int  NOT NULL,
    [Movies_Id] int  NOT NULL
);
GO

-- Creating table 'BundleBanner'
CREATE TABLE [dbo].[BundleBanner] (
    [Bundles_Id] int  NOT NULL,
    [Banners_Id] int  NOT NULL
);
GO

-- Creating table 'MovieCategory'
CREATE TABLE [dbo].[MovieCategory] (
    [Movies_Id] int  NOT NULL,
    [Categories_Id] int  NOT NULL
);
GO

-- Creating table 'MovieGenre'
CREATE TABLE [dbo].[MovieGenre] (
    [Movies_Id] int  NOT NULL,
    [Genres_Id] int  NOT NULL
);
GO

-- Creating table 'PanelUserMovie'
CREATE TABLE [dbo].[PanelUserMovie] (
    [PanelUsers_Id] int  NOT NULL,
    [Movies_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Movies'
ALTER TABLE [dbo].[Movies]
ADD CONSTRAINT [PK_Movies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [PK_Images]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Homes'
ALTER TABLE [dbo].[Homes]
ADD CONSTRAINT [PK_Homes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Bundles'
ALTER TABLE [dbo].[Bundles]
ADD CONSTRAINT [PK_Bundles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Banners'
ALTER TABLE [dbo].[Banners]
ADD CONSTRAINT [PK_Banners]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Genres'
ALTER TABLE [dbo].[Genres]
ADD CONSTRAINT [PK_Genres]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Agents'
ALTER TABLE [dbo].[Agents]
ADD CONSTRAINT [PK_Agents]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [PK_Comments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Rates'
ALTER TABLE [dbo].[Rates]
ADD CONSTRAINT [PK_Rates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CategoryGenres'
ALTER TABLE [dbo].[CategoryGenres]
ADD CONSTRAINT [PK_CategoryGenres]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Purchases'
ALTER TABLE [dbo].[Purchases]
ADD CONSTRAINT [PK_Purchases]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Factors'
ALTER TABLE [dbo].[Factors]
ADD CONSTRAINT [PK_Factors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [PK_Messages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PanelUsers'
ALTER TABLE [dbo].[PanelUsers]
ADD CONSTRAINT [PK_PanelUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Emails'
ALTER TABLE [dbo].[Emails]
ADD CONSTRAINT [PK_Emails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Homes_Id], [Bundles_Id] in table 'HomeBundle'
ALTER TABLE [dbo].[HomeBundle]
ADD CONSTRAINT [PK_HomeBundle]
    PRIMARY KEY CLUSTERED ([Homes_Id], [Bundles_Id] ASC);
GO

-- Creating primary key on [Bundles_Id], [Movies_Id] in table 'BundleMovie'
ALTER TABLE [dbo].[BundleMovie]
ADD CONSTRAINT [PK_BundleMovie]
    PRIMARY KEY CLUSTERED ([Bundles_Id], [Movies_Id] ASC);
GO

-- Creating primary key on [Bundles_Id], [Banners_Id] in table 'BundleBanner'
ALTER TABLE [dbo].[BundleBanner]
ADD CONSTRAINT [PK_BundleBanner]
    PRIMARY KEY CLUSTERED ([Bundles_Id], [Banners_Id] ASC);
GO

-- Creating primary key on [Movies_Id], [Categories_Id] in table 'MovieCategory'
ALTER TABLE [dbo].[MovieCategory]
ADD CONSTRAINT [PK_MovieCategory]
    PRIMARY KEY CLUSTERED ([Movies_Id], [Categories_Id] ASC);
GO

-- Creating primary key on [Movies_Id], [Genres_Id] in table 'MovieGenre'
ALTER TABLE [dbo].[MovieGenre]
ADD CONSTRAINT [PK_MovieGenre]
    PRIMARY KEY CLUSTERED ([Movies_Id], [Genres_Id] ASC);
GO

-- Creating primary key on [PanelUsers_Id], [Movies_Id] in table 'PanelUserMovie'
ALTER TABLE [dbo].[PanelUserMovie]
ADD CONSTRAINT [PK_PanelUserMovie]
    PRIMARY KEY CLUSTERED ([PanelUsers_Id], [Movies_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Thumbnail_Id] in table 'Movies'
ALTER TABLE [dbo].[Movies]
ADD CONSTRAINT [FK_MovieImage]
    FOREIGN KEY ([Thumbnail_Id])
    REFERENCES [dbo].[Images]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieImage'
CREATE INDEX [IX_FK_MovieImage]
ON [dbo].[Movies]
    ([Thumbnail_Id]);
GO

-- Creating foreign key on [Homes_Id] in table 'HomeBundle'
ALTER TABLE [dbo].[HomeBundle]
ADD CONSTRAINT [FK_HomeBundle_Home]
    FOREIGN KEY ([Homes_Id])
    REFERENCES [dbo].[Homes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Bundles_Id] in table 'HomeBundle'
ALTER TABLE [dbo].[HomeBundle]
ADD CONSTRAINT [FK_HomeBundle_Bundle]
    FOREIGN KEY ([Bundles_Id])
    REFERENCES [dbo].[Bundles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HomeBundle_Bundle'
CREATE INDEX [IX_FK_HomeBundle_Bundle]
ON [dbo].[HomeBundle]
    ([Bundles_Id]);
GO

-- Creating foreign key on [Bundles_Id] in table 'BundleMovie'
ALTER TABLE [dbo].[BundleMovie]
ADD CONSTRAINT [FK_BundleMovie_Bundle]
    FOREIGN KEY ([Bundles_Id])
    REFERENCES [dbo].[Bundles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Movies_Id] in table 'BundleMovie'
ALTER TABLE [dbo].[BundleMovie]
ADD CONSTRAINT [FK_BundleMovie_Movie]
    FOREIGN KEY ([Movies_Id])
    REFERENCES [dbo].[Movies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BundleMovie_Movie'
CREATE INDEX [IX_FK_BundleMovie_Movie]
ON [dbo].[BundleMovie]
    ([Movies_Id]);
GO

-- Creating foreign key on [Bundles_Id] in table 'BundleBanner'
ALTER TABLE [dbo].[BundleBanner]
ADD CONSTRAINT [FK_BundleBanner_Bundle]
    FOREIGN KEY ([Bundles_Id])
    REFERENCES [dbo].[Bundles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Banners_Id] in table 'BundleBanner'
ALTER TABLE [dbo].[BundleBanner]
ADD CONSTRAINT [FK_BundleBanner_Banner]
    FOREIGN KEY ([Banners_Id])
    REFERENCES [dbo].[Banners]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BundleBanner_Banner'
CREATE INDEX [IX_FK_BundleBanner_Banner]
ON [dbo].[BundleBanner]
    ([Banners_Id]);
GO

-- Creating foreign key on [Movies_Id] in table 'MovieCategory'
ALTER TABLE [dbo].[MovieCategory]
ADD CONSTRAINT [FK_MovieCategory_Movie]
    FOREIGN KEY ([Movies_Id])
    REFERENCES [dbo].[Movies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Categories_Id] in table 'MovieCategory'
ALTER TABLE [dbo].[MovieCategory]
ADD CONSTRAINT [FK_MovieCategory_Category]
    FOREIGN KEY ([Categories_Id])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieCategory_Category'
CREATE INDEX [IX_FK_MovieCategory_Category]
ON [dbo].[MovieCategory]
    ([Categories_Id]);
GO

-- Creating foreign key on [Movies_Id] in table 'MovieGenre'
ALTER TABLE [dbo].[MovieGenre]
ADD CONSTRAINT [FK_MovieGenre_Movie]
    FOREIGN KEY ([Movies_Id])
    REFERENCES [dbo].[Movies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Genres_Id] in table 'MovieGenre'
ALTER TABLE [dbo].[MovieGenre]
ADD CONSTRAINT [FK_MovieGenre_Genre]
    FOREIGN KEY ([Genres_Id])
    REFERENCES [dbo].[Genres]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieGenre_Genre'
CREATE INDEX [IX_FK_MovieGenre_Genre]
ON [dbo].[MovieGenre]
    ([Genres_Id]);
GO

-- Creating foreign key on [Movie_Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [FK_RoleMovie]
    FOREIGN KEY ([Movie_Id])
    REFERENCES [dbo].[Movies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleMovie'
CREATE INDEX [IX_FK_RoleMovie]
ON [dbo].[Roles]
    ([Movie_Id]);
GO

-- Creating foreign key on [Agent_Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [FK_RoleAgent]
    FOREIGN KEY ([Agent_Id])
    REFERENCES [dbo].[Agents]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleAgent'
CREATE INDEX [IX_FK_RoleAgent]
ON [dbo].[Roles]
    ([Agent_Id]);
GO

-- Creating foreign key on [Movie_Id] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [FK_CommentMovie]
    FOREIGN KEY ([Movie_Id])
    REFERENCES [dbo].[Movies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommentMovie'
CREATE INDEX [IX_FK_CommentMovie]
ON [dbo].[Comments]
    ([Movie_Id]);
GO

-- Creating foreign key on [Movie_Id] in table 'Rates'
ALTER TABLE [dbo].[Rates]
ADD CONSTRAINT [FK_RateMovie]
    FOREIGN KEY ([Movie_Id])
    REFERENCES [dbo].[Movies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RateMovie'
CREATE INDEX [IX_FK_RateMovie]
ON [dbo].[Rates]
    ([Movie_Id]);
GO

-- Creating foreign key on [User_Id] in table 'Rates'
ALTER TABLE [dbo].[Rates]
ADD CONSTRAINT [FK_RateUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RateUser'
CREATE INDEX [IX_FK_RateUser]
ON [dbo].[Rates]
    ([User_Id]);
GO

-- Creating foreign key on [Category_Id] in table 'CategoryGenres'
ALTER TABLE [dbo].[CategoryGenres]
ADD CONSTRAINT [FK_CategoryGenreCategory]
    FOREIGN KEY ([Category_Id])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryGenreCategory'
CREATE INDEX [IX_FK_CategoryGenreCategory]
ON [dbo].[CategoryGenres]
    ([Category_Id]);
GO

-- Creating foreign key on [Genre_Id] in table 'CategoryGenres'
ALTER TABLE [dbo].[CategoryGenres]
ADD CONSTRAINT [FK_CategoryGenreGenre]
    FOREIGN KEY ([Genre_Id])
    REFERENCES [dbo].[Genres]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryGenreGenre'
CREATE INDEX [IX_FK_CategoryGenreGenre]
ON [dbo].[CategoryGenres]
    ([Genre_Id]);
GO

-- Creating foreign key on [UserId] in table 'Purchases'
ALTER TABLE [dbo].[Purchases]
ADD CONSTRAINT [FK_PurchaseUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PurchaseUser'
CREATE INDEX [IX_FK_PurchaseUser]
ON [dbo].[Purchases]
    ([UserId]);
GO

-- Creating foreign key on [MovieId] in table 'Purchases'
ALTER TABLE [dbo].[Purchases]
ADD CONSTRAINT [FK_PurchaseMovie]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PurchaseMovie'
CREATE INDEX [IX_FK_PurchaseMovie]
ON [dbo].[Purchases]
    ([MovieId]);
GO

-- Creating foreign key on [UserId] in table 'Factors'
ALTER TABLE [dbo].[Factors]
ADD CONSTRAINT [FK_UserFactor]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserFactor'
CREATE INDEX [IX_FK_UserFactor]
ON [dbo].[Factors]
    ([UserId]);
GO

-- Creating foreign key on [Factor_Id] in table 'Purchases'
ALTER TABLE [dbo].[Purchases]
ADD CONSTRAINT [FK_FactorPurchase]
    FOREIGN KEY ([Factor_Id])
    REFERENCES [dbo].[Factors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FactorPurchase'
CREATE INDEX [IX_FK_FactorPurchase]
ON [dbo].[Purchases]
    ([Factor_Id]);
GO

-- Creating foreign key on [UserId] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [FK_MessageUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MessageUser'
CREATE INDEX [IX_FK_MessageUser]
ON [dbo].[Messages]
    ([UserId]);
GO

-- Creating foreign key on [User_Id] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [FK_UserComment]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserComment'
CREATE INDEX [IX_FK_UserComment]
ON [dbo].[Comments]
    ([User_Id]);
GO

-- Creating foreign key on [PanelUsers_Id] in table 'PanelUserMovie'
ALTER TABLE [dbo].[PanelUserMovie]
ADD CONSTRAINT [FK_PanelUserMovie_PanelUser]
    FOREIGN KEY ([PanelUsers_Id])
    REFERENCES [dbo].[PanelUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Movies_Id] in table 'PanelUserMovie'
ALTER TABLE [dbo].[PanelUserMovie]
ADD CONSTRAINT [FK_PanelUserMovie_Movie]
    FOREIGN KEY ([Movies_Id])
    REFERENCES [dbo].[Movies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PanelUserMovie_Movie'
CREATE INDEX [IX_FK_PanelUserMovie_Movie]
ON [dbo].[PanelUserMovie]
    ([Movies_Id]);
GO

-- Creating foreign key on [Parent_Id] in table 'Movies'
ALTER TABLE [dbo].[Movies]
ADD CONSTRAINT [FK_MovieMovie]
    FOREIGN KEY ([Parent_Id])
    REFERENCES [dbo].[Movies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieMovie'
CREATE INDEX [IX_FK_MovieMovie]
ON [dbo].[Movies]
    ([Parent_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------