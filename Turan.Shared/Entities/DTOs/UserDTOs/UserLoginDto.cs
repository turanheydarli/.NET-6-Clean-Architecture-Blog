using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.Abstract;

namespace Turan.Shared.Entities.DTOs.UserDTOs
{
	public class UserLoginDto : IDto
	{
		[Required(), MaxLength(20)]
		public string UserName { get; set; }
		
		[Required(), DataType(DataType.Password)]
		public string Password { get; set; }

		public bool Remember { get; set; }


	}
}
