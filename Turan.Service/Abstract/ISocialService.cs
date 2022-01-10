using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.DTOs;
using Turan.Shared.Utilities.Results;

namespace Turan.Service.Abstract
{
	public interface ISocialService
	{
		Task<IDataResult<SocialDto>> GetByIdAsync(int id);
		Task<IDataResult<ICollection<SocialDto>>> GetAllAsync();
		Task<IDataResult<SocialDto>> AddAsync(SocialAddDto socialAddDto);
		Task<IDataResult<SocialDto>> UpdateAsync(SocialUpdateDto socialUpdateDto);
	}
}
