using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turan.Shared.Entities.Abstract
{
	public abstract class EntityBase : IEntity
	{
		public virtual int Id { get; set; }
		public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
		public virtual DateTime? ModifiedTime { get; set; }
		public virtual bool IsActive { get; set; } = true;
		public virtual bool IsDeleted { get; set; } = false;
	}
}
