using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.Concrete;
using Turan.Entities.DTOs;

namespace Turan.Service.Helpers
{
	public class AutoMapperHelper : Profile
	{
        public AutoMapperHelper()
        {
            CreateMap<About, AboutDto>().ReverseMap();
            CreateMap<About, AboutAddDto>().ReverseMap();
            CreateMap<About, AboutUpdateDto>().ReverseMap();

            CreateMap<Social, SocialUpdateDto>().ReverseMap();
            CreateMap<Social, SocialAddDto>().ReverseMap();
            CreateMap<Social, SocialDto>().ReverseMap();

            CreateMap<Article, ArticleUpdateDto>().ReverseMap();
            CreateMap<Article, ArticleAddDto>().ReverseMap();
            CreateMap<Article, ArticleDto>().ReverseMap();

            CreateMap<Category, CategoryUpdateDto>().ReverseMap();
            CreateMap<Category, CategoryAddDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Comment, CommentUpdateDto>().ReverseMap();
            CreateMap<Comment, CommentAddDto>().ReverseMap();
            CreateMap<Comment, CommentDto>().ReverseMap();

            CreateMap<Contact, ContactUpdateDto>().ReverseMap();
            CreateMap<Contact, ContactAddDto>().ReverseMap();
            CreateMap<Contact, ContactDto>().ReverseMap();

            CreateMap<Skill, SkillUpdateDto>().ReverseMap();
            CreateMap<Skill, SkillAddDto>().ReverseMap();
            CreateMap<Skill, SkillDto>().ReverseMap();

            CreateMap<Setting, SettingUpdateDto>().ReverseMap();
            CreateMap<Setting, SettingAddDto>().ReverseMap();
            CreateMap<Setting, SettingDto>().ReverseMap();
        }
    }
}
