using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class TariffPlan
	{
		public TariffPlan()
		{
			Acts = new HashSet<ActDal>();
			PromoCodeTypeServices = new HashSet<PromoCodeTypeService>();
			Services = new HashSet<Service>();
			SslTariffSettingParentTariffPlans = new HashSet<SslTariffSetting>();
			SslTariffSettingTariffPlans = new HashSet<SslTariffSetting>();
			Statistics = new HashSet<Statistic>();
			TariffPlanCosts = new HashSet<TariffPlanCost>();
			TariffPlanDurations = new HashSet<TariffPlanDuration>();
			TariffPlanInfos = new HashSet<TariffPlanInfo>();
			VpsTariffPlans = new HashSet<VpsTariffPlan>();
		}

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

		public DomainZone DomainZone { get; set; }
		public PeriodUnit PeriodUnit { get; set; }
		public ServiceType ServiceType { get; set; }
		public TariffPlanTarificationType TariffPlanTarificationType { get; set; }
		public ICollection<ActDal> Acts { get; set; }
		public ICollection<PromoCodeTypeService> PromoCodeTypeServices { get; set; }
		public ICollection<Service> Services { get; set; }
		public ICollection<SslTariffSetting> SslTariffSettingParentTariffPlans { get; set; }
		public ICollection<SslTariffSetting> SslTariffSettingTariffPlans { get; set; }
		public ICollection<Statistic> Statistics { get; set; }
		public ICollection<TariffPlanCost> TariffPlanCosts { get; set; }
		public ICollection<TariffPlanDuration> TariffPlanDurations { get; set; }
		public ICollection<TariffPlanInfo> TariffPlanInfos { get; set; }
		public ICollection<VpsTariffPlan> VpsTariffPlans { get; set; }
	}
}
