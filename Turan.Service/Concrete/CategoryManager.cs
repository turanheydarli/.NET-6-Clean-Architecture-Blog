using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Data.Abstract;
using Turan.Entities.Concrete;
using Turan.Entities.DTOs;
using Turan.Service.Abstract;
using Turan.Shared.Utilities.Results;

namespace Turan.Service.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public CategoryManager(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}
		public async Task<IDataResult<CategoryDto>> AddAsync(CategoryAddDto categoryAddDto)
		{
			Category categoryToAdd = await _unitOfWork.Category.AddAsync(_mapper.Map<Category>(categoryAddDto));
			await _unitOfWork.SaveAsync();

			return new SuccessDataResult<CategoryDto>(_mapper.Map<CategoryDto>(categoryToAdd));
		}

		public async Task<IDataResult<ICollection<CategoryDto>>> GetAllAsync()
		{
			return new SuccessDataResult<ICollection<CategoryDto>>(
				_mapper.Map<ICollection<CategoryDto>>(await _unitOfWork.Category.GetAllAsync()));
		}

		public async Task<IDataResult<CategoryDto>> GetByIdAsync(int id)
		{
			return new SuccessDataResult<CategoryDto>(
				_mapper.Map<CategoryDto>(await _unitOfWork.Category.GetAsync(a => a.Id == id)));
		}

		public async Task<IDataResult<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto)
		{
			Category categoryToUpdate = await _unitOfWork.Category.UpdateAsync(_mapper.Map<Category>(categoryUpdateDto));
			await _unitOfWork.SaveAsync();

			return new SuccessDataResult<CategoryDto>(_mapper.Map<CategoryDto>(categoryToUpdate));
		}
	}
}
