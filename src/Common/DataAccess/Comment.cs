namespace Common.DataAccess;

public sealed class Comment
{
    public required Guid Id { get; init; }
    public required Guid PostId { get; init; }
    public required string Content { get; set; }
    
}