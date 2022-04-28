using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("SslApiQueue")]
	public class SslApiQueueDal
	{
		[Key]
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

		public virtual ClientTypeDal ClientType { get; set; }
		public virtual CountryDal Country { get; set; }
		public virtual OrderActionDal OrderAction { get; set; }
		public virtual ServiceDal Service { get; set; }
		public virtual SslCertificateTypeDal SslCertificateType { get; set; }
	}
}
