create proc DeleteProduct
@ID varchar(50)
as
delete from PRODUCTS where ID_PRODUCT=@ID