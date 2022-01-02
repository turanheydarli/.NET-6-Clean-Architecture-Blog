using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Data.Concrete.Configurations
{
	public class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : EntityBase
	{
		public virtual void Configure(EntityTypeBuilder<TEntity> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.IsActive).IsRequired();
			builder.Property(x => x.IsDeleted).IsRequired();
		}

	}
}
