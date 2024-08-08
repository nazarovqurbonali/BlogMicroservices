namespace CommentManagementService.DTOs;

public readonly record struct CommentCreateInfo(Guid PostId, string Content);

public readonly record struct CommentUpdateInfo(string Content);

public readonly record struct CommentReadInfo(Guid Id, Guid PostId, string Content);
