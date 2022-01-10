using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.Concrete;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.DTOs
{
	public class AboutDto : IDto
	{
		public int Id { get; set; }
		public DateTime CreatedTime { get; set; }
		public DateTime? ModifiedTime { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public string ImagePath { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string ShortContent { get; set; }
		public string Content { get; set; }
		public ICollection<Concrete.Skill> Skills { get; set; }
	}
}
