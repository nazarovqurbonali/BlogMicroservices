using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Common.DataAccess;

public static class DapperContext
{
    public static NpgsqlConnection CreateConnection(IConfiguration configuration,string connectionStringName)
    {
        NpgsqlConnection connection= new(configuration.GetConnectionString(connectionStringName));
        connection.Open();
        return connection;
    }
}