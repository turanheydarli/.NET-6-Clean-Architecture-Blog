using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.Concrete
{
	public class Social : EntityBase
	{
		public string Icon { get; set; }
		public string Name { get; set; }
		public string Url { get; set; }
	}
}
