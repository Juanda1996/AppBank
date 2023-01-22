using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankApp.domain.Interfaces;

namespace bankApp.domain.Interfaces.Repositories
{
	public interface IRepositoryTransactions<TEntity, TEntityID>: IAdd<TEntity>, IList<TEntity,TEntityID> , ISave
	{
		void deposit(TEntity entity, decimal amount);
		void withdraw(TEntity entity, decimal amount);
		void transfer(TEntity entity, decimal amount);
	}
}
