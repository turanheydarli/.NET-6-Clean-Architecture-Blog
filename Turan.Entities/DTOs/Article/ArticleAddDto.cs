﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.Concrete;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.DTOs
{
	public class ArticleAddDto : IDto
	{
		public string Title { get; set; } 
		public string ShortContent { get; set; }
		public string Content { get; set; }
		public string MetaKeyword { get; set; }
		public string MetaDescription { get; set; }
		public string MetaTitle { get; set; }
		public int ViewsCount { get; set; }
		public string ThumbnailPath { get; set; }
		public Concrete.Category Category { get; set; }
	}
}
