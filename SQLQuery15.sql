create proc DEL_CUSTOMER
@ID int
as
delete from CUSTOMERS
where ID_CUSTOMER=@ID