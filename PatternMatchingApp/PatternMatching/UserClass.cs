namespace PatternMatching;

public class UserClass : IUserClass
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public UserClass(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

}
