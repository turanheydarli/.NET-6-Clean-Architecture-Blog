using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.DTOs
{
	public class CategoryAddDto : IDto
	{
		public string Name { get; set; }
		public string Icon { get; set; }
		public ICollection<Concrete.Article> Articles { get; set; }
	}
}
