using gms.common.Constants;
using System.Linq.Expressions;

namespace gms.services.Base;
public interface IBaseRepository<T> where T : class
{
    T GetById(int id);

    Task<T> GetByIdAsync(int id);

    List<T> GetAll();

    Task<List<T>> GetAllAsync();

    IQueryable<T> GetAllAsIQueryable();

    IQueryable<T> GetAllAsIQueryableAsNoTracking();

    T Find(Expression<Func<T, bool>> criteria, string[] includes = null);

    Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null);

    List<T> FindAll(Expression<Func<T, bool>> criteria, string[] includes = null);

    Task<List<T>> FindAllAsync(Expression<Func<T, bool>> criteria, string[] includes = null);

    List<T> FindAll(Expression<Func<T, bool>> criteria, int skip, int take, string[] includes = null);

    Task<List<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int skip, int take, string[] includes = null);

    List<T> FindAll(Expression<Func<T, bool>> criteria, int? skip, int? take, string[] includes = null, Expression<Func<T, object>> orderBy = null, string orderbyDirection = OrderBy.Asending);

    Task<List<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int? skip, int? take, string[] includes = null, Expression<Func<T, object>> orderBy = null, string orderbyDirection = OrderBy.Asending);

    T Add(T entity, int? userId = 0);

    Task<T> AddAsync(T entity, int? userId = 0);

    List<T> AddRange(List<T> entities, int? userId = 0);

    Task<List<T>> AddRangeAsync(List<T> entities, int? userId = 0);

    T Update(T entity, int? userId = 0);

    Task<T> UpdateAsync(T entity, int? userId = 0);

    void Delete(T entity, int? userId = 0);

    Task DeleteAsync(T entity, int? userId = 0);

    void DeleteRange(List<T> entities, int? userId = 0);

    Task DeleteRangeAsync(List<T> entities, int? userId = 0);

    void Attach(T entity);

    int Count();

    int Count(Expression<Func<T, bool>> criteria);

    bool SavaChanges();

    Task<bool> SaveChangesAsync();
}