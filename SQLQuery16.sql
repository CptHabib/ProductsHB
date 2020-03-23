create proc SEARCH_CUSTOMER
@c varchar(50)
as
SELECT [ID_CUSTOMER]
      ,[FIRST_NAME] as '«”„ «·‘Œ’Ì'
      ,[LAST_NAME] as '«”„ «·⁄«∆·…'
      ,[TEL] as '—ﬁ„ «·Â« ›'
  FROM [CUSTOMERS]
  where [FIRST_NAME]+[LAST_NAME]+[TEL] like '%'+@c+'%'