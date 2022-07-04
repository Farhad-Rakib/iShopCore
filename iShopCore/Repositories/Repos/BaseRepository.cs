using iShopCore.DbContexts;
using iShopCore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace iShopCore.Repositories.Repos;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private ApplicationDbContext _context;
    private DbSet<T> table ;
    
    public BaseRepository(ApplicationDbContext _context)
    {
        this._context = _context;
        table = _context.Set<T>();
    }
    public void Delete(long id)
    {
        T existing = table.Find(id);
        table.Remove(existing);
    }

    public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
    {
        IQueryable<T> query = table.Where(predicate);
        return query;
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await table.ToListAsync();
    }

    public async Task<T> GetById(long id)
    {
        return await table.FindAsync(id);
    }

    //public long GetLastId()
    //{
    //    return table.OrderBy(a => a.Id).LastOrDefault().Id;
    //}

    public T Insert(T obj)
    {
        table.Add(obj);
        return obj;
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public void Update(T obj)
    {
        table.Attach(obj);
        _context.Entry(obj).State = EntityState.Modified;
    }
}

