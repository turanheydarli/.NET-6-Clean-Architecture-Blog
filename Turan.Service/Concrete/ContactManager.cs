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
	public class ContactManager : IContactService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public ContactManager(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}
		public async Task<IDataResult<ContactDto>> AddAsync(ContactAddDto contactAddDto)
		{
			Contact contactToAdd = await _unitOfWork.Contact.AddAsync(_mapper.Map<Contact>(contactAddDto));
			await _unitOfWork.SaveAsync();

			return new SuccessDataResult<ContactDto>(_mapper.Map<ContactDto>(contactToAdd));
		}

		public async Task<IDataResult<ICollection<ContactDto>>> GetAllAsync()
		{
			return new SuccessDataResult<ICollection<ContactDto>>(
				_mapper.Map<ICollection<ContactDto>>(await _unitOfWork.Contact.GetAllAsync()));
		}

		public async Task<IDataResult<ContactDto>> GetByIdAsync(int id)
		{
			return new SuccessDataResult<ContactDto>(
				_mapper.Map<ContactDto>(await _unitOfWork.Contact.GetAsync(a => a.Id == id)));
		}

		public async Task<IDataResult<ContactDto>> UpdateAsync(ContactUpdateDto contactUpdateDto)
		{
			Contact contactToUpdate = await _unitOfWork.Contact.UpdateAsync(_mapper.Map<Contact>(contactUpdateDto));
			await _unitOfWork.SaveAsync();

			return new SuccessDataResult<ContactDto>(_mapper.Map<ContactDto>(contactToUpdate));
		}
	}
}
