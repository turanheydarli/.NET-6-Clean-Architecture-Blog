using Turan.Data.Abstract;
using Turan.Data.Concrete.EntityFramework;
using Turan.Data.Concrete.EntityFramework.Contexts;

namespace Turan.Data.Concrete
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ProjectDbContext _context;

		public UnitOfWork(ProjectDbContext context)
		{
			_context = context;
		}
		 
		public IAboutRepository About => new EfAboutRepository(_context);

		public IArticleRepository Article => new EfArticleRepository(_context);

		public ICategoryRepository Category => new EfCategoryRepository(_context);

		public ICommentRepository Comment => new EfCommentRepository(_context);

		public IContactRepository Contact => new EfContactRepository(_context);

		public ISettingRepositoy Setting => new EfSettingRepository(_context);

		public ISkillRepository Skill => new EfSkillRepository(_context);

		public ISocialRepository Social => new EfSocialRepository(_context);

		public async ValueTask DisposeAsync()
		{
			await _context.DisposeAsync();
		}

		public async Task<int> SaveAsync()
		{
			return await _context.SaveChangesAsync();
		}
	}
}
