using Microsoft.Data.Sqlite;
using System.Data;

namespace Design.DependencyInjection.Data;

public interface IDbConnectionFactory
{
    Task<IDbConnection> CreateDbConnectionAsync();
}

public sealed class SqliteDbConnectionFactory : IDbConnectionFactory
{
    private readonly DbConnectionOptions _dbConnectionOptions;
    public SqliteDbConnectionFactory()
    {
        _dbConnectionOptions = new DbConnectionOptions()
        {
            ConnectionString = "Data Source=./database.db"
        };
    }

    public async Task<IDbConnection> CreateDbConnectionAsync()
    {
        var connection = new SqliteConnection(_dbConnectionOptions.ConnectionString);
        await connection.OpenAsync();

        return connection;
    }
}
