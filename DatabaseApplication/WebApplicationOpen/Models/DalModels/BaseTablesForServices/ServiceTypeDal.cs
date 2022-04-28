using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Billing;
using WebApplicationOpen.Models.DalModels.Common;
using WebApplicationOpen.Models.DalModels.PromoCodes;
using WebApplicationOpen.Models.DalModels.TariffPlans;
using WebApplicationOpen.Models.DalModels.UserNotifications;

namespace WebApplicationOpen.Models.DalModels.BaseTablesForServices
{
	[Table("ServiceTypes")]
	public sealed class ServiceTypeDal
	{
		public ServiceTypeDal()
		{
			NotificationSchedules = new HashSet<NotificationScheduleDal>();
			PromoCodeTypeServices = new HashSet<PromoCodeTypeServiceDal>();
			ServiceHistories = new HashSet<ServiceHistoryDal>();
			Services = new HashSet<ServiceDal>();
			TariffPlans = new HashSet<TariffPlanDal>();
		}

		[Key]
		public int ServiceTypeId { get; set; }
		public string Description { get; set; }
		public int ServiceClassId { get; set; }

		public ServiceClassDal ServiceClass { get; set; }
		public ICollection<NotificationScheduleDal> NotificationSchedules { get; set; }
		public ICollection<PromoCodeTypeServiceDal> PromoCodeTypeServices { get; set; }
		public ICollection<ServiceHistoryDal> ServiceHistories { get; set; }
		public ICollection<ServiceDal> Services { get; set; }
		public ICollection<TariffPlanDal> TariffPlans { get; set; }
	}
}
