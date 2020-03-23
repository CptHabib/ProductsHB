create proc GET_LAST_ORDER_ID
as 
select ISNULL(max(id_order)+1,1) from ORDERS
