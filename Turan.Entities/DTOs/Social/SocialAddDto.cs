using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.DTOs
{
	public class SocialAddDto : IDto
	{
		public string Icon { get; set; }
		public string Name { get; set; }
		public string Url { get; set; }
	}
}
