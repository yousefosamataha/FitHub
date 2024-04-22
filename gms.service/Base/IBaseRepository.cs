using gms.common.Constants;
using System.Linq.Expressions;

namespace gms.services.Base;
public interface IBaseRepository<T> where T : class
{
	T GetById(Guid id);

	Task<T> GetByIdAsync(Guid id);

	List<T> GetAll();

	Task<List<T>> GetAllAsync();

	T Find(Expression<Func<T, bool>> criteria, string[] includes = null);

	Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null);

	List<T> FindAll(Expression<Func<T, bool>> criteria, string[] includes = null);

	Task<List<T>> FindAllAsync(Expression<Func<T, bool>> criteria, string[] includes = null);

	List<T> FindAll(Expression<Func<T, bool>> criteria, int skip, int take, string[] includes = null);

	Task<List<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int skip, int take, string[] includes = null);

	List<T> FindAll(Expression<Func<T, bool>> criteria, int? skip, int? take, string[] includes = null, Expression<Func<T, object>> orderBy = null, string orderbyDirection = OrderBy.Asending);

	Task<List<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int? skip, int? take, string[] includes = null, Expression<Func<T, object>> orderBy = null, string orderbyDirection = OrderBy.Asending);

	T Add(T entity);

	List<T> AddRange(List<T> entities);

	T Update(T entity);

	void Delete(T entity);

	void DeleteRange(List<T> entities);

	void Attach(T entity);

	int Count();

	int Count(Expression<Func<T, bool>> criteria);
}