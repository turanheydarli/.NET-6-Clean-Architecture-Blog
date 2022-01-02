using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;

namespace Turan.Shared.Extensions
{
	public static class LinqExtension
	{
		public static IQueryable<T> IncludeMultiple<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] includes) where T:class
		{
			if (includes != null)
				query = includes.Aggregate(query, (current, include) => current.Include(include));

			return query;
		}
	}
}
