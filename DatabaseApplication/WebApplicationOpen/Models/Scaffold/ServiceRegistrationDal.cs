using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("ServiceRegistration")]
	public class ServiceRegistrationDal
	{
		public long ServiceRegistrationId { get; set; }
		public long ClientId { get; set; }
		public long? ParentServiceId { get; set; }
		public int ServiceRegistrationStatusId { get; set; }
		public string DomainName { get; set; }
		public long? HostingServerId { get; set; }
		public int RegistrationOwnershipId { get; set; }
		public string Description { get; set; }
		public string ManagerComment { get; set; }
		public string RegistrationNumber { get; set; }
		public long? TaxServiceId { get; set; }

		public virtual ClientDal Client { get; set; }
		public virtual HostingServerDal HostingServer { get; set; }
		public virtual ServiceDal ParentService { get; set; }
		public virtual RegistrationOwnershipDal RegistrationOwnership { get; set; }
		public virtual ServiceRegistrationStatusDal ServiceRegistrationStatus { get; set; }
		public virtual ServiceDal TaxService { get; set; }
	}
}
