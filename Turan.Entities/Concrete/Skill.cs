using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.Concrete
{
	public class Skill : EntityBase
	{
		public string Title { get; set; }
		public decimal PercentageValue { get; set; }
	}
}
