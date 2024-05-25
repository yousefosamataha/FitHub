using gms.common.Constants;
using gms.data;
using gms.data.Models.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace gms.services.Base;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;

	public BaseRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
	}

	public T GetById(int id) => _context.Set<T>().Find(id);

	public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FindAsync(id);

	public List<T> GetAll() => GetAllAsIQueryableAsNoTracking().ToList();

	public async Task<List<T>> GetAllAsync() => await GetAllAsIQueryableAsNoTracking().ToListAsync();

	public IQueryable<T> GetAllAsIQueryable() => _context.Set<T>().AsQueryable();

	public IQueryable<T> GetAllAsIQueryableAsNoTracking() => _context.Set<T>().AsQueryable().AsNoTracking();

	public T Find(Expression<Func<T, bool>> criteria, string[] includes = null)
	{
		IQueryable<T> query = GetAllAsIQueryable();

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
		IQueryable<T> query = GetAllAsIQueryable();

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
		IQueryable<T> query = GetAllAsIQueryableAsNoTracking();

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
		IQueryable<T> query = GetAllAsIQueryableAsNoTracking();

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
		IQueryable<T> query = GetAllAsIQueryableAsNoTracking();

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
		IQueryable<T> query = GetAllAsIQueryableAsNoTracking();

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
		IQueryable<T> query = GetAllAsIQueryableAsNoTracking();

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
		IQueryable<T> query = GetAllAsIQueryableAsNoTracking();

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
		entity.CreatedAt = DateTime.UtcNow;
		entity.CreatedById = GetUserId();
		_context.Set<T>().Add(entity);
		SavaChanges();
		return entity;
	}

	public async Task<T> AddAsync(T entity)
	{
		entity.CreatedAt = DateTime.UtcNow;
		entity.CreatedById = GetUserId();
		_context.Set<T>().Add(entity);
		await SaveChangesAsync();
		return entity;
	}

	public List<T> AddRange(List<T> entities)
	{
		entities.Select(e =>
		{
			e.CreatedAt = DateTime.UtcNow;
			e.CreatedById = GetUserId();
			return e;
		}).ToList();

		_context.Set<T>().AddRange(entities);

		SavaChanges();

		return entities;
	}

	public async Task<List<T>> AddRangeAsync(List<T> entities)
	{
		entities.Select(e =>
		{
			e.CreatedAt = DateTime.UtcNow;
			e.CreatedById = GetUserId();
			return e;
		}).ToList();

		_context.Set<T>().AddRange(entities);

		await SaveChangesAsync();

		return entities;
	}

	public T Update(T entity)
	{
		entity.ModifiedAt = DateTime.UtcNow;
		entity.ModifiedById = GetUserId();
		_context.Set<T>().Update(entity);
		SavaChanges();
		return entity;
	}

	public async Task<T> UpdateAsync(T entity)
	{
		entity.ModifiedAt = DateTime.UtcNow;
		entity.ModifiedById = GetUserId();
		_context.Set<T>().Update(entity);
		await SaveChangesAsync();
		return entity;
	}

	public void Delete(T entity)
	{
		entity.IsDeleted = true;
		entity.DeletedById = GetUserId();
		_context.Set<T>().Update(entity);
		SavaChanges();
	}

	public async Task DeleteAsync(T entity)
	{
		entity.IsDeleted = true;
		entity.DeletedById = GetUserId();
		entity.DeletedAt = DateTime.UtcNow;
		_context.Set<T>().Update(entity);
		await SaveChangesAsync();
	}

	public void DeleteRange(List<T> entities)
	{
		_context.Set<T>()
				.Where(e => entities.Contains(e))
				.ExecuteUpdate(e => e.SetProperty(p => p.IsDeleted, true)
									 .SetProperty(p => p.DeletedById, GetUserId())
									 .SetProperty(p => p.DeletedAt, DateTime.UtcNow));
		SavaChanges();
	}

	public async Task DeleteRangeAsync(List<T> entities)
	{
		await _context.Set<T>()
					  .Where(e => entities.Contains(e))
					  .ExecuteUpdateAsync(e => e.SetProperty(p => p.IsDeleted, true)
												.SetProperty(p => p.DeletedById, GetUserId())
												.SetProperty(p => p.DeletedAt, DateTime.UtcNow));
		await SaveChangesAsync();
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
		return GetAllAsIQueryableAsNoTracking().Count();
	}

	public async Task<int> CountAsync()
	{
		return await GetAllAsIQueryableAsNoTracking().CountAsync();
	}

	public int Count(Expression<Func<T, bool>> criteria)
	{
		return GetAllAsIQueryableAsNoTracking().Count(criteria);
	}

	public async Task<int> CountAsync(Expression<Func<T, bool>> criteria)
	{
		return await GetAllAsIQueryableAsNoTracking().CountAsync(criteria);
	}

	public bool SavaChanges()
	{
		try
		{
			return _context.SaveChanges() > 0 ? true : false;
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public async Task<bool> SaveChangesAsync()
	{
		try
		{
			return await _context.SaveChangesAsync() > 0 ? true : false;
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public int GetUserId()
	{
		if (int.TryParse(_httpContextAccessor.HttpContext.User.FindFirst("UserId")?.Value, out int result))
			return result;
		else
			return 0;
	}

	public int GetBranchId()
	{
		if (int.TryParse(_httpContextAccessor.HttpContext.User.FindFirst("BranchId")?.Value, out int result))
			return result;
		else
			return 0;
	}

	public int GetGymId()
	{
		if (int.TryParse(_httpContextAccessor.HttpContext.User.FindFirst("GymId")?.Value, out int result))
			return result;
		else
			return 0;
	}

	public Dictionary<string, object> GetScopesInformation()
	{
		Dictionary<string, object> scopeInfo = new();
		scopeInfo.Add("MachineName", Environment.MachineName);
		scopeInfo.Add("Environment", "Development");
		scopeInfo.Add("AppName", "Logging Scopes");
		scopeInfo.Add("GymId", GetGymId());
		scopeInfo.Add("BranchId", GetBranchId());
		scopeInfo.Add("UserId", GetUserId());
		return scopeInfo;
	}
}
