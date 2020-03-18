create proc SearchProduct
@ID varchar(50)
as
SELECT [ID_PRODUCT] as '��� ������'
      ,[LABEL_PRODUCT] as '��� ������'
      ,[QTE_IN_STOCK] as '������'
      ,[PRICE] as '�����'
      ,DESCRIPTION_CAT as '�����'
  FROM [Product_DB].[dbo].[PRODUCTS]
  inner join CATEGORIES
  on CATEGORIES.ID_CAT=PRODUCTS.ID_CAT
  where
  [ID_PRODUCT]+
  [LABEL_PRODUCT]+
  convert(varchar,[QTE_IN_STOCK])+
  [PRICE]+
  DESCRIPTION_CAT
  like '%'+@ID+'%' 