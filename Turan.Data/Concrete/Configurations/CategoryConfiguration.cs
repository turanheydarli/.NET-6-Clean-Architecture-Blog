using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.Concrete;
using Turan.Shared.Enums;
using Turan.Shared.Extensions;

namespace Turan.Data.Concrete.Configurations
{
	public class CategoryConfiguration : BaseConfiguration<Category>
	{
		public override void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.Property(c => c.Name).IsRequired().HasMaxLength(MaxLengthSize.Name.ToInt());


			base.Configure(builder);
		}
	}
}
