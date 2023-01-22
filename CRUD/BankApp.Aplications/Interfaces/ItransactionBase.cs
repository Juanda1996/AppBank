using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankApp.domain.Interfaces;

namespace BankApp.Aplications.Interfaces
{
	public interface ItransactionBase<TEntity,TEntityID,TAccount,TAccount2>:IAdd<TEntity>, IList<TEntity, TEntityID>
	{
		void deposit(TEntity entity, TAccount account, decimal amount);
		void withdraw(TEntity entity,TAccount account, decimal amount);
		void transfer(TEntity entity, TAccount account, TAccount2 account2, decimal amount);
	}
}
