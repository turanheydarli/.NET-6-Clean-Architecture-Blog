using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Turan.Data.Abstract;
using Turan.Data.Concrete;
using Turan.Data.Concrete.EntityFramework.Contexts;
using Turan.Service.Abstract;
using Turan.Service.Concrete;

namespace Turan.Service
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton<IAboutService, AboutManager>();
			services.AddSingleton<ISocialService, SocialManager>();

			services.AddTransient<IUnitOfWork, UnitOfWork>();
			services.AddSingleton<MsDbContext, MsDbContext>();

			services.AddAutoMapper(Assembly.GetExecutingAssembly());
		}
	}
}
