namespace Common.DataAccess;

public sealed class Post
{
    public Guid Id { get; init; }
    public required string Title { get; set; }
    public required string Content { get; set; }
}