namespace BlazorServer.Data;

public interface IPerson
{
    string Message { get; set; }
}

public interface IPerson2 : IPerson
{

}

public class Person1 : IPerson
{
    public string Message { get; set; } = "Hello from Person1";
}

public class Person2 : IPerson2
{
    public string Message { get; set; } = "Hello from Person2";
}

public class Person3 : IPerson
{
    public string Message { get; set; } = "Hello from Person3";
}