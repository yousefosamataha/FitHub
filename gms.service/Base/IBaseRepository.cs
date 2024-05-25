using gms.common.Constants;
using gms.data.Models.Base;
using System.Linq.Expressions;

namespace gms.services.Base;

public interface IBaseRepository<T> where T : BaseEntity
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

	T Add(T entity);

	Task<T> AddAsync(T entity);

	List<T> AddRange(List<T> entities);

	Task<List<T>> AddRangeAsync(List<T> entities);

	T Update(T entity);

	Task<T> UpdateAsync(T entity);

	void Delete(T entity);

	Task DeleteAsync(T entity);

	void DeleteRange(List<T> entities);

	Task DeleteRangeAsync(List<T> entities);

	void Attach(T entity);

	Task AttachAsync(T entity);

	int Count();

	Task<int> CountAsync();

	int Count(Expression<Func<T, bool>> criteria);

	Task<int> CountAsync(Expression<Func<T, bool>> criteria);

	bool SavaChanges();

	Task<bool> SaveChangesAsync();

	int GetUserId();

	int GetBranchId();

	int GetGymId();

	Dictionary<string, object> GetScopesInformation();
}