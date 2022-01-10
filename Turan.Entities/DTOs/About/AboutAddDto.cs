using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.Concrete;

namespace Turan.Entities.DTOs
{
	public class AboutAddDto
	{
		public string ImagePath { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string ShortContent { get; set; }
		public string Content { get; set; }
		public ICollection<Concrete.Skill> Skills { get; set; }
	}
}
