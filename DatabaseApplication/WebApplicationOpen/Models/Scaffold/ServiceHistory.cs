using System;
using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class ServiceHistory
	{
		public ServiceHistory()
		{
			Acts = new HashSet<ActDal>();
			Calls = new HashSet<CallDal>();
			ServicesInHistories = new HashSet<ServicesInHistory>();
			Statistics = new HashSet<Statistic>();
		}

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

		public virtual ClientDal Client { get; set; }
		public virtual Cost Cost { get; set; }
		public virtual DomainHistory DomainHistory { get; set; }
		public virtual OrderAction OrderAction { get; set; }
		public virtual ServiceType ServiceType { get; set; }
		public virtual TarifficationAmountWork TarifficationAmountWork { get; set; }
		public virtual Vat Vat { get; set; }
		public virtual ICollection<ActDal> Acts { get; set; }
		public virtual ICollection<CallDal> Calls { get; set; }
		public virtual ICollection<ServicesInHistory> ServicesInHistories { get; set; }
		public virtual ICollection<Statistic> Statistics { get; set; }
	}
}
