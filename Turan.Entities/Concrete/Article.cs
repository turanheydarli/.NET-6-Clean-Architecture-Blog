using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.Concrete
{
	public class Article : EntityBase
	{
		public string Title { get; set; }
		public string ShortContent { get; set; }
		public string Content { get; set; }
		public string MetaKeyword { get; set; }
		public string MetaDescription { get; set; }
		public string MetaTitle { get; set; }
		public int ViewsCount { get; set; }
		public string ThumbnailPath { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
		public ICollection<Comment> Comments { get; set; }

	}
}
