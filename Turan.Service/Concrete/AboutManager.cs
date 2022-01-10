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
	public class AboutManager : IAboutService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public AboutManager(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<IDataResult<AboutDto>> AddAsync(AboutAddDto aboutAddDto)
		{
			About aboutToAdd = await _unitOfWork.About.AddAsync(_mapper.Map<About>(aboutAddDto));
			await _unitOfWork.SaveAsync();

			return new SuccessDataResult<AboutDto>(_mapper.Map<AboutDto>(aboutToAdd));
		}

		public async Task<IDataResult<ICollection<AboutDto>>> GetAllAsync()
		{
			return new SuccessDataResult<ICollection<AboutDto>>(
				_mapper.Map<ICollection<AboutDto>>(await _unitOfWork.About.GetAllAsync()));
		}

		public async Task<IDataResult<AboutDto>> GetByIdAsync(int id)
		{
			return new SuccessDataResult<AboutDto>(
				_mapper.Map<AboutDto>(await _unitOfWork.About.GetAsync(a => a.Id == id)));
		}

		public async Task<IDataResult<AboutDto>> UpdateAsync(AboutUpdateDto aboutUpdateDto)
		{
			About aboutToUpdate = await _unitOfWork.About.UpdateAsync(_mapper.Map<About>(aboutUpdateDto));
			await _unitOfWork.SaveAsync();

			return new SuccessDataResult<AboutDto>(_mapper.Map<AboutDto>(aboutToUpdate));
		}
	}
}
