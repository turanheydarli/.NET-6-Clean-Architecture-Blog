using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.DTOs
{
	public class CommentUpdateDto : IDto
	{
		public int Id { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Text { get; set; }
		public Concrete.Comment Parent { get; set; }
		public Concrete.Article Article { get; set; }
	}
}
