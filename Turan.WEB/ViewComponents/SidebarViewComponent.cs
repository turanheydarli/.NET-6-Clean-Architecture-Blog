using Microsoft.AspNetCore.Mvc;
using Turan.Service.Abstract;
using Turan.WEB.Models;

namespace Turan.WEB.ViewComponents
{
	public class SidebarViewComponent : ViewComponent
	{
		IAboutService _aboutService;
		ISocialService _socialService;

		public SidebarViewComponent(IAboutService aboutService, ISocialService socialService)
		{
			_aboutService = aboutService;
			_socialService = socialService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			SidebarViewModel viewModel = new SidebarViewModel
			{
				About = (await _aboutService.GetAllAsync()).Data.FirstOrDefault(),
				Socials = (await _socialService.GetAllAsync()).Data
			};

			return View(viewModel);
		}
	}
}
