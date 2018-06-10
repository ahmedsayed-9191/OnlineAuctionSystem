--- Queries

Select * from [Admin]
Select * from Seller
Select * from Bidder
Select * from AuctionSession
Select * from SessionStatus
Select * from Item  
select * from Bid
select * from Invoice






-----------------------------------------
--____Stored Procedure____
--Note
--drop proc  SP_Result
--1--
-- Procedure Login
------------------------------------------
CREATE PROC SP_Login
@UserName varchar(50)  ,@Password varchar(50) ,@UserType varchar(50)
as
DECLARE @SQL nvarchar(max);
SET @SQL = 'select * from ' + @UserType + ' where UserName = ' + ''''+ cast (@UserName as varchar(50) )+'''' +'AND Password =' + '''' +cast (@Password as varchar(50) )+''''
EXEC (@SQL)

exec SP_Login 'admin' ,'admin' ,'Admin'
-------------------------------------------

--2--
--Procedure Register and Add Admin
CREATE PROC SP_REGISTER_ADD_ADMIN
@UserName varchar(50)  ,@Password varchar(50) ,@Email varchar(70)  ,@Address varchar(100) , @Mobile varchar(50),@UserType varchar(50)
as
DECLARE @SQL nvarchar(max);
SET @SQL = ' INSERT INTO ' + @UserType + '
				   ([UserName]
				   ,[Password]
				   ,[Email]
				   ,[Address]
				   ,[Mobile])
             VALUES
				   ('+''''+@UserName+''''+'
				   , '+''''+@Password+''''+'
				   , '+''''+@Email+''''+'
				   , '+''''+@Address+''''+'
				   , '+''''+@Mobile+''''+'    )'
EXEC(@SQL)

exec SP_REGISTER_ADD_ADMIN 'admin2' ,'admin2','admin2@yahoo.com','cairo','011003366998','Admin'
--------------------------------------------------------


-- Alter table and unique its column
ALTER TABLE AuctionSession
ADD UNIQUE (Name);

ALTER TABLE Seller
ADD UNIQUE (UserName);

----------------------------------------------------------------------------------------------

--3--
-- procedure to check username existence
CREATE PROC SP_IsUserName_ExistInAdmin
@username varchar(50)
as
select * from [Admin] where UserName = @username

CREATE PROC SP_IsUserName_ExistInBidder
@username varchar(50)
as
select * from [Bidder] where UserName = @username

CREATE PROC SP_IsUserName_ExistInSeller
@username varchar(50)
as
select * from [Seller] where UserName = @username


exec SP_IsUserName_ExistInAdmin 'admin'
---------------------------------------------------------------------------------------------------

--4--
-- procedure to check Email existence
CREATE PROC SP_IsEmail_ExistInAdmin
@Email varchar(70)
as
select * from [Admin] where Email = @Email

CREATE PROC SP_IsEmail_ExistInBidder
@Email varchar(70)
as
select * from [Bidder] where Email = @Email

CREATE PROC SP_IsEmail_ExistInSeller
@Email varchar(70)
as
select * from [Seller] where Email = @Email

----------------------------------------------------------------------------------------------------

--5--
-- procedure to check Mobile existence
CREATE PROC SP_IsMobile_ExistInAdmin
@Mobile varchar(50)
as
select * from [Admin] where Mobile = @Mobile

CREATE PROC SP_IsMobile_ExistInBidder
@Mobile varchar(50)
as
select * from [Bidder] where Mobile = @Mobile

CREATE PROC SP_IsMobile_ExistInSeller
@Mobile varchar(50)
as
select * from [Seller] where Mobile = @Mobile
--------------------------------------------------------------------------------------------------

--6--
-- procedure to Update User Profile
CREATE PROC SP_UPDATE_PROFILE
@Username varchar(50) ,@Password varchar(50) ,@Email varchar(70)  ,@Address varchar(100) , @Mobile varchar(50),@UserType varchar(50)
AS
DECLARE @SQL nvarchar(max);
SET @SQL = ' UPDATE ' + @UserType + ' 
			
			 SET   [Password] = '+''''+@Password+''''+'
				  ,[Email] =    '+''''+@Email+''''+'
				  ,[Address] =  '+''''+@Address+''''+'
				  ,[Mobile] =   '+''''+@Mobile+''''+' 
			
			 WHERE UserName ='+''''+@UserName+''''+'     '
EXEC(@SQL)
-----
exec  SP_UPDATE_PROFILE @Username= 'hassan' , @Password= '12345' , @Email ='hassanhesham@yahoo.com' , @Address ='awsim giza egypt' , @Mobile ='01027871563', @UserType = 'Admin'
-------------------------------------------------------------------------------

--7--
-- Procedure to retrieve all Users
CREATE PROC  SP_ViewUsers 
@Criterion varchar(50)  , @UserType varchar(50)
As
DECLARE @SQL nvarchar(max);
set @SQL = '
			SELECT [UserName]
				  ,[Password]
				  ,[Email]
				  ,[Address]
				  ,[Mobile]
			  FROM ['+@UserType+'] 
			  WHERE UserName+[Password]+Email+[Address]+Mobile like  ''%'' + '+''''+@Criterion+''''+' + ''%'' 
			  '
EXEC(@SQL)

exec SP_ViewUsers 'seller3' , 'Seller'
-----------------------------------------------------------------------------------------------------

--8--
--Procedure to delete user
CREATE PROC SP_DeleteUser 
@UserName varchar(50) , @UserType varchar(50)
As
DECLARE @SQL nvarchar(max);
set @SQL = '
			DELETE FROM   ['+@UserType+'] 
			WHERE UserName =  '+''''+@UserName+''''+'   '

EXEC(@SQL)

exec SP_DeleteUser 'seller3' ,'Seller'

-------------------------------------------------------------------------------------------------------


--9--
-- procedure to create Session
CREATE PROC SP_Create_Session
@Name varchar(50)
as
Insert Into AuctionSession (Name , Status_ID) values (@Name,1)

exec SP_Create_Session 'session2'
-----------------------------------------------------------------

--10--
-- Procedure to check Session Name Existence
CREATE PROC SP_IS_SessionNameExist
@Name Varchar(50)
as
Select * from AuctionSession where Name = @Name

exec SP_IS_SessionNameExist 'session1'
-----------------------------------------------------------------

--11--
-- Procedure to retrieve Sessions for Admin
CREATE PROC SP_ViewSessionAdmin
@Criterion varchar(50)  , @Status int
as
select ID , Name from AuctionSession 
WHERE Name like  '%' + @Criterion +'%' And Status_ID = @Status


exec SP_ViewSessionAdmin '' , 1
-----------------------------------------------------------

--12--
-- Procedure to retrieve Available Sessions for Seller
CREATE PROC SP_ViewAvailableSessionsSeller
@Criterion varchar(50)
as
select ID as 'Session Number' , Name as 'Session Name' from AuctionSession 
WHERE Name like  '%' + @Criterion +'%' And Status_ID = 1


--13--
--Procedure to Subscribe Session

CREATE PROC SP_SubscribeSession
@Session_ID int , @Seller_ID int
as
UPDATE [dbo].[AuctionSession]  SET [Status_ID] = 2 ,[Seller_ID] = @Seller_ID
WHERE ID = @Session_ID 

---------------------------------------------------------------------------------------
--14--
-- Procedure to retrieve Subscribed Sessions for Seller

CREATE PROC SP_View_Subscribed_Session_Seller
@Criterion varchar(50) ,  @Seller_ID int
as
select ID as 'Session Number' , Name as 'Session Name' from AuctionSession 
WHERE Name like  '%' + @Criterion +'%' And Status_ID = 2 And Seller_ID = @Seller_ID


---------------------------------------------------------------------------------------
--15--
--Stored  Procedure to Select Max Item ID 
CREATE PROC SP_SelectMaxItemId
As
Select Max(ID) as 'ID'  from Item


exec SP_SelectMaxItemId

-----------------------------------------------------------------------------------------
--16--
--Stored Procedure To Add Item 
CREATE PROC SP_AddItem
@Name varchar(50) , @Description varchar(200) , @Image Image , @Initial_Price float , @Seller_ID int , @ID int , @Session_ID int  
AS
Begin

INSERT INTO [dbo].[Item] ([Name] , [Description] ,[Image] ,[Initial_Price] ,[Seller_ID])
       VALUES( @Name, @Description , @Image , @Initial_Price , @Seller_ID )

UPDATE [dbo].[AuctionSession]  SET [Item_Id] = @ID , FinalPrice = @Initial_Price
WHERE ID = @Session_ID 

End
--------------------------------------------------------------------------------------

--17--
-- Procedue to Check  Session Contain Item Or Not
CREATE PROC SP_ChekSessionNotContainItem
@Session_Id int
As
select * from AuctionSession where ID = @Session_Id And Item_Id Is NULL 

exec SP_ChekSessionNotContainItem 3
-------------------------------------------------------------------------------------

--18--
-- Procedure to retrieve started Sessions and monitor bidding for Seller
CREATE PROC SP_View_Started_Session_Seller
@Criterion varchar(50) ,  @Seller_ID int
as
select A.ID as 'Session Number' , A.Name as 'Session Name' , I.Name as 'Item Name' , A.FinalPrice as 'Last Bid'  From  AuctionSession as A Join Item as I on A.Item_Id = I.ID 
WHERE A.Name like  '%' + @Criterion +'%' And A.Status_ID = 3 And A.Seller_ID = @Seller_ID

exec SP_View_Started_Session_Seller '' , 1
---------------------------------------------------------------------------------------------------------

--19--
-- Procedure to retrieve Auction Session Details But not Started yet
CREATE  PROC SP_View_Session_Details
@Session_Id int
As
select A.ID , A.Name Session_Name  , S.UserName Seller_Name ,I.Name Item_Name ,I.[Description] ,I.Image , I.Initial_Price
from AuctionSession as A join Seller as S on A.Seller_ID = S.ID join Item as I on A.Item_Id = I.ID  
where A.ID = @Session_Id	And A.Status_ID =2		

exec SP_View_Session_Details 1
--------------------------------------------------------------------------------------------------------

--20-- 
-- Procedure to Start Session admin
CREATE PROC SP_StartSession
@Session_ID int
as
UPDATE [dbo].[AuctionSession]  SET [Status_ID] = 3
WHERE ID = @Session_ID 

------------------------------------------------------------------------------------------------------

--21--
--Procedure to  Retreive Started Session (Notification) for Bidder
CREATE PROC SP_View_Started_Session_Bidder
as
select ID as 'Session Number' , Name as 'Session Name' From AuctionSession  
WHERE Status_ID = 3 

exec SP_View_Started_Session_Bidder 	

--------------------------------------------------------------------------------------------------------		

--22--
--Procedure to View Session Details for Bidder
CREATE PROC SP_View_Session_Details_Bidder
@sessionID int 
As
select I.Name , I.Description ,I.Image , A.FinalPrice from  AuctionSession A Join Item I on A.Item_Id= I.ID
where A.ID =@sessionID 

--------------------------------------------------------------------

--23-- 
-- Procedure To Submit Bid Bidder
CREATE PROC SP_SubmitBid
@sessionID int , @bidderID int , @BidValue float
As
Begin

INSERT INTO [Bid]  ([SessionID],[BidderID],[BidValue])  VALUES ( @sessionID , @bidderID , @BidValue)

UPDATE AuctionSession set FinalPrice = @BidValue where ID =@sessionID
       
end 

--24--
-- Procedure to Check Last Bidder Make A bid on A Session
CREATE PROC SP_LastBidder
@Session_Id int 
as 
select BidderID from Bid
where SessionID = @Session_Id and BidValue = (Select MAX(BidValue) from bid where SessionID = @Session_Id)

------------------------------------------------------------------------------------------------


--25--
--procedure to view bid details
CREATE PROC SP_ViewBid_Details
@sessionID int
as
select I.Name , I.Description ,I.Image ,A.FinalPrice from AuctionSession A join Item I on A.Item_Id = I.ID where A.ID = @sessionID

--------------------------------------------------------------------------

--26-- 
-- Procedure to End Session admin
CREATE PROC SP_EndSession
@Session_ID int
as
Begin
--Change Status
UPDATE [dbo].[AuctionSession]  SET [Status_ID] = 4
WHERE ID = @Session_ID 

--Insert Invoice 
DECLARE @BidderID int ;

set @BidderID = (Select B.BidderID from Bid B where B.SessionID = @Session_ID
    And  B.BidValue =(Select MAX(BidValue) from Bid where SessionID = @Session_ID)  )

INSERT INTO [dbo].[Invoice]([date],[SessionID],[BidderID]) VALUES  (GETDATE() , @Session_ID , @BidderID )

End
----------------------------------------------------------------------------

--27--
-- Procedure to retrieve started Sessions and monitor bidding for Seller
CREATE PROC SP_View_Session_Result_Seller
@Criterion varchar(50) ,  @Seller_ID int
as
select A.ID as 'Session Number' , A.Name as 'Session Name' , I.Name as 'Item Name' , A.FinalPrice as 'Final Price'  From  AuctionSession as A Join Item as I on A.Item_Id = I.ID 
WHERE A.Name like  '%' + @Criterion +'%' And A.Status_ID = 4  And A.Seller_ID = @Seller_ID



--28--
--Procedure to Get Report 
CREATE PROC SP_GetReport
as
select A.ID as 'Session Number' , A.Name 'Session Name' , S.UserName as 'Seller Name' ,
I.Name as 'Item Name' , I.Description as 'Item Description' , A.FinalPrice  ,B.UserName as 'Bidder Name'
From  Invoice Join AuctionSession A on SessionID = A.ID  join Bidder B on BidderID = B.ID
Join Item I on A.Item_Id = I.ID Join Seller S on S.ID = A.Seller_ID



--29-- 
--Procedure  to View Auction Result Bidder
CREATE PROC SP_Result 
As
Select A.ID as 'Session Number' , A.Name as 'Session Name' ,B.UserName as 'Winner Name' ,A.FinalPrice as 'Final Price'
From Invoice I Join Bidder B on I.BidderID = B.ID  Join AuctionSession A on I.SessionID = A.ID order by I.ID desc

CREATE PROC SP_ResultWinner
@bidderID int 
As
Select A.ID as 'Session Number' , A.Name as 'Session Name' , A.FinalPrice as 'Final Price'
From Invoice I  Join AuctionSession A on I.SessionID = A.ID where I.BidderID = @bidderID and I.Status=1
order by I.ID desc



--30--
--procedure to pay (Change status to 2 )
CREATE PROC SP_pay
@sessionID int 
as
Update  Invoice set Invoice.Status = 2 where SessionID =@sessionID

--31--
-- Procedure To Get Ivoice 
CREATE PROC SP_GetInvoice
@sessionID int
as
select I.ID as 'Inovice Number' ,
  S.UserName as 'Seller Name'   ,
  B.UserName as 'Bidder Name'   , 
  Item.Name as 'Item Name'      ,
  Item.Description 'Item Description',
  A.FinalPrice as 'Price' ,
  I.date as 'Date'

from Invoice I join AuctionSession A on I.SessionID = A.ID join Item on Item.ID = A.Item_Id
join Bidder B on I.BidderID = B.ID Join Seller S on S.ID = A.Seller_ID
where SessionID = @sessionID


--32--
--Procedure to Check Invoice Recived Or Not 
CREATE PROC SP_CheckInvoice
@sessionID int
as
select * from Invoice where SessionID = @sessionID and Status = 2


/*
truncate table [Admin] 
truncate table [Invoice] 
truncate table [Bid]  
truncate table [Seller]
truncate table [Bidder]
truncate table [Item]
truncate table [AuctionSession]
truncate table [SessionStatus]
*/