using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankApp.domain
{
	public class Clients
	{
		public Guid Id { get; set; }	
		public string IdType { get; set; }
		public int IdNumber { get; set; }
		public string NameClient { get; set; }
		public string LastNameClient { get; set; }
		public string EmailClient { get; set; }
		public DateTime BirthDate { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime ModificationDate  {	get; set; }
		public List<Accounts> Accounts { get; set; }
	}
	
}
