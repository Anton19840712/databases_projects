

namespace WebApplicationOpen.Models.Scaffold
{
	public class ServiceRegistration
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
		public virtual HostingServer HostingServer { get; set; }
		public virtual Service ParentService { get; set; }
		public virtual RegistrationOwnership RegistrationOwnership { get; set; }
		public virtual ServiceRegistrationStatus ServiceRegistrationStatus { get; set; }
		public virtual Service TaxService { get; set; }
	}
}
