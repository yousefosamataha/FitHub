using gms.common.Constants;
using gms.data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace gms.services.Base;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
	private readonly ApplicationDbContext _context;

	public BaseRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public T GetById(int id) => _context.Set<T>().Find(id);

	public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FindAsync(id);

	public List<T> GetAll() => _context.Set<T>().ToList();

	public async Task<List<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

	public T Find(Expression<Func<T, bool>> criteria, string[] includes = null)
	{
		IQueryable<T> query = _context.Set<T>();

		if (includes is not null)
		{
			foreach (string include in includes)
			{
				query = query.Include(include);
			}
		}

		return query.SingleOrDefault(criteria);
	}

	public async Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null)
	{
		IQueryable<T> query = _context.Set<T>();

		if (includes is not null)
		{
			foreach (string include in includes)
			{
				query = query.Include(include);
			}
		}

		return await query.SingleOrDefaultAsync(criteria);
	}

	public List<T> FindAll(Expression<Func<T, bool>> criteria, string[] includes = null)
	{
		IQueryable<T> query = _context.Set<T>();

		if (includes is not null)
		{
			foreach (string include in includes)
			{
				query = query.Include(include);
			}
		}

		return query.Where(criteria).ToList();
	}

	public async Task<List<T>> FindAllAsync(Expression<Func<T, bool>> criteria, string[] includes = null)
	{
		IQueryable<T> query = _context.Set<T>();

		if (includes is not null)
		{
			foreach (string include in includes)
			{
				query = query.Include(include);
			}
		}

		return await query.Where(criteria).ToListAsync();
	}

	public List<T> FindAll(Expression<Func<T, bool>> criteria, int skip, int take, string[] includes = null)
	{
		IQueryable<T> query = _context.Set<T>();

		if (includes is not null)
		{
			foreach (string include in includes)
			{
				query = query.Include(include);
			}
		}

		return query.Where(criteria).Skip(skip).Take(take).ToList();
	}

	public async Task<List<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int skip, int take, string[] includes = null)
	{
		IQueryable<T> query = _context.Set<T>();

		if (includes is not null)
		{
			foreach (string include in includes)
			{
				query = query.Include(include);
			}
		}

		return await query.Where(criteria).Skip(skip).Take(take).ToListAsync();
	}

	public List<T> FindAll(Expression<Func<T, bool>> criteria, int? skip, int? take, string[] includes = null, Expression<Func<T, object>> orderBy = null, string orderbyDirection = OrderBy.Asending)
	{
		IQueryable<T> query = _context.Set<T>();

		if (includes is not null)
		{
			foreach (string include in includes)
			{
				query = query.Include(include);
			}
		}

		query = query.Where(criteria);

		query = skip.HasValue ? query.Skip(skip.Value) : query;

		query = take.HasValue ? query.Take(take.Value) : query;

		if (orderBy is not null)
		{
			query = string.Equals(orderbyDirection, OrderBy.Asending, StringComparison.OrdinalIgnoreCase) ? query.OrderBy(orderBy) : query.OrderByDescending(orderBy);
		}

		return query.ToList();
	}

	public async Task<List<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int? skip, int? take, string[] includes = null, Expression<Func<T, object>> orderBy = null, string orderbyDirection = OrderBy.Asending)
	{
		IQueryable<T> query = _context.Set<T>();

		if (includes is not null)
		{
			foreach (string include in includes)
			{
				query = query.Include(include);
			}
		}

		query = query.Where(criteria);

		query = skip.HasValue ? query.Skip(skip.Value) : query;

		query = take.HasValue ? query.Take(take.Value) : query;

		if (orderBy is not null)
		{
			query = string.Equals(orderbyDirection, OrderBy.Asending, StringComparison.OrdinalIgnoreCase) ? query.OrderBy(orderBy) : query.OrderByDescending(orderBy);
		}

		return await query.ToListAsync();
	}

	public T Add(T entity)
	{
		_context.Set<T>().Add(entity);
		_context.SaveChanges();
		return entity;
	}

	public async Task<T> AddAsync(T entity)
	{
		_context.Set<T>().Add(entity);
		await _context.SaveChangesAsync();
		return entity;
	}

	public List<T> AddRange(List<T> entities)
	{
		_context.Set<T>().AddRange(entities);
		_context.SaveChanges();
		return entities;
	}

	public async Task<List<T>> AddRangeAsync(List<T> entities)
	{
		_context.Set<T>().AddRange(entities);
		await _context.SaveChangesAsync();
		return entities;
	}

	public T Update(T entity)
	{
		_context.Set<T>().Update(entity);
		_context.SaveChanges();
		return entity;
	}

	public async Task<T> UpdateAsync(T entity)
	{
		_context.Set<T>().Update(entity);
		await _context.SaveChangesAsync();
		return entity;
	}

	public void Delete(T entity)
	{
		_context.Set<T>().Remove(entity);
		_context.SaveChanges();
	}

	public async Task DeleteAsync(T entity)
	{
		_context.Set<T>().Remove(entity);
		await _context.SaveChangesAsync();
	}

	public void DeleteRange(List<T> entities)
	{
		_context.Set<T>().RemoveRange(entities);
		_context.SaveChanges();
	}

	public async Task DeleteRangeAsync(List<T> entities)
	{
		_context.Set<T>().RemoveRange(entities);
		await _context.SaveChangesAsync();
	}

	public void Attach(T entity)
	{
		_context.Set<T>().Attach(entity);
	}

	public async Task AttachAsync(T entity)
	{
		_context.Set<T>().Attach(entity);
		await Task.CompletedTask;
	}

	public int Count()
	{
		return _context.Set<T>().Count();
	}

	public async Task<int> CountAsync()
	{
		return await _context.Set<T>().CountAsync();
	}

	public int Count(Expression<Func<T, bool>> criteria)
	{
		return _context.Set<T>().Count(criteria);
	}

	public async Task<int> CountAsync(Expression<Func<T, bool>> criteria)
	{
		return await _context.Set<T>().CountAsync(criteria);
	}
}
