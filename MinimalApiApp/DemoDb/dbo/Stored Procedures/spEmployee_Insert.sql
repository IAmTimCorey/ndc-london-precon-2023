CREATE PROCEDURE [dbo].[spEmployee_Insert]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
	insert into dbo.Employee(FirstName, LastName)
	values (@FirstName, @LastName);
end