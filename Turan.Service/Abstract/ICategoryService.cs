﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.DTOs;
using Turan.Shared.Utilities.Results;

namespace Turan.Service.Abstract
{
	public interface ICategoryService
	{
		Task<IDataResult<CategoryDto>> GetByIdAsync(int id);
		Task<IDataResult<ICollection<CategoryDto>>> GetAllAsync();
		Task<IDataResult<CategoryDto>> AddAsync(CategoryAddDto categoryAddDto);
		Task<IDataResult<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto);
	}
}
