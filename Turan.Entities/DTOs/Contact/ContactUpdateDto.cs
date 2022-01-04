using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.DTOs.Contact
{
	public class ContactUpdateDto : IDto
	{
		public int Id { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
	}
}
