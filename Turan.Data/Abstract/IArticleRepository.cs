using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.Concrete;
using Turan.Shared.Data.Abstract;

namespace Turan.Data.Abstract
{
	public interface IArticleRepository : IEntityRepository<Article>
	{
	}
}
