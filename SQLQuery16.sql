create proc SEARCH_CUSTOMER
@c varchar(50)
as
SELECT [ID_CUSTOMER]
      ,[FIRST_NAME] as '��� ������'
      ,[LAST_NAME] as '��� �������'
      ,[TEL] as '��� ������'
  FROM [CUSTOMERS]
  where [FIRST_NAME]+[LAST_NAME]+[TEL] like '%'+@c+'%'