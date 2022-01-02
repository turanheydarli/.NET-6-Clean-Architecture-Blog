using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Shared.Data.Abstract
{
	public interface IEntityRepository<T> where T : class, IEntity, new()
	{
		Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeEntities);
		T Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeEntities);
		Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeEntities);
		IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeEntities);
		Task<T> AddAsync(T entity);
		T Add(T entity);
		Task<T> UpdateAsync(T entity);
		T Update(T entity);
		Task DeleteAsync(T entity);
		void Delete(T entity);
		int SaveChanges();
		Task<int> SaveChangesAsync();

		Task<int> GetCountAsync(Expression<Func<T, bool>> predicate = null);
		int GetCount(Expression<Func<T, bool>> predicate = null);
		Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
		bool Any(Expression<Func<T, bool>> predicate);
	}
}
