create proc ADD_PRODUCT
@ID_CAT int,@ID_PRODUCT varchar(30),@LABEL_PRODUCT varchar(30),@QTE_IN_STACK int,@PRICE varchar(50),@IMAGE_PRODUCT image

as
 

INSERT INTO [Product_DB].[dbo].[PRODUCTS]
           ([ID_PRODUCT]
           ,[LABEL_PRODUCT]
           ,[QTE_IN_STOCK]
           ,[PRICE]
           ,[IMAGE_PRODUCT]
           ,[ID_CAT])
     VALUES
           (@ID_PRODUCT
           ,@LABEL_PRODUCT
           ,@QTE_IN_STACK
           ,@PRICE
           ,@IMAGE_PRODUCT
           ,@ID_CAT)



