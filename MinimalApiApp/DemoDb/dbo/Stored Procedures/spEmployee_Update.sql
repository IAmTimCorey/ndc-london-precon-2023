CREATE PROCEDURE [dbo].[spEmployee_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
	update dbo.Employee
	set FirstName = @FirstName, LastName = @LastName
	where Id = @Id;
end