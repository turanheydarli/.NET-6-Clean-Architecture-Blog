using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.Concrete
{
	public class Category : EntityBase
	{
		public string Name { get; set; }
		public string Icon { get; set; }
		public ICollection<Article> Articles { get; set; }
		
	}
}
