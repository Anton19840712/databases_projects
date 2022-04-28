using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("ClientInfoForSslOrder")]
	public class ClientInfoForSslOrderDal
	{
		[Key]
		public long Id { get; set; }
		public int ClientTypeId { get; set; }
		public int CountryId { get; set; }
		public long ServiceId { get; set; }
		public long ClientId { get; set; }
		public string Name { get; set; }
		public string City { get; set; }
		public string Region { get; set; }
		public string PostalCode { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string OrganizationName { get; set; }
		public string Address { get; set; }

		public virtual ClientDal Client { get; set; }
		public virtual ClientTypeDal ClientType { get; set; }
		public virtual CountryDal Country { get; set; }
		public virtual ServiceDal Service { get; set; }
	}
}
