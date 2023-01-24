namespace UsingDemo;

public class Demo : IDisposable
{
    public Demo()
    {
        Console.WriteLine("Demo class instantiated");
    }

    public void GoodMethod()
    {
        Console.WriteLine("Good method called");
    }

    public void BadMethod()
    {
        Console.WriteLine("Bad method called");
        throw new Exception("The Demo.BadMethod has a problem");
    }

    public void Dispose()
    {
        Console.WriteLine("The Demo class has been properly closed");
    }
}
