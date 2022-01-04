using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turan.Data.Abstract
{
	public interface IUnitOfWork : IAsyncDisposable
	{
		IAboutRepository About { get; }
		IArticleRepository Article { get; }
		ICategoryRepository Category { get; }
		ICommentRepository Comment { get; }
		IContactRepository Contact { get; }
		ISettingRepositoy Setting { get; }
		ISkillRepository Skill { get; }
		ISocialRepository Social { get; }
		Task<int> SaveAsync();
	}
}
