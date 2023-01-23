using DemoLibrary;

namespace DIinConsole;

public class App
{
    private readonly ITiming _timing;

    public App(ITiming timing)
	{
        _timing = timing;
    }

    public void Run(string[] args)
    {
        Console.WriteLine(_timing.DisplayTime());
    }
}
