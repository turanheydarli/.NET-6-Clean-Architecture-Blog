using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.Concrete
{
	public class Comment : EntityBase
	{
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Text { get; set; }
		public int? ParentId { get; set; }
		public Comment Parent { get; set; }
		public Article Article { get; set; }
	}
}
