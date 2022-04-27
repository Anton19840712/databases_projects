using System;
using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class DomainDescendantContract
	{
		public DomainDescendantContract()
		{
			DomainDescendants = new HashSet<DomainDescendant>();
		}

		public long DescendantContractId { get; set; }
		public string ApplicantPosition { get; set; }
		public string ApplicantName { get; set; }
		public string ContractNumber { get; set; }
		public DateTime? OrderDate { get; set; }
		public DateTime? ValidityDate { get; set; }

		public virtual ICollection<DomainDescendant> DomainDescendants { get; set; }
	}
}
