﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Data.Abstract;
using Turan.Data.Concrete.EntityFramework.Contexts;
using Turan.Entities.Concrete;
using Turan.Shared.Data.Concrete.EntityFramework;

namespace Turan.Data.Concrete.EntityFramework
{
	public class EfSkillRepository : EfEntityRepositoryBase<Skill, MsDbContext>, ISkillRepository
	{
		public EfSkillRepository(MsDbContext context) : base(context)
		{
		}
	}
}
