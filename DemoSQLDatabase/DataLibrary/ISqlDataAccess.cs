namespace DataLibrary;

public interface ISqlDataAccess
{
    Task<List<T>> LoadData<T>(string storedProc, string connectionName, object? parameters);
    Task SaveData(string storedProc, string connectionName, object parameters);
}