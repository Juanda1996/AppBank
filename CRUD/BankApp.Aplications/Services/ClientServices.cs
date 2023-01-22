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
	public class ClientServices : IBaseService<Clients, Guid>
	{
		private readonly IBaseRepository<Clients, Guid> clientRepo;

		public ClientServices (IBaseRepository<Clients, Guid> clientRepo)
		{
			this.clientRepo = clientRepo;
		}

		public Clients Add(Clients entity)
		{
			if (entity == null)
				throw new ArgumentNullException("'Client' required");
			var resultClient = clientRepo.Add(entity);
			clientRepo.SaveChanges();
			return resultClient;
		}

		public void Delete(Guid entityID)
		{
			clientRepo.Delete(entityID);
			clientRepo.SaveChanges();
		}

		public void Edit(Clients entity)
		{
			if (entity == null)
				throw new ArgumentNullException("'Client' is required for editing");
			clientRepo.Edit(entity);
			clientRepo.SaveChanges();
		}

		public List<Clients> GetAll()
		{
			return clientRepo.GetAll();
		}

		public Clients SelectionByID(Guid entityID)
		{
			return clientRepo.SelectionByID(entityID);
		}
	}
}
