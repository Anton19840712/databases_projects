using System;
using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class Registrant
	{
		public Registrant()
		{
			DomainDescendants = new HashSet<DomainDescendant>();
			Domains = new HashSet<Domain>();
		}

		public long RegistrantId { get; set; }
		public string Name { get; set; }
		public string ChiefName { get; set; }
		public long AddressId { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string PassportNumber { get; set; }
		public string PassportIssue { get; set; }
		public string PassportSeries { get; set; }
		public string PassportIssueDate { get; set; }
		public string PassportIdentificationNumber { get; set; }
		public string EgrNumber { get; set; }
		public string EgrRegistrant { get; set; }
		public string EgrDecisionNumber { get; set; }
		public string EgrDecisionDate { get; set; }
		public int ClientTypeId { get; set; }
		public string Unp { get; set; }
		public long? ClientId { get; set; }
		public DateTime? CreationDate { get; set; }
		public bool? IsObject { get; set; }
		public bool? IsProtected { get; set; }

		public virtual AddressDal Address { get; set; }
		public virtual ClientType ClientType { get; set; }
		public virtual ICollection<DomainDescendant> DomainDescendants { get; set; }
		public virtual ICollection<Domain> Domains { get; set; }
	}
}
