using Dapper;

namespace Design.DependencyInjection.Data;

public interface IUserRepository
{
    Task<bool> CreateAsync(User user);
    Task<bool> DeleteByIdAsync(Guid id);
    Task<IEnumerable<User>> GetAllAsync();
    Task<User?> GetByIdAsync(Guid id);
}

public sealed class UserRepository(IDbConnectionFactory dbConnectionFactory) : IUserRepository
{
    private readonly IDbConnectionFactory _connectionFactory = dbConnectionFactory;

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        using var connection = await _connectionFactory.CreateDbConnectionAsync();
        return await connection.QueryAsync<User>("SELECT * FROM Users");
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
        const string query = "SELECT * FROM Users WHERE Id = @Id";
        using var connection = await _connectionFactory.CreateDbConnectionAsync();
        return await connection.QuerySingleOrDefaultAsync<User>(query, new { Id = id });
    }

    public async Task<bool> CreateAsync(User user)
    {
        const string query = "INSERT INTO Users (Id,FullName) VALUES (@Id,@FullName);";
        using var connection = await _connectionFactory.CreateDbConnectionAsync();

        var result = await connection.ExecuteAsync(query, new { Id = user.Id, FullName = user.FullName });

        return result > 0;
    }

    public async Task<bool> DeleteByIdAsync(Guid id)
    {
        const string query = "DELETE FROM Users WHERE Id = @Id";

        using var connection = await _connectionFactory.CreateDbConnectionAsync();

        var result = await connection.ExecuteAsync(query, new { Id = id });

        return result > 0;
    }
}
