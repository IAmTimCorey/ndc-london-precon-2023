
UserRecord ur = new("Tim", "Corey");
UserRecord ur2 = new("Tim", "Corey");
Console.WriteLine(ur);

UserClass uc = new("Tim", "Corey");
UserClass uc2 = new("Tim", "Corey");
Console.WriteLine(uc);

var (fnR, lnR) = ur;

UserRecord ur3 = ur2 with { LastName = "Smith" };

if(ur == ur2)
{
    Console.WriteLine("The two are the same");
}

public record UserRecord(string FirstName, string LastName);

public class UserClass
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public UserClass(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void Deconstruct(out string FirstName, out string LastName)
    {
        FirstName = this.FirstName;
        LastName = this.LastName;
    }

}