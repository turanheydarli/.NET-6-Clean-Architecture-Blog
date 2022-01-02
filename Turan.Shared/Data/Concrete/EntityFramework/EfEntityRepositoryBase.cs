using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Extensions;
using Turan.Shared.Data.Abstract;
using Turan.Shared.Entities.Abstract;

namespace Turan.Shared.Data.Concrete.EntityFramework
{
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
		where TEntity : class, IEntity, new()
		where TContext : DbContext
	{
		public EfEntityRepositoryBase(TContext context)
		{
			Context = context;
		}
		protected TContext Context { get; }

		public TEntity Add(TEntity entity)
		{
			Context.Set<IEntity>().Add(entity);
			return entity;
		}

		public async Task<TEntity> AddAsync(TEntity entity)
		{
			await Context.Set<TEntity>().AddAsync(entity);
			return entity;
		}

		public bool Any(Expression<Func<TEntity, bool>> predicate)
		{
			return Context.Set<TEntity>().Any(predicate);
		}

		public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
		{
			return await Context.Set<TEntity>().AnyAsync(predicate);
		}

		public void Delete(TEntity entity)
		{
			Context.Set<TEntity>().Remove(entity);
		}

		public async Task DeleteAsync(TEntity entity)
		{
			await Task.Run(() => { Context.Set<TEntity>().Remove(entity); });
		}

		public TEntity Get(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeEntities)
		{
			return Context.Set<TEntity>().IncludeMultiple(includeEntities).SingleOrDefault(predicate);
		}

		public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeEntities)
		{
			return predicate == null
				? Context.Set<TEntity>().IncludeMultiple(includeEntities).ToList()
				: Context.Set<TEntity>().Where(predicate).IncludeMultiple(includeEntities).ToList();
		}

		public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeEntities)
		{
			return predicate == null
				? await Context.Set<TEntity>().IncludeMultiple(includeEntities).ToListAsync()
				: await Context.Set<TEntity>().Where(predicate).IncludeMultiple(includeEntities).ToListAsync();
		}

		public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeEntities)
		{
			return await Context.Set<TEntity>().IncludeMultiple(includeEntities).SingleOrDefaultAsync(predicate);
		}

		public int GetCount(Expression<Func<TEntity, bool>> predicate = null)
		{
			return Context.Set<TEntity>().Count();
		}

		public async Task<int> GetCountAsync(Expression<Func<TEntity, bool>> predicate = null)
		{
			return await Context.Set<TEntity>().CountAsync();
		}

		public int SaveChanges()
		{
			return Context.SaveChanges();
		}

		public Task<int> SaveChangesAsync()
		{
			return Context.SaveChangesAsync();
		}

		public TEntity Update(TEntity entity)
		{
			Context.Set<TEntity>().Update(entity);
			return entity;
		}

		public async Task<TEntity> UpdateAsync(TEntity entity)
		{
			await Task.Run(() => { Context.Set<TEntity>().Update(entity); });
			return entity;
		}
	}
}
