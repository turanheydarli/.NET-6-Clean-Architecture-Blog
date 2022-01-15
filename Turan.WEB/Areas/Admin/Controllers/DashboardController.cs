using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Turan.Entities.DTOs;
using Turan.Shared.Enums;

namespace Turan.WEB.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = "Admin")]
	public class DashboardController : Controller
	{
		ISettingService
		public IActionResult Index()
		{
			return View();
		}

		[Route("admin/settings")]
		public IActionResult Settings()
		{
			return View();
		}

		[HttpPost("admin/settings")]
		public IActionResult Settings(SettingDto settingDto)
		{

			return View();
		}

	}
}
