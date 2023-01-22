using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankApp.domain;
using bankApp.domain.Interfaces.Repositories;
using BankApp.Aplications.Interfaces;
namespace BankApp.Aplications.Services
{
	public class AccountServices : IAccountBase<Accounts, Guid>
	{
		IRepositoryAccount<Accounts, Guid> accountRepo;
		IBaseRepository<Clients, Guid> clientRepo;

		public AccountServices(IRepositoryAccount<Accounts, Guid>_accountRepo,
			IBaseRepository<Clients,Guid>_clientRepo) 
		{
			accountRepo = _accountRepo;
			clientRepo = _clientRepo;
		}

		public Accounts Add(Accounts entity)
		{
			if (entity == null)
				throw new ArgumentNullException("'Account' cannot be null");
			var addAccount = accountRepo.Add(entity);
			
			if(clientRepo.SelectionByID(entity.Client.Id) == null)
				throw new NullReferenceException("The client associated to this account does not exist");
			return addAccount;
		}

		public List<Accounts> GetAll()
		{
			return accountRepo.GetAll();
		}

		public Accounts SelectionByID(Guid entityID)
		{
			return accountRepo.SelectionByID(entityID);
		}

		public void CancelAccount(Accounts entity) 
		{
			if (entity == null)
				throw new NullReferenceException("You cannot cancel a non existant account");
			if (entity.AccountAmount != 0)
				throw new ArgumentException("You cannot cancel an account with a balance different from 0");
			entity.AccountCancel = true;
		}
		public void ChangeStatus(Accounts entity) 
		{
			if (entity == null)
				throw new NullReferenceException("You cannot change the state of a non existant account");
			entity.AccountState = !entity.AccountState;
		}

		public void AddBalance(Accounts entity, decimal balance) 
		{
			if (entity == null)
				throw new NullReferenceException("You cannot add founds to a non existance account");
			entity.AccountAmount += balance;
		}

		public void RemoveBalance(Accounts entity, decimal balance)
		{
			if (entity == null)
				throw new NullReferenceException("You cannot add founds to a non existance account");
			if (entity.AccountAmount - balance < 0)
				throw new ArgumentException("You can't remove more than the actual balance of the account");
			entity.AccountAmount -= balance;
		}

	}
}
