CREATE PROCEDURE [dbo].[spEmployee_Delete]
	@Id int
AS
begin
	delete
	from dbo.Employee
	where Id = @Id;
end
