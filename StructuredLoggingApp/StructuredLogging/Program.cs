using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Seq("http://localhost:5341")
    .CreateLogger();

try
{
	Log.Information("Starting API");

	var builder = WebApplication.CreateBuilder(args);

	builder.Host.UseSerilog();

	// Add services to the container.
	// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
	builder.Services.AddEndpointsApiExplorer();
	builder.Services.AddSwaggerGen();

	var app = builder.Build();

	// Configure the HTTP request pipeline.
	if (app.Environment.IsDevelopment())
	{
		app.UseSwagger();
		app.UseSwaggerUI();
	}

	app.UseHttpsRedirection();

	app.MapGet("/hello", () =>
	{
		string fullName = "Tim Corey";
		Log.Error("This is my name: {name}", fullName);
		return "Hello World";
	})
	.WithOpenApi();

	app.Run();
}
catch (Exception ex)
{
	Log.Fatal(ex, "App terminated unexpectedly");
}
finally
{
	Log.CloseAndFlush();
}