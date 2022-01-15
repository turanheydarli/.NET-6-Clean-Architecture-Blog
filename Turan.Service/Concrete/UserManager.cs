using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Service.Abstract;
using Turan.Shared.Entities.Concrete;
using Turan.Shared.Entities.DTOs.UserDTOs;
using Turan.Shared.Enums;
using Turan.Shared.Utilities.Results;

namespace Turan.Service.Concrete
{
	public class UserManager : IUserService
	{
		private readonly UserManager<User> _userManager;
		private readonly SignInManager<User> _signInManager;
		private readonly IMapper _mapper;
		public UserManager(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper)
		{
			_signInManager = signInManager;
			_userManager = userManager;
			_mapper = mapper;
		}

		public async Task<IDataResult<SignInResult>> LoginAsync(UserLoginDto userLoginDto)
		{
			User user = await _userManager.FindByNameAsync(userLoginDto.UserName);

			if (user == null)
			{
				return new ErrorDataResult<SignInResult>(SignInResult.Failed);
			}

			SignInResult signInResult = await _signInManager.PasswordSignInAsync(user, userLoginDto.Password, true, true);

			if(!signInResult.Succeeded)
				return  new ErrorDataResult<SignInResult>(signInResult);

			return new SuccessDataResult<SignInResult>(signInResult);
		}

		public async Task<IDataResult<IdentityResult>> RegiserAsync(UserRegisterDto userRegisterDto)
		{
			User user = _mapper.Map<User>(userRegisterDto);
			IdentityResult identityResult = await _userManager.CreateAsync(user, userRegisterDto.Password);

			if (!identityResult.Succeeded)
			{
				return new ErrorDataResult<IdentityResult>(identityResult);
			}

			await _userManager.AddToRoleAsync(user, UserRoles.Admin.ToString());

			return new SuccessDataResult<IdentityResult>(identityResult);
		}
	}
}
