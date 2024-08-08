using Common.DataAccess;
using Dapper;
using Npgsql;

namespace PostManagementService.DataAccess;

file static class PostRepositoryHelpers
{
    public const string InsertPostCmd = "INSERT INTO post ( title, content) VALUES ( @Title, @Content)";
    public const string UpdatePostCmd = "UPDATE post SET title = @Title, content = @Content WHERE id = @Id";
    public const string DeletePostCmd = "DELETE FROM post WHERE id = @Id";
    public const string SelectPostCmd = "SELECT id, title, content FROM post";
    public const string SelectPostByIdCmd = "SELECT id, title, content FROM post WHERE id = @Id";
}


public sealed class PostRepository(IConfiguration configuration) : IPostRepository
{
    private const string ConnectionStringName = "Default";

    public IEnumerable<Post> GetAll()
    {
        NpgsqlConnection connection = DapperContext.CreateConnection(configuration, ConnectionStringName);
        IEnumerable<Post> records;
        try
        {
            records = connection.Query<Post>(PostRepositoryHelpers.SelectPostCmd).ToList();
        }
        finally
        {
            connection.Dispose();
        }

        return records;
    }

    public Post? GetById(Guid id)
    {
        NpgsqlConnection connection = DapperContext.CreateConnection(configuration, ConnectionStringName);
        Post? record;
        try
        {
            record = connection.QueryFirstOrDefault<Post>(PostRepositoryHelpers.SelectPostByIdCmd, new { Id = id });
        }
        finally
        {
            connection.Dispose();
        }

        return record;
    }

    public bool Create(Post post)
    {
        NpgsqlConnection connection = DapperContext.CreateConnection(configuration, ConnectionStringName);
        int affectedRows;
        try
        {
            affectedRows = connection.Execute(PostRepositoryHelpers.InsertPostCmd, post);
        }
        finally
        {
            connection.Dispose();
        }

        return affectedRows > 0;
    }

    public bool Update(Post post)
    {
        NpgsqlConnection connection = DapperContext.CreateConnection(configuration, ConnectionStringName);
        int affectedRows;
        try
        {
            affectedRows = connection.Execute(PostRepositoryHelpers.UpdatePostCmd, post);
        }
        finally
        {
            connection.Dispose();
        }

        return affectedRows > 0;
    }

    public bool Delete(Guid id)
    {
        NpgsqlConnection connection = DapperContext.CreateConnection(configuration, ConnectionStringName);
        int affectedRows;
        try
        {
            affectedRows = connection.Execute(PostRepositoryHelpers.DeletePostCmd, new { Id = id });
        }
        finally
        {
            connection.Dispose();
        }

        return affectedRows > 0;
    }
}