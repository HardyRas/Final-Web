CREATE Procedure [dbo].[InsertData]
(
@months date,
@rainfall float, 
@temperature int, 
@al6 int, 
@al12 int,
@al18 int, 
@al24 int,
@wardid varchar(50)
)
as
begin

insert into IkeregeWard
(months, 
rainfall, 
temperature, 
al6, 
al12, 
al18, 
al24)

values
(
@months,
@rainfall, 
@temperature, 
@al6, 
@al12, 
@al18, 
@al24,
@wardid)

end