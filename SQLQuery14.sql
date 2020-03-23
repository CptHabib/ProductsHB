create proc EDIT_CUSTOME
@FIRST_NAME varchar(25),
@LAST_NAME varchar(25),
@TEL varchar(15),
@ID int
as
UPDATE [CUSTOMERS]
   SET [FIRST_NAME] = @FIRST_NAME
      ,[LAST_NAME] = @LAST_NAME
      ,[TEL] = @TEL
 WHERE ID_CUSTOMER=@ID


