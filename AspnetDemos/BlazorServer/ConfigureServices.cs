using BlazorServer.Data;

namespace BlazorServer;

public static class ConfigureServices
{
    public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddSingleton<IPerson, Person1>();
        builder.Services.AddSingleton<IPerson, Person2>();
        builder.Services.AddSingleton<IPerson, Person3>();

        return builder;
    }
}
