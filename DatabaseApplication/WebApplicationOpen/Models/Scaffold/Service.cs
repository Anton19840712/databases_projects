using System;
using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class Service
	{
		public Service()
		{
			CallPendingTasks = new HashSet<CallPendingTaskDal>();
			ClientInfoForSslOrders = new HashSet<ClientInfoForSslOrderDal>();
			DelayLocks = new HashSet<DelayLock>();
			InverseParentService = new HashSet<Service>();
			NotificationServiceCurrentMessages = new HashSet<NotificationServiceCurrentMessage>();
			ServiceNotificationQueues = new HashSet<ServiceNotificationQueue>();
			ServiceRegistrationParentServices = new HashSet<ServiceRegistration>();
			ServiceRegistrationTaxServices = new HashSet<ServiceRegistration>();
			ServicesInHistories = new HashSet<ServicesInHistory>();
			SslApiQueues = new HashSet<SslApiQueue>();
			SslServices = new HashSet<SslService>();
			VirtualHostings = new HashSet<VirtualHosting>();
			Vps = new HashSet<Vp>();
		}

		public long ServiceId { get; set; }
		public long? ParentServiceId { get; set; }
		public long ClientId { get; set; }
		public long TariffPlanId { get; set; }
		public int ServiceStatusId { get; set; }
		public int ServiceTypeId { get; set; }
		public DateTime ServiceOrderDate { get; set; }
		public DateTime? PendingExpirationDate { get; set; }
		public DateTime? ExpirationDate { get; set; }
		public int DurationMonthes { get; set; }
		public string ParentDomainName { get; set; }
		public byte ServiceFlags { get; set; }
		public DateTime? ContractDate { get; set; }
		public long? WhoIsInfoId { get; set; }
		public string CertificateAddress { get; set; }
		public string Login { get; set; }
		public string CpanelError { get; set; }
		public bool? IsTrialActivated { get; set; }
		public long? TarifficationAmountWorkId { get; set; }
		public string Note { get; set; }
		public int? ServicePaymentStatusId { get; set; }

		public virtual ClientDal Client { get; set; }
		public virtual Service ParentService { get; set; }
		public virtual ServiceStatus ServiceStatus { get; set; }
		public virtual ServiceType ServiceType { get; set; }
		public virtual TariffPlan TariffPlan { get; set; }
		public virtual TarifficationAmountWork TarifficationAmountWork { get; set; }
		public virtual WhoIsInfo WhoIsInfo { get; set; }
		public virtual Domain Domain { get; set; }
		public virtual ServiceInfo ServiceInfo { get; set; }
		public virtual ICollection<CallPendingTaskDal> CallPendingTasks { get; set; }
		public virtual ICollection<ClientInfoForSslOrderDal> ClientInfoForSslOrders { get; set; }
		public virtual ICollection<DelayLock> DelayLocks { get; set; }
		public virtual ICollection<Service> InverseParentService { get; set; }
		public virtual ICollection<NotificationServiceCurrentMessage> NotificationServiceCurrentMessages { get; set; }
		public virtual ICollection<ServiceNotificationQueue> ServiceNotificationQueues { get; set; }
		public virtual ICollection<ServiceRegistration> ServiceRegistrationParentServices { get; set; }
		public virtual ICollection<ServiceRegistration> ServiceRegistrationTaxServices { get; set; }
		public virtual ICollection<ServicesInHistory> ServicesInHistories { get; set; }
		public virtual ICollection<SslApiQueue> SslApiQueues { get; set; }
		public virtual ICollection<SslService> SslServices { get; set; }
		public virtual ICollection<VirtualHosting> VirtualHostings { get; set; }
		public virtual ICollection<Vp> Vps { get; set; }
	}
}
