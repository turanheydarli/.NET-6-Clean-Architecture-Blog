using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.Concrete
{
	public class Contact : EntityBase
	{
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
	}
}
