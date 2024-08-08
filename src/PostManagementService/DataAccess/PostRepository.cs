using Common.DataAccess;

namespace PostManagementService.DataAccess;

public class PostRepository:IPostRepository
{
    public IEnumerable<Post> GetAll()
    {
        throw new NotImplementedException();
    }

    public Post? GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public bool Create(Post post)
    {
        throw new NotImplementedException();
    }

    public bool Update(Post post)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}