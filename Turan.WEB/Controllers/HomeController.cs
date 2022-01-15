using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using Turan.Service.Abstract;
using Turan.WEB.Models;

namespace Turan.WEB.Controllers
{
	public class HomeController : Controller
	{
		private IArticleService _articleService;

		public HomeController(IArticleService articleService)
		{
			_articleService = articleService;
		}

		public async Task<IActionResult> Index()
		{
			HomeViewModel viewModel = new HomeViewModel
			{
				Articles = (await _articleService.GetAllAsync()).Data.OrderByDescending(x => x.Id).Take(8).ToList(),
			};

			return View(viewModel);
		}

	}
}