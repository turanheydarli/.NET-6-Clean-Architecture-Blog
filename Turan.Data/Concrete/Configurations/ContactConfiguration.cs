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
	public class ContactConfiguration : BaseConfiguration<Contact>
	{
		public override void Configure(EntityTypeBuilder<Contact> builder)
		{
			builder.Property(c => c.FullName).IsRequired().HasMaxLength(MaxLengthSize.Name.ToInt());
			builder.Property(c => c.Email).IsRequired();
			builder.Property(c => c.Subject).IsRequired();
			builder.Property(c => c.Message).IsRequired().HasMaxLength(MaxLengthSize.Description.ToInt());

			base.Configure(builder);	
		}
	}
}
