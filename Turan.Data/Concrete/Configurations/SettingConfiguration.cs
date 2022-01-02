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
	public class SettingConfiguration : BaseConfiguration<Setting>
	{
		public override void Configure(EntityTypeBuilder<Setting> builder)
		{
			builder.Property(s => s.Description).IsRequired().HasMaxLength(MaxLengthSize.Description.ToInt());
			builder.Property(s => s.Keywords).IsRequired().HasMaxLength(MaxLengthSize.MetaKeyword.ToInt());
			builder.Property(s => s.Title).IsRequired().HasMaxLength(MaxLengthSize.Title.ToInt());


			base.Configure(builder);
		}
	}
}
