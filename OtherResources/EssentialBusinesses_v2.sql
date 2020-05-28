/* Possible improvements: 
	1.create a separate table for towns and store town IDs instead
	2.necessity of member IDs (not stored) 
	3.create a separate table for categories and store category IDs instead*/

DROP DATABASE IF EXISTS "EssentialBusinesses";
CREATE DATABASE EssentialBusinesses;
GO

USE EssentialBusinesses;

DROP TABLE IF EXISTS [dbo].[Businesses];
CREATE TABLE [dbo].[Businesses](  
    [ID] [int] IDENTITY(1,1) NOT NULL, 
    [CompanyName] [varchar](100) NOT NULL,
    [RegistrationNumber] [varchar](100) NOT NULL,
    [Category] [varchar](100) NOT NULL,
    [NumEmployees] [int] NOT NULL,
    [Address] [varchar](255) NOT NULL,
   	[AddressTown] [varchar](100) NOT NULL,
    [AddressLongitude] [varchar](20) NOT NULL,
    [AddressLatitude] [varchar](20) NOT NULL,
	[RequestStatus] [varchar](20) NOT NULL,
	[UserId] [varchar](100) NOT NULL,   
 CONSTRAINT [PK_Businesses] PRIMARY KEY CLUSTERED   
(  
    [ID] ASC  
)
) ON [PRIMARY]   
GO  

DROP TABLE IF EXISTS [dbo].[Users];
CREATE TABLE [dbo].[Users](  
    [ID] [int] IDENTITY(1,1) NOT NULL, 
	[UserId] [varchar](100) NOT NULL, 
	[Type] [varchar](20) NOT NULL,  
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([ID] ASC)
) ON [PRIMARY]  
GO  
  

DROP PROCEDURE IF EXISTS [dbo].[spAddNewBusiness];  
GO
CREATE PROCEDURE [dbo].[spAddNewBusiness]  
(  
    @CompanyName varchar(100),
    @RegistrationNumber varchar(100),
    @Category varchar(100),
    @NumEmployees int,
    @Address varchar(255),
   	@AddressTown varchar(100),
    @AddressLongitude varchar(20),
    @AddressLatitude varchar(20),
	@RequestStatus varchar(20),
	@UserId varchar(100)  
)  
AS  
BEGIN  
INSERT INTO [dbo].[Businesses](
	CompanyName,
	RegistrationNumber,
	Category,
	NumEmployees,
	Address,
	AddressTown,
	AddressLongitude,
	AddressLatitude,
	RequestStatus,
	UserId)
VALUES(	
	@CompanyName,
	@RegistrationNumber,
	@Category,
	@NumEmployees,
	@Address,
	@AddressTown,
	@AddressLongitude,
	@AddressLatitude,
	@RequestStatus,
	@UserId)  
END 
GO

DROP PROCEDURE IF EXISTS [dbo].[spGetAllBusinesses];  
GO
CREATE PROCEDURE [dbo].[spGetAllBusinesses] 
AS  
BEGIN  
	SELECT CompanyName, RegistrationNumber, Category, NumEmployees, Address, AddressTown, AddressLongitude, AddressLatitude, RequestStatus, UserId FROM [dbo].[Businesses]
END
GO

DROP PROCEDURE IF EXISTS [dbo].[spGetAllBusinessesPending];  
GO
CREATE PROCEDURE [dbo].[spGetAllBusinessesPending] 
AS  
BEGIN  
	SELECT CompanyName, RegistrationNumber, Category, NumEmployees, Address, AddressTown, AddressLongitude, AddressLatitude, RequestStatus, UserId FROM [dbo].[Businesses]
	WHERE RequestStatus = 'Pending'
END
GO

DROP PROCEDURE IF EXISTS [dbo].[spGetBusinessesByUser]; 
GO
CREATE PROCEDURE [dbo].[spGetBusinessesByUser] 
(
	@UserId varchar(100) 
)
AS  
BEGIN  
	SELECT CompanyName, RegistrationNumber, Category, NumEmployees, Address, AddressTown, AddressLongitude, AddressLatitude, RequestStatus, UserId FROM [dbo].[Businesses]
	WHERE UserId = @UserId
END 
GO

DROP PROCEDURE IF EXISTS [dbo].[spChangeBusinessRequestStatus]; 
GO
CREATE PROCEDURE [dbo].[spChangeBusinessRequestStatus] 
(
	@RegistrationNumber varchar(100),
	@RequestStatus varchar(20)
)
AS  
BEGIN  
	UPDATE [dbo].[Businesses]
	SET RequestStatus = @RequestStatus
	WHERE RegistrationNumber = @RegistrationNumber
END 
GO

DROP PROCEDURE IF EXISTS [dbo].[spRemoveBusiness]; 
GO
CREATE PROCEDURE [dbo].[spRemoveBusiness] 
(
	@RegistrationNumber varchar(100)
)
AS  
BEGIN  
	DELETE [dbo].[Businesses]
	WHERE RegistrationNumber = @RegistrationNumber
END 
GO

DROP PROCEDURE IF EXISTS [dbo].[spAddNewUser]; 
GO
CREATE PROCEDURE [dbo].[spAddNewUser] 
(
	@UserId varchar(100), 
	@Type varchar(20)
)
AS  
BEGIN  
	INSERT INTO [dbo].[Users](UserId, Type) VALUES(@UserId, @Type)  
END 
GO

DROP PROCEDURE IF EXISTS [dbo].[spGetAllUsers]; 
GO
CREATE PROCEDURE [dbo].[spGetAllUsers] 
(
	@UserId varchar(100), 
	@Type varchar(20)
)
AS  
BEGIN  
	SELECT UserId, Type FROM [dbo].[Users]
END 
GO

DROP PROCEDURE IF EXISTS [dbo].[spUserTypeById];  
GO
CREATE PROCEDURE [dbo].[spUserTypeById] 
(
	@UserId varchar(100) 
)
AS  
BEGIN  
	SELECT Type FROM [dbo].[Users]
	WHERE UserId = @UserId
END 
GO

DROP PROCEDURE IF EXISTS [dbo].[spRemoveAdmin];  
GO
CREATE PROCEDURE [dbo].[spRemoveAdmin] 
(
	@UserId varchar(100) 
)
AS  
BEGIN  
	UPDATE [dbo].[Users]
	SET Type = 'Standard'
	WHERE UserId = @UserId
END 
GO

DROP PROCEDURE IF EXISTS [dbo].[spSearchOpenBusinesses];  
GO
CREATE PROCEDURE [dbo].[spSearchOpenBusinesses]
	@lat float,   
    @lng float,
	@radius int,
	@businessCategory varchar(60)
AS 
DECLARE @userLocation geography = geography::Point(@lat, @lng, 4326);

BEGIN  
	SELECT b.CompanyName, b.Address, b.AddressLongitude, b.AddressLatitude
	FROM [dbo].[Businesses] b
	WHERE ((@userLocation.STDistance(geography::Point(b.AddressLatitude, b.AddressLongitude, '4326'))) < @radius) AND b.Category = @businessCategory AND b.RequestStatus = 'Approved'
END 
GO
