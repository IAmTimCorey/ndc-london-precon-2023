CREATE PROCEDURE [dbo].[spEmployee_Get]
	@Id int
AS
begin
	select [Id], [FirstName], [LastName]
	from dbo.Employee
	where Id = @Id;
end
