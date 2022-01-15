using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Turan.Data.Abstract;
using Turan.Data.Concrete;
using Turan.Data.Concrete.EntityFramework.Contexts;
using Turan.Service.Abstract;
using Turan.Service.Concrete;
using Turan.Shared.Entities.Concrete;

namespace Turan.Service.Utilities.Extensions
{
	public static class ConfigureServicesExtension
	{
		public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<ProjectDbContext, MsDbContext>(options =>
			{
				options.UseSqlServer(configuration.GetConnectionString("TworunBlog"));
			});

			services.AddIdentity<User, IdentityRole>(IdentityOptions =>
			{
				IdentityOptions.Password.RequiredLength = 8;
				IdentityOptions.Password.RequireDigit = true;
				IdentityOptions.User.RequireUniqueEmail = true;
			}).AddDefaultTokenProviders().AddEntityFrameworkStores<MsDbContext>();

			services.ConfigureApplicationCookie(options =>
			{
				options.Cookie.Name = "Cookie";
				options.Cookie.HttpOnly = true;
				options.ExpireTimeSpan = TimeSpan.FromMinutes(720);
				options.LoginPath = "/login";
				options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
				options.SlidingExpiration = true;
			});

			services.AddTransient<IAboutService, AboutManager>();
			services.AddTransient<IUserService, UserManager>();

			services.AddTransient<ISocialService, SocialManager>();
			services.AddTransient<IArticleService, ArticleManager>();

			services.AddTransient<IUnitOfWork, UnitOfWork>();

			services.AddAutoMapper(Assembly.GetExecutingAssembly());

			return services;
		}
	}
}
