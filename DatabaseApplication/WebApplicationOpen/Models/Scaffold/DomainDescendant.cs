using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class DomainDescendant
	{
		public long DomainDescendantId { get; set; }
		public string Name { get; set; }
		public long DomainId { get; set; }
		public long RegistrantId { get; set; }
		public DateTime CreateDate { get; set; }
		public long? DomainDescendantContractId { get; set; }

		public virtual Domain Domain { get; set; }
		public virtual DomainDescendantContract DomainDescendantContract { get; set; }
		public virtual Registrant Registrant { get; set; }
	}
}
