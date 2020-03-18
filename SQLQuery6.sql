create proc SearchProduct
@ID varchar(50)
as
SELECT [ID_PRODUCT] as '—ﬁ„ «·„‰ Ã'
      ,[LABEL_PRODUCT] as 'Ê’› «·„‰ Ã'
      ,[QTE_IN_STOCK] as '«·ﬂ„Ì…'
      ,[PRICE] as '«·À„‰'
      ,DESCRIPTION_CAT as '«·’‰›'
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