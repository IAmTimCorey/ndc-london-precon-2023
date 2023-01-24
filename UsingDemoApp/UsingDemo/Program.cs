using UsingDemo;

//using Demo demo = new();

try
{
	//demo.BadMethod();

	using (Demo demo = new())
	{
		demo.BadMethod();
	}
}
catch (Exception ex)
{
	Console.WriteLine($"Exception: {ex.Message}");
}
