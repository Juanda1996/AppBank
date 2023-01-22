﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankApp.domain.Interfaces;

namespace bankApp.domain.Interfaces.Repositories
{
	public interface IRepositoryAccount<TEntity, TEntityID> : IAdd<TEntity>, IList<TEntity, TEntityID>, ISave
	{
		void CancelAccount(TEntity entity);
		void ChangeStatus(TEntity entity);
		void AddBalance(TEntity entity, decimal balance);
		void RemoveBalance(TEntity entity, decimal balance);
	}
}
