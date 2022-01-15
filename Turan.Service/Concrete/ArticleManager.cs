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
	public class ArticleManager : IArticleService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public ArticleManager(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}
		public async Task<IDataResult<ArticleDto>> AddAsync(ArticleAddDto articleAddDto)
		{
			Article articleToAdd = await _unitOfWork.Article.AddAsync(_mapper.Map<Article>(articleAddDto));
			await _unitOfWork.SaveAsync();

			return new SuccessDataResult<ArticleDto>(_mapper.Map<ArticleDto>(articleToAdd));
		}

		public async Task<IDataResult<CommentDto>> AddCommentAsync(CommentAddDto commentAddDto)
		{
			Comment commentToAdd = await _unitOfWork.Comment.AddAsync(_mapper.Map<Comment>(commentAddDto));
			await _unitOfWork.SaveAsync();

			return new SuccessDataResult<CommentDto>(_mapper.Map<CommentDto>(commentToAdd));
		}

		public async Task<IDataResult<ICollection<ArticleDto>>> GetAllAsync()
		{
			return new SuccessDataResult<ICollection<ArticleDto>>(
				_mapper.Map<ICollection<ArticleDto>>(await 
				_unitOfWork.Article.GetAllAsync(x => !x.IsDeleted, a => a.Category, a => a.Comments)));
		}

		public async Task<IDataResult<ArticleDto>> GetByIdAsync(int id)
		{
			return new SuccessDataResult<ArticleDto>(
				_mapper.Map<ArticleDto>(await _unitOfWork.Article.GetAsync(a => a.Id == id)));
		}

		public async Task<IDataResult<ArticleDto>> UpdateAsync(ArticleUpdateDto articleUpdateDto)
		{
			Article articleToUpdate = await _unitOfWork.Article.UpdateAsync(_mapper.Map<Article>(articleUpdateDto));
			await _unitOfWork.SaveAsync();

			return new SuccessDataResult<ArticleDto>(_mapper.Map<ArticleDto>(articleToUpdate));
		}
	}
}
