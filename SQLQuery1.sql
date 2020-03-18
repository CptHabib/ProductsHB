alter proc GET_ALL_PRODUCTS
as


SELECT [ID_PRODUCT] as '—ﬁ„ «·„‰ Ã'
      ,[LABEL_PRODUCT] as 'Ê’› «·„‰ Ã'
      ,[QTE_IN_STOCK] as '«·ﬂ„Ì…'
      ,[PRICE] as '«·À„‰'
      ,DESCRIPTION_CAT as '«·’‰›'
  FROM [Product_DB].[dbo].[PRODUCTS]
  inner join CATEGORIES
  on CATEGORIES.ID_CAT=PRODUCTS.ID_CAT