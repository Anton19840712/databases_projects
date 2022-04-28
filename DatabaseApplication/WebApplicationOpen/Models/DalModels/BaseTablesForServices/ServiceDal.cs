using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Billing;
using WebApplicationOpen.Models.DalModels.Clients;
using WebApplicationOpen.Models.DalModels.Common;
using WebApplicationOpen.Models.DalModels.Domains;
using WebApplicationOpen.Models.DalModels.SslCertificates;
using WebApplicationOpen.Models.DalModels.StateRegistration;
using WebApplicationOpen.Models.DalModels.SystemAdministration;
using WebApplicationOpen.Models.DalModels.TariffPlans;
using WebApplicationOpen.Models.DalModels.UserNotifications;
using WebApplicationOpen.Models.DalModels.VirtualHosting;
using WebApplicationOpen.Models.DalModels.Vps;

namespace WebApplicationOpen.Models.DalModels.BaseTablesForServices
{
	[Table("Services")]
	public sealed class ServiceDal
	{
		public ServiceDal()
		{
			CallPendingTasks = new HashSet<CallPendingTaskDal>();
			ClientInfoForSslOrders = new HashSet<ClientInfoForSslOrderDal>();
			DelayLocks = new HashSet<DelayLockDal>();
			InverseParentService = new HashSet<ServiceDal>();
			NotificationServiceCurrentMessages = new HashSet<NotificationServiceCurrentMessageDal>();
			ServiceNotificationQueues = new HashSet<ServiceNotificationQueueDal>();
			ServiceRegistrationParentServices = new HashSet<ServiceRegistrationDal>();
			ServiceRegistrationTaxServices = new HashSet<ServiceRegistrationDal>();
			ServicesInHistories = new HashSet<ServicesInHistoryDal>();
			SslApiQueues = new HashSet<SslApiQueueDal>();
			SslServices = new HashSet<SslServiceDal>();
			VirtualHostings = new HashSet<VirtualHostingDal>();
			Vps = new HashSet<VpDal>();
		}

		[Key]
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

		public ClientDal Client { get; set; }
		public ServiceDal ParentService { get; set; }
		public ServiceStatusDal ServiceStatus { get; set; }
		public ServiceTypeDal ServiceType { get; set; }
		public TariffPlanDal TariffPlan { get; set; }
		public TarifficationAmountWorkDal TarifficationAmountWork { get; set; }
		public WhoIsInfoDal WhoIsInfo { get; set; }
		public DomainDal Domain { get; set; }
		public ServiceInfoDal ServiceInfo { get; set; }
		public ICollection<CallPendingTaskDal> CallPendingTasks { get; set; }
		public ICollection<ClientInfoForSslOrderDal> ClientInfoForSslOrders { get; set; }
		public ICollection<DelayLockDal> DelayLocks { get; set; }
		public ICollection<ServiceDal> InverseParentService { get; set; }
		public ICollection<NotificationServiceCurrentMessageDal> NotificationServiceCurrentMessages { get; set; }
		public ICollection<ServiceNotificationQueueDal> ServiceNotificationQueues { get; set; }

		[NotMapped]
		public ICollection<ServiceRegistrationDal> ServiceRegistrationParentServices { get; set; }//<===========================================================

		[NotMapped]
		public ICollection<ServiceRegistrationDal> ServiceRegistrationTaxServices { get; set; }//<===========================================================
		public ICollection<ServicesInHistoryDal> ServicesInHistories { get; set; }
		public ICollection<SslApiQueueDal> SslApiQueues { get; set; }
		public ICollection<SslServiceDal> SslServices { get; set; }
		public ICollection<VirtualHostingDal> VirtualHostings { get; set; }
		public ICollection<VpDal> Vps { get; set; }
	}
}
