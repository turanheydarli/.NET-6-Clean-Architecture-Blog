using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.Concrete;
using Turan.Shared.Entities.Concrete;

namespace Turan.Data.Concrete.EntityFramework.Contexts
{
	public sealed class MsDbContext : ProjectDbContext
	{
        public MsDbContext(DbContextOptions<MsDbContext> options)
            : base(options)
        {
        }

    }
}
