using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Shared.Entities.DTOs.UserDTOs;
using Turan.Shared.Utilities.Results;

namespace Turan.Service.Abstract
{
	public interface IUserService
	{
		Task<IDataResult<IdentityResult>> RegiserAsync(UserRegisterDto userRegisterDto);
		Task<IDataResult<SignInResult>> LoginAsync(UserLoginDto userLoginDto);
	}
}
