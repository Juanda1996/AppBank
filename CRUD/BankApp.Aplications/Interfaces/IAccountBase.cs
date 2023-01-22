using bankApp.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Aplications.Interfaces
{
	public interface IAccountBase<TEntity, TEntityID>
	: IAdd<TEntity>, IList<TEntity, TEntityID>
	{
		void CancelAccount(TEntity entity);
		void ChangeStatus(TEntity entity);
		void AddBalance(TEntity entity, decimal balance);
		void RemoveBalance(TEntity entity, decimal balance);
	}
}
