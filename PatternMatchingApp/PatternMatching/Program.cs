using PatternMatching;

IUserClass user = new UserClass("Tim", "Corey");

if (user is not null)
{
    Console.WriteLine("User is not null");
}

if (user is UserClass)
{
    Console.WriteLine("This is a user class");
}

if (user is UserClass newUser)
{
    Console.WriteLine($"Hello {newUser.FirstName}");
}

if (user is { FirstName: "Tim" })
{

}
