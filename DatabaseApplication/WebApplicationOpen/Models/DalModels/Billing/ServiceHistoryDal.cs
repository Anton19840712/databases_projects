using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;
using WebApplicationOpen.Models.DalModels.Clients;
using WebApplicationOpen.Models.DalModels.Common;
using WebApplicationOpen.Models.DalModels.Domains;
using WebApplicationOpen.Models.DalModels.TariffPlans;

namespace WebApplicationOpen.Models.DalModels.Billing
{
	[Table("ServiceHistory")]
	public sealed class ServiceHistoryDal
	{
		public ServiceHistoryDal()
		{
			Acts = new HashSet<ActDal>();
			Calls = new HashSet<CallDal>();
			ServicesInHistories = new HashSet<ServicesInHistoryDal>();
			Statistics = new HashSet<StatisticDal>();
		}

		[Key]
		public long ServiceHistoryId { get; set; }
		public long ClientId { get; set; }
		public long? DomainHistoryId { get; set; }
		public int ServiceTypeId { get; set; }
		public int DurationDays { get; set; }
		public DateTime PaymentDate { get; set; }
		public int OrderActionId { get; set; }
		public long VatId { get; set; }
		public long CostId { get; set; }
		public int Discount { get; set; }
		public int? PayDurationByTariff { get; set; }
		public long? TarifficationAmountWorkId { get; set; }
		public bool? PaymentPackageService { get; set; }

		public ClientDal Client { get; set; }
		public CostDal Cost { get; set; }
		public DomainHistoryDal DomainHistory { get; set; }
		public OrderActionDal OrderAction { get; set; }
		public ServiceTypeDal ServiceType { get; set; }
		public TarifficationAmountWorkDal TarifficationAmountWork { get; set; }
		public VatDal Vat { get; set; }
		public ICollection<ActDal> Acts { get; set; }
		public ICollection<CallDal> Calls { get; set; }
		public ICollection<ServicesInHistoryDal> ServicesInHistories { get; set; }
		public ICollection<StatisticDal> Statistics { get; set; }
	}
}
