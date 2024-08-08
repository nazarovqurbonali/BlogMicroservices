namespace Common.DataAccess;

public interface IBaseRepository<T>
{
    IEnumerable<T> GetAll();
    T? GetById(Guid id);
    bool Create(T post);
    bool Update(T post);
    bool Delete(Guid id);
}


