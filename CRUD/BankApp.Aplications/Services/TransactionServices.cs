using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using bankApp.domain;
using bankApp.domain.Interfaces.Repositories;
using BankApp.Aplications.Interfaces;

namespace BankApp.Aplications.Services
{
	public class TransactionServices : ItransactionBase<Transactions, Guid, Accounts, Accounts>
	{
		IRepositoryAccount<Accounts,Guid> accountRepository;
		IRepositoryTransactions<Transactions, Guid> transactionsRepository;

		public TransactionServices(IRepositoryAccount<Accounts, Guid> _accountRepository, IRepositoryTransactions<Transactions, Guid> _transactionsRepository)
		{
			accountRepository = _accountRepository;
			transactionsRepository = _transactionsRepository;
		}
		public Transactions Add(Transactions entity)
		{
			if (entity == null)
				throw new NullReferenceException("You can't create an empty transaction");
			var addTransaction = transactionsRepository.Add(entity);
			return addTransaction;
		}
		public void deposit(Transactions entity, Accounts account, decimal amount)
		{
			accountRepository.AddBalance(account, amount);
			entity.TransactionType = "Deposit";
			entity.Amount = amount;
			entity.StarterAccount = account;
			entity.EnderAccount= account;

		}

		public List<Transactions> GetAll()
		{
			return transactionsRepository.GetAll();
		}

		public Transactions SelectionByID(Guid entityID)
		{
			return transactionsRepository.SelectionByID(entityID);
		}

		public void transfer(Transactions entity, Accounts account, Accounts account2, decimal amount)
		{
			accountRepository.RemoveBalance(account, amount);
			accountRepository.AddBalance(account2, amount);
			entity.TransactionType = "Transfer";
			entity.Amount = amount;
			entity.StarterAccount = account;
			entity.EnderAccount = account2;
		}

		public void withdraw(Transactions entity, Accounts account, decimal amount)
		{
			accountRepository.RemoveBalance(account, amount);
			entity.TransactionType = "Withdraw";
			entity.Amount = amount;
			entity.StarterAccount = account;
			entity.EnderAccount = account;
		}

		

		
	}
}
