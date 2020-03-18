create proc GET_PRODUCT_IMAGE
@ID varchar(50)
as
select IMAGE_PRODUCT from PRODUCTS
where ID_PRODUCT=@ID