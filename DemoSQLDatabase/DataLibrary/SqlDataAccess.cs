using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DataLibrary;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<List<T>> LoadData<T>(string storedProc, string connectionName, object? parameters)
    {
        string connectionString = _config.GetConnectionString(connectionName) ??
            throw new Exception($"Missing connection string for {connectionName}");

        using var connection = new SqlConnection(connectionString);

        var rows = await connection.QueryAsync<T>(storedProc,
                                                  parameters,
                                                  commandType: System.Data.CommandType.StoredProcedure);
        return rows.ToList();
    }

    public async Task SaveData(string storedProc, string connectionName, object parameters)
    {
        string connectionString = _config.GetConnectionString(connectionName) ??
            throw new Exception($"Missing connection string for {connectionName}");

        using var connection = new SqlConnection(connectionString);

        await connection.ExecuteAsync(storedProc, parameters, commandType: System.Data.CommandType.StoredProcedure);
    }
}
