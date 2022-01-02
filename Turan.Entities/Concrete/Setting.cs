using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.Concrete
{
	public class Setting : EntityBase
	{
		public string Title { get; set; }
		public string Keywords { get; set; }
		public string Description { get; set; }
		public string LogoPath { get; set; }
	}
}
