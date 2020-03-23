create proc ADD_CUSTOMER
@FIRST_NAME varchar(25),
@LAST_NAME varchar(25),
@TEL varchar(15)
as
INSERT INTO [CUSTOMERS]
           ([FIRST_NAME]
           ,[LAST_NAME]
           ,[TEL])
     VALUES
           (@FIRST_NAME
           ,@LAST_NAME
           ,@TEL)
