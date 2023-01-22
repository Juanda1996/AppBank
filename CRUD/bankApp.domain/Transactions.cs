using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankApp.domain
{
	public class Transactions
	{
		public Guid Id { get; set; }
		public string TransactionType { get; set; }
		public decimal Amount { get; set; }
		public Accounts StarterAccount { get; set; }
		public Accounts EnderAccount { get; set; }


	}
}
