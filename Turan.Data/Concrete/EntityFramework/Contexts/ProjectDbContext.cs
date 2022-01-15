using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.Concrete;
using Turan.Shared.Entities.Concrete;

namespace Turan.Data.Concrete.EntityFramework.Contexts
{
	public class ProjectDbContext : IdentityDbContext<User>
	{
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
            : base(options)
        {
        }

        protected ProjectDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected IConfiguration Configuration { get; }

  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("TworunBlog"));
            }
        }
        public DbSet<About> Abouts { get; set; }
		public DbSet<Article> Articles { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Setting> Settings { get; set; }
		public DbSet<Skill> Skills { get; set; }
		public DbSet<Social> Socials { get; set; }
	}
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ProjectDbContext>
    {
        public ProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MsDbContext>();
            builder.UseSqlServer("Server=DESKTOP-62OF0BB;Database=TworunBlog;Integrated Security=sspi;");
            return new MsDbContext(builder.Options);
        }
    }
}
