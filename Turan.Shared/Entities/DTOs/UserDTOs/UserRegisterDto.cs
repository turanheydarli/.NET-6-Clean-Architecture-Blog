using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Shared.Entities.DTOs.UserDTOs
{
	public class UserRegisterDto : IDto
	{
		[Required(), MaxLength(20)]
		public string UserName { get; set; }

		[Required(), MaxLength(20)]
		public string FirstName { get; set; }

		[Required(), MaxLength(20)]
		public string LastName { get; set; }

		[Required(), DataType(DataType.Password)]
		public string Password { get; set; }

		[Required(), DataType(DataType.Password), Compare(nameof(Password))]
		public string ConfirmPassword { get; set; }

		[Required(), DataType(DataType.EmailAddress)]
		public string Email { get; set; }
	}
}
