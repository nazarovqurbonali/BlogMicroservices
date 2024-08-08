namespace PostManagementService.DTOs;

public readonly record struct PostCreateInfo(string Title, string Content);

public readonly record struct PostUpdateInfo( string Title, string Content);    

public readonly record struct PostReadInfo(Guid Id, string Title, string Content);
    
