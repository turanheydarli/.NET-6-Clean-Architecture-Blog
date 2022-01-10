using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.DTOs;
using Turan.Shared.Utilities.Results;

namespace Turan.Service.Abstract
{
	public interface IArticleService
	{
		Task<IDataResult<ArticleDto>> GetByIdAsync(int id);
		Task<IDataResult<ICollection<ArticleDto>>> GetAllAsync();
		Task<IDataResult<ArticleDto>> AddAsync(ArticleAddDto articleAddDto);
		Task<IDataResult<CommentDto>> AddCommentAsync(CommentAddDto commentAddDto);
		Task<IDataResult<ArticleDto>> UpdateAsync(ArticleUpdateDto articleUpdateDto);
	}
}
