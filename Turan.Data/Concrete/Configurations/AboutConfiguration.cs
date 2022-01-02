using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.Concrete;

namespace Turan.Data.Concrete.Configurations
{
	public class AboutConfiguration : BaseConfiguration<About>
	{
		public override void Configure(EntityTypeBuilder<About> builder)
		{
			builder.Property(a => a.Content).IsRequired().HasColumnType("NVARCHAR(MAX)");

			base.Configure(builder);	
		}
	}
}
