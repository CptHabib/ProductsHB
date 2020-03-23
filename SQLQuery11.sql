create proc GET_SINGLE_CATEGORY
@id int
as
select id_cat , DESCRIPTION_CAT from CATEGORIES
where id_cat=@id