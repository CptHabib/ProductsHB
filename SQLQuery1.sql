alter proc GET_ALL_PRODUCTS
as


SELECT [ID_PRODUCT] as '��� ������'
      ,[LABEL_PRODUCT] as '��� ������'
      ,[QTE_IN_STOCK] as '������'
      ,[PRICE] as '�����'
      ,DESCRIPTION_CAT as '�����'
  FROM [Product_DB].[dbo].[PRODUCTS]
  inner join CATEGORIES
  on CATEGORIES.ID_CAT=PRODUCTS.ID_CAT