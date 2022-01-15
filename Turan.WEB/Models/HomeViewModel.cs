using Turan.Entities.DTOs;

namespace Turan.WEB.Models
{
	public class HomeViewModel
	{
		public ICollection<ArticleDto> Articles { get; set; }
	}
}
