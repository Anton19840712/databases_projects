

namespace WebApplicationOpen.Models.Scaffold
{
	public class SslApiQueue
	{
		public long Id { get; set; }
		public string ProductName { get; set; }
		public int Period { get; set; }
		public string ServerName { get; set; }
		public string ApproverEmail { get; set; }
		public string ValidMethod { get; set; }
		public string Phone { get; set; }
		public string PostalCode { get; set; }
		public string Name { get; set; }
		public string OrganizationName { get; set; }
		public string Email { get; set; }
		public string City { get; set; }
		public string Region { get; set; }
		public string DomainName { get; set; }
		public long ServiceId { get; set; }
		public int CountryId { get; set; }
		public int ClientTypeId { get; set; }
		public int Counter { get; set; }
		public string Address { get; set; }
		public int SslCertificateTypeId { get; set; }
		public bool HasSubDomains { get; set; }
		public int OrderActionId { get; set; }

		public virtual ClientType ClientType { get; set; }
		public virtual Country Country { get; set; }
		public virtual OrderAction OrderAction { get; set; }
		public virtual Service Service { get; set; }
		public virtual SslCertificateType SslCertificateType { get; set; }
	}
}
