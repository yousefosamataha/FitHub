using gms.common.Constants;
using gms.common.Contracts.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace gms.data.Services.Base;
public class BaseRepository<T> : IBaseRepository<T> where T : class
{
	private readonly ApplicationDbContext _context;
	public BaseRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public T GetById(Guid id) => _context.Set<T>().Find(id);

	public async Task<T> GetByIdAsync(Guid id) => await _context.Set<T>().FindAsync(id);

	public List<T> GetAll() => _context.Set<T>().ToList();

	public async Task<List<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

	public T Find(Expression<Func<T, bool>> criteria, string[] includes = null)
	{
		IQueryable<T> query = _context.Set<T>();

		if (includes is not null)
			foreach (string include in includes)
				query = query.Include(include);

		return _context.Set<T>().SingleOrDefault(criteria);
	}

	public List<T> FindAll(Expression<Func<T, bool>> criteria, string[] includes = null)
	{
		IQueryable<T> query = _context.Set<T>();

		if (includes is not null)
			foreach (string include in includes)
				query = query.Include(include);

		return _context.Set<T>().Where(criteria).ToList();
	}

	public List<T> FindAll(Expression<Func<T, bool>> criteria, int skip, int take, string[] includes = null)
	{
		IQueryable<T> query = _context.Set<T>();

		if (includes is not null)
			foreach (string include in includes)
				query = query.Include(include);

		return _context.Set<T>().Where(criteria).Skip(skip).Take(take).ToList();
	}

	public List<T> FindAll(Expression<Func<T, bool>> criteria, int? skip, int? take, string[] includes = null, Expression<Func<T, object>> orderBy = null, string orderbyDirection = OrderBy.Asending)
	{
		IQueryable<T> query = _context.Set<T>();

		if (includes is not null)
			foreach (string include in includes)
				query = query.Include(include);

		query = query.Where(criteria);

		query = skip.HasValue ? query.Skip(skip.Value) : query;

		query = take.HasValue ? query.Take(take.Value) : query;

		if (orderBy is not null)
			query = string.Equals(orderbyDirection, OrderBy.Asending, StringComparison.OrdinalIgnoreCase) ? query.OrderBy(orderBy) : query.OrderByDescending(orderBy);

		return query.ToList();
	}

	public T Add(T entity)
	{
		_context.Set<T>().Add(entity);
		return entity;
	}

	public List<T> AddRange(List<T> entities)
	{
		_context.Set<T>().AddRange(entities);
		return entities;
	}

	public T Update(T entity)
	{
		_context.Set<T>().Update(entity);
		return entity;
	}

	public void Delete(T entity)
	{
		_context.Set<T>().Remove(entity);
	}

	public void DeleteRange(List<T> entities)
	{
		_context.Set<T>().RemoveRange(entities);
	}

	public void Attach(T entity)
	{
		_context.Set<T>().Attach(entity);
	}

	public int Count()
	{
		return _context.Set<T>().Count();
	}

	public int Count(Expression<Func<T, bool>> criteria)
	{
		return _context.Set<T>().Count(criteria);
	}
}
