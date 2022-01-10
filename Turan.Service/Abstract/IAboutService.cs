using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.DTOs;
using Turan.Shared.Utilities.Results;

namespace Turan.Service.Abstract
{
	public interface IAboutService
	{
		Task<IDataResult<AboutDto>> GetByIdAsync(int id);
		Task<IDataResult<ICollection<AboutDto>>> GetAllAsync();
		Task<IDataResult<AboutDto>> AddAsync(AboutAddDto aboutAddDto);
		Task<IDataResult<AboutDto>> UpdateAsync(AboutUpdateDto aboutUpdateDto);
	}
}
