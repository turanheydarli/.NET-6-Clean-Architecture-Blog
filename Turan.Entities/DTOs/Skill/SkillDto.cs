using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.DTOs.Skill
{
	public class SkillDto : IDto
	{
		public int Id { get; set; }
		public DateTime CreatedTime { get; set; }
		public DateTime? ModifiedTime { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public string Title { get; set; }
		public decimal PercentageValue { get; set; }
	}
}
