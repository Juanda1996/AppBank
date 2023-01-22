using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankApp.domain.Interfaces;
namespace BankApp.Aplications.Interfaces
{
	internal interface IBaseService<TEntity, TEntityID>
	: IAdd<TEntity>, IDelete<TEntityID>, IEdit<TEntity>, IList<TEntity, TEntityID>
	{
	}
}
