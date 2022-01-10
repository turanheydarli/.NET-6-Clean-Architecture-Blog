using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.DTOs;
using Turan.Shared.Utilities.Results;

namespace Turan.Service.Abstract
{
	public interface IContactService
	{
		Task<IDataResult<ContactDto>> GetByIdAsync(int id);
		Task<IDataResult<ICollection<ContactDto>>> GetAllAsync();
		Task<IDataResult<ContactDto>> AddAsync(ContactAddDto contactAddDto);
		Task<IDataResult<ContactDto>> UpdateAsync(ContactUpdateDto contactUpdateDto);
	}
}
