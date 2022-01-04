using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.DTOs.About
{
	public class AboutListDto : IDto
	{
		public ICollection<Concrete.About> Abouts { get; set; }
	}
}
