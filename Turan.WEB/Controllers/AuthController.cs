using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using Turan.Service.Abstract;
using Turan.Shared.Entities.DTOs.UserDTOs;
using Turan.Shared.Enums;
using Turan.WEB.Models;

namespace Turan.WEB.Controllers
{
	public class AuthController : Controller
	{
		private IUserService _userService;
		private RoleManager<IdentityRole> _rm;
		public AuthController(IUserService userService, RoleManager<IdentityRole> rm)
		{
			_rm = rm;
			_userService = userService;
		}
		#region Register
		[HttpGet(nameof(Register))]
		public IActionResult Register()
		{
			if (User.Identity.IsAuthenticated)
				return RedirectToAction("Home", "Index");


			return View();
		}

		[HttpPost(nameof(Register))]
		public async Task<IActionResult> Register(UserRegisterDto userRegisterDto)
		{
			if (!ModelState.IsValid)
			{
				return View(userRegisterDto);
			}

			IdentityResult identityResult = (await _userService.RegiserAsync(userRegisterDto)).Data;


			if (!identityResult.Succeeded)
			{
				foreach (var error in identityResult.Errors)
				{
					ModelState.AddModelError("", error.Description);
				}

				return View(userRegisterDto);
			}

			return RedirectToAction("Index", "Home");
		}
		#endregion

		#region Login
		[HttpGet(nameof(Login))]
		public IActionResult Login()
		{
			if (User.Identity.IsAuthenticated)
				return RedirectToAction("Index", "Home");


			return View();
		}

		[HttpPost(nameof(Login))]
		public async Task<IActionResult> Login(UserLoginDto userLoginDto)
		{

			if (!ModelState.IsValid)
			{
				return View();
			}

			Microsoft.AspNetCore.Identity.SignInResult signInResult = (await _userService.LoginAsync(userLoginDto)).Data;

			if (!signInResult.Succeeded)
			{
				ModelState.AddModelError("", "Username or password is wrong");

				return View();
			}

			if (signInResult.IsLockedOut)
			{
				ModelState.AddModelError("", "Your account was bloked, please, wait few minutes");
				return View();
			}

			return RedirectToAction("Index", "Home");
		}
		#endregion

		public async Task Index()
		{
			if (!(await _rm.RoleExistsAsync(UserRoles.Admin.ToString())))
			{
				await _rm.CreateAsync(new IdentityRole { Name = UserRoles.Admin.ToString() });
			}
			if (!(await _rm.RoleExistsAsync(UserRoles.User.ToString())))
			{
				await _rm.CreateAsync(new IdentityRole { Name = UserRoles.User.ToString() });
			}
		}


	}
}