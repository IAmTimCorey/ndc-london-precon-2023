using DataAccess;

namespace MinimalApi.Endpoints;

public static class EmployeeEndpoints
{
    public static WebApplication MapEmployeeEndpoints(this WebApplication app)
    {
        app.MapGet("/Employees", async (ISqlDataAccess sql) =>
        {
            return await sql.LoadData<EmployeeModel>("spEmployee_GetAll",
                                                     "Default",
                                                     null);
        });

        app.MapGet("/Employees/{id}", async (int id, ISqlDataAccess sql) =>
        {
            return await sql.LoadData<EmployeeModel>("spEmployee_Get",
                                                     "Default",
                                                     new { Id = id });
        });

        app.MapPost("/Employees", async (EmployeeModel emp, ISqlDataAccess sql) =>
        {
            await sql.SaveData("spEmployee_Insert", "Default", emp);
            return Results.Ok();
        });

        app.MapPut("Employees", async (EmployeeModel emp, ISqlDataAccess sql) =>
        {
            await sql.SaveData("spEmployee_Update", "Default", emp);
            return Results.Ok();
        });

        app.MapDelete("/Employees", async (int id, ISqlDataAccess sql) =>
        {
            await sql.SaveData("spEmployee_Delete", "Default", new { Id = id });
            return Results.Ok();
        });

        return app;
    }
}
