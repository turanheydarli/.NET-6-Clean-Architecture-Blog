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
	public class CommentConfiguration:BaseConfiguration<Comment>
	{
		public override void Configure(EntityTypeBuilder<Comment> builder)
		{
			builder.Property(c => c.Email).IsRequired();
			builder.Property(c => c.Text).IsRequired().HasMaxLength(MaxLengthSize.Description.ToInt());
			builder.Property(c => c.FullName).IsRequired().HasMaxLength(MaxLengthSize.Name.ToInt());

			base.Configure(builder);
		}
	}
}
