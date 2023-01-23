namespace DemoLibrary;

public class Timing : ITiming
{
    DateTime instanceTime = DateTime.Now;
    public string DisplayTime()
    {
        return instanceTime.ToString("hh:mm:ss");
    }
}
