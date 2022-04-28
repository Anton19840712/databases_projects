using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;
using WebApplicationOpen.Models.DalModels.Billing;
using WebApplicationOpen.Models.DalModels.Common;
using WebApplicationOpen.Models.DalModels.Domains;
using WebApplicationOpen.Models.DalModels.PromoCodes;

namespace WebApplicationOpen.Models.DalModels.TariffPlans
{
	[Table("TariffPlans")]
	public sealed class TariffPlanDal
	{
		public TariffPlanDal()
		{
			Acts = new HashSet<ActDal>();
			PromoCodeTypeServices = new HashSet<PromoCodeTypeServiceDal>();
			Services = new HashSet<ServiceDal>();
			SslTariffSettingParentTariffPlans = new HashSet<SslTariffSettingDal>();
			SslTariffSettingTariffPlans = new HashSet<SslTariffSettingDal>();
			Statistics = new HashSet<StatisticDal>();
			TariffPlanCosts = new HashSet<TariffPlanCostDal>();
			TariffPlanDurations = new HashSet<TariffPlanDurationDal>();
			TariffPlanInfos = new HashSet<TariffPlanInfoDal>();
			VpsTariffPlans = new HashSet<VpsTariffPlanDal>();
		}

		[Key]
		public long TariffPlanId { get; set; }
		public int ServiceTypeId { get; set; }
		public int? DomainZoneId { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public string UniqueName { get; set; }
		public int PeriodUnitId { get; set; }
		public string ColorTariffPlan { get; set; }
		public int? OrderIndex { get; set; }
		public int? TariffPlanTarificationTypeId { get; set; }

		public DomainZoneDal DomainZone { get; set; }
		public PeriodUnitDal PeriodUnit { get; set; }
		public ServiceTypeDal ServiceType { get; set; }
		public TariffPlanTarificationTypeDal TariffPlanTarificationType { get; set; }
		public ICollection<ActDal> Acts { get; set; }
		public ICollection<PromoCodeTypeServiceDal> PromoCodeTypeServices { get; set; }
		public ICollection<ServiceDal> Services { get; set; }

		[NotMapped]
		public ICollection<SslTariffSettingDal> SslTariffSettingParentTariffPlans { get; set; }
		[NotMapped]
		public ICollection<SslTariffSettingDal> SslTariffSettingTariffPlans { get; set; }
		public ICollection<StatisticDal> Statistics { get; set; }
		public ICollection<TariffPlanCostDal> TariffPlanCosts { get; set; }
		public ICollection<TariffPlanDurationDal> TariffPlanDurations { get; set; }
		public ICollection<TariffPlanInfoDal> TariffPlanInfos { get; set; }
		public ICollection<VpsTariffPlanDal> VpsTariffPlans { get; set; }
	}
}
