using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.DTOs.Skill
{
	public class SkillAddDto : IDto
	{
		public string Title { get; set; }
		public decimal PercentageValue { get; set; }
	}
}
