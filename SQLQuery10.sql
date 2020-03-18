create proc GET_SINGLE_PRODUCT
@ID varchar(30)
as


SELECT [ID_PRODUCT]
      ,[LABEL_PRODUCT]
      ,[QTE_IN_STOCK]
      ,[PRICE]
      ,[IMAGE_PRODUCT]
      ,DESCRIPTION_CAT
  FROM [Product_DB].[dbo].[PRODUCTS]
  inner join CATEGORIES
  on CATEGORIES.ID_CAT=PRODUCTS.ID_CAT
  where ID_PRODUCT=@ID
