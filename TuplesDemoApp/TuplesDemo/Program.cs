var output = GetNamesFromFullName("Tim Corey");

Console.WriteLine(output);

Console.WriteLine(output.firstName);
Console.WriteLine(output.lastName);

var (fn, ln) = GetNamesFromFullName("Tim Corey");
Console.WriteLine(fn);
Console.WriteLine(ln);

var (firstName, _) = GetNamesFromFullName("Tim Corey");
Console.WriteLine(firstName);

(string firstName, string lastName) GetNamesFromFullName(string fullName)
{
    var results = fullName.Split(' ');
    return (results[0], results[1]);
}
