create proc VerifyProductID1
@ID varchar(50)
as
select * from PRODUCTS
where ID_PRODUCT=@ID