CREATE PROCEDURE [dbo].[spEmployee_GetAll]
AS
begin
	select *
	from dbo.Employee;
end