create proc UPDATE_PRODUCTS
@ID_CAT int,
@ID_PRODUCT varchar(30),
@LABEL_PRODUCT varchar(30),
@QTE_IN_STACK int,
@PRICE varchar(50),
@IMAGE_PRODUCT image
as
UPDATE [Product_DB].[dbo].[PRODUCTS]
   SET [LABEL_PRODUCT] = @LABEL_PRODUCT
      ,[QTE_IN_STOCK] = @QTE_IN_STACK
      ,[PRICE] = @PRICE
      ,[IMAGE_PRODUCT] = @IMAGE_PRODUCT
      ,[ID_CAT] = @ID_CAT
 WHERE [ID_PRODUCT] = @ID_PRODUCT


