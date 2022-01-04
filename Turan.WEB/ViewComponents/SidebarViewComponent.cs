using Microsoft.AspNetCore.Mvc;

namespace Turan.WEB.ViewComponents
{
	public class SidebarViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
