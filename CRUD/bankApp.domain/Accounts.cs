using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bankApp.domain
{
	public class Accounts
	{
		public Guid Id { get; set; }
		public int AccountType { get; set; }
		public int AccoutNumber { get; set; }
		public bool AccountState { get; set; } = true;
		public bool AccountCancel { get; set; }= false;
		public decimal AccountAmount { get; set; } = 0;
		public bool GMFExemption { get; set; }
		public DateTime AccountCreation { get; set; }
		public DateTime AccountModificationDate { get; set; }
		public Clients Client { get; set; }
		public List<Transactions> Transactions { get; set; }
		
	}
}
