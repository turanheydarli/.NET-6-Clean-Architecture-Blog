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
	public class ArticleConfiguration:BaseConfiguration<Article>
	{
		public override void Configure(EntityTypeBuilder<Article> builder)
		{
			builder.Property(a => a.Title).HasMaxLength(MaxLengthSize.Title.ToInt()).IsRequired();
			builder.Property(a => a.MetaDescription).HasMaxLength(MaxLengthSize.MetaDescription.ToInt()).IsRequired();
			builder.Property(a => a.MetaKeyword).HasMaxLength(MaxLengthSize.MetaKeyword.ToInt()).IsRequired();
			builder.Property(a => a.MetaTitle).HasMaxLength(MaxLengthSize.MetaTitle.ToInt()).IsRequired();
			builder.Property(a => a.ShortContent).HasMaxLength(MaxLengthSize.Description.ToInt()).IsRequired();
			builder.Property(a => a.ThumbnailPath).HasMaxLength(MaxLengthSize.Path.ToInt()).IsRequired();

			builder.HasOne<Category>(x => x.Category).WithMany(x => x.Articles).HasForeignKey(x => x.CategoryId);

			base.Configure(builder);
		}
	}
}
