CREATE PROC SP_LOGIN
@ID varchar(50) , @PWD varchar(50)

AS

select * from TBL_USERS
where ID=@ID and PWD=@PWD