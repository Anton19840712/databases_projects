using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class ServiceType
	{
		public ServiceType()
		{
			NotificationSchedules = new HashSet<NotificationSchedule>();
			PromoCodeTypeServices = new HashSet<PromoCodeTypeService>();
			ServiceHistories = new HashSet<ServiceHistory>();
			Services = new HashSet<Service>();
			TariffPlans = new HashSet<TariffPlan>();
		}

		public int ServiceTypeId { get; set; }
		public string Description { get; set; }
		public int ServiceClassId { get; set; }

		public ServiceClass ServiceClass { get; set; }
		public ICollection<NotificationSchedule> NotificationSchedules { get; set; }
		public ICollection<PromoCodeTypeService> PromoCodeTypeServices { get; set; }
		public ICollection<ServiceHistory> ServiceHistories { get; set; }
		public ICollection<Service> Services { get; set; }
		public ICollection<TariffPlan> TariffPlans { get; set; }
	}
}
