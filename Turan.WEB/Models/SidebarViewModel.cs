using Turan.Entities.DTOs;

namespace Turan.WEB.Models
{
	public class SidebarViewModel
	{
		public ICollection<SocialDto> Socials { get; set; } = new List<SocialDto>();
		public AboutDto About { get; set; } = new AboutDto();
	}
}
