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
 CONSTRAINT [PK_Businesses] PRIMARY KEY CLUSTERED   
(  
    [ID] ASC  
)
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
    @AddressLatitude varchar(20)  
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
	AddressLatitude)  
values(	
	@CompanyName,
	@RegistrationNumber,
	@Category,
	@NumEmployees,
	@Address,
	@AddressTown,
	@AddressLongitude,
	@AddressLatitude)  
END 

GO
CREATE PROCEDURE [dbo].[spGetAllBusinesses] 
AS  
BEGIN  
	RETURN SELECT * FROM [dbo].[Businesses]
END 