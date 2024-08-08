using Common.DataAccess;

namespace CommentManagementService.DataAccess;

public sealed class CommentRepository:ICommentRepository
{
    public IEnumerable<Comment> GetAll()
    {
        throw new NotImplementedException();
    }

    public Comment? GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public bool Create(Comment post)
    {
        throw new NotImplementedException();
    }

    public bool Update(Comment post)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Guid id)
    {
        throw new NotImplementedException();
    }
    
}
