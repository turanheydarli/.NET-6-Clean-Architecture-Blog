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
	public class SocialManager : ISocialService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public SocialManager(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<IDataResult<SocialDto>> AddAsync(SocialAddDto socialAddDto)
		{
			Social socialToAdded = await _unitOfWork.Social.AddAsync(_mapper.Map<Social>(socialAddDto));

			await _unitOfWork.SaveAsync();

			return new SuccessDataResult<SocialDto>(_mapper.Map<SocialDto>(socialToAdded));
		}

		public async Task<IDataResult<ICollection<SocialDto>>> GetAllAsync()
		{
			return new SuccessDataResult<ICollection<SocialDto>>(
				_mapper.Map<ICollection<SocialDto>>(await _unitOfWork.Social.GetAllAsync()));
		}

		public async Task<IDataResult<SocialDto>> GetByIdAsync(int id)
		{
			return new SuccessDataResult<SocialDto>(_mapper.Map<SocialDto>(await _unitOfWork.Social.GetAsync(x => x.Id == id)));
		}

		public async Task<IDataResult<SocialDto>> UpdateAsync(SocialUpdateDto socialUpdateDto)
		{
			Social socialToUpdate = await _unitOfWork.Social.UpdateAsync(_mapper.Map<Social>(socialUpdateDto));

			await _unitOfWork.SaveAsync();

			return new SuccessDataResult<SocialDto>(_mapper.Map<SocialDto>(socialToUpdate));
		}
	}
}
