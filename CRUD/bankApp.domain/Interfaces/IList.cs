using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankApp.domain.Interfaces
{
	public interface IList<TEntity, TEntityID>
	{
		List<TEntity> GetAll();
		TEntity SelectionByID(TEntityID entityID);
	}
}
