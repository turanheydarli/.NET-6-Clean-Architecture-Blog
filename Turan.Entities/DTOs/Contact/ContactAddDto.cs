using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.DTOs.Contact
{
	public class ContactAddDto : IDto
	{
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
	}
}
