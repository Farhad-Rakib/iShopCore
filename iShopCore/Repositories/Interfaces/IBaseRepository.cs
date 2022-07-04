using System.Linq.Expressions;

namespace iShopCore.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {

        Task<IEnumerable<T>> GetAll();
        void Delete(long entity);
        void Update(T entity);
        Task<T> GetById(long id);
        //long GetLastId();
        T Insert(T obj);
        void Save();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

    }
}
