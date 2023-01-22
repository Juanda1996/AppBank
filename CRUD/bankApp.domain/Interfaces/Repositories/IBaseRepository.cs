using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using bankApp.domain.Interfaces;

namespace bankApp.domain.Interfaces.Repositories
{
	public interface IBaseRepository<TEntity,TEntityID>
	: IAdd<TEntity>, IEdit<TEntity>, IDelete<TEntityID>, IList<TEntity,TEntityID>, ISave
	{

	}
}
