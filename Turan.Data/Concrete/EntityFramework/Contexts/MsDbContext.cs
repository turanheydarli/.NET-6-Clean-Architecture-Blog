using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.Concrete;

namespace Turan.Data.Concrete.EntityFramework.Contexts
{
	public class MsDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connectionString: 
				@"Server=.;Database=Blogging;Trusted_Connection=True;");
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
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
}
