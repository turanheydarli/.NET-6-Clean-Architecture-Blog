using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.Concrete;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.DTOs.About
{
	public class AboutUpdateDto : IDto
	{
		public int Id { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public string Content { get; set; }
		public ICollection<Concrete.Skill> Skills { get; set; }
	}
}
