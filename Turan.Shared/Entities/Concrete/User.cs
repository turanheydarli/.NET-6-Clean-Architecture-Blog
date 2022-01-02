using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Shared.Entities.Concrete
{
	public class User : EntityBase
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string About { get; set; }
		public string ImagePath { get; set; }
		public string Email { get; set; }
		public byte[]? PasswordSalt { get; set; }
		public byte[]? PasswordHash { get; set; }

	}
}
