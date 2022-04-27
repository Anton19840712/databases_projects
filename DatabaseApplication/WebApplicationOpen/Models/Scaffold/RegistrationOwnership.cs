using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class RegistrationOwnership
	{
		public RegistrationOwnership()
		{
			ServiceRegistrations = new HashSet<ServiceRegistration>();
		}

		public int RegistrationOwnershipId { get; set; }
		public string Name { get; set; }

		public virtual ICollection<ServiceRegistration> ServiceRegistrations { get; set; }
	}
}
