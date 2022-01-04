using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.Concrete;

namespace Turan.Entities.DTOs.About
{
	public class AboutAddDto
	{
		public string Content { get; set; }
		public ICollection<Concrete.Skill> Skills { get; set; }
	}
}
