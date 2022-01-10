using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.Concrete
{
	public class About : EntityBase
	{
		public string ImagePath { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string ShortContent { get; set; }
		public string Content { get; set; }
		public ICollection<Skill> Skills { get; set; }
	}
}
