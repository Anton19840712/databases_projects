using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.Scaffold;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("Client")]
	public sealed class ClientDal
	{
		public ClientDal()
		{
			ActAccessKeys = new HashSet<ActAccessKeyDal>();
			Acts = new HashSet<ActDal>();
			ApiRequestMessages = new HashSet<ApiRequestMessageDal>();
			Calls = new HashSet<CallDal>();
			ClientBalances = new HashSet<ClientBalanceDal>();
			ClientInfoForSslOrders = new HashSet<ClientInfoForSslOrderDal>();
			ClientRequisitesHistories = new HashSet<ClientRequisitesHistoryDal>();
			DebitBalances = new HashSet<DebitBalanceDal>();
			Invoices = new HashSet<InvoiceDal>();
			NotificationServiceCurrentMessages = new HashSet<NotificationServiceCurrentMessageDal>();
			PersonalDiscounts = new HashSet<PersonalDiscountDal>();
			ServiceHistories = new HashSet<ServiceHistoryDal>();
			ServiceRegistrations = new HashSet<ServiceRegistrationDal>();
			Services = new HashSet<ServiceDal>();
			Statistics = new HashSet<StatisticDal>();
			TransferOutgoingRequests = new HashSet<TransferOutgoingRequestDal>();
			UnsentSmsMessages = new HashSet<UnsentSmsMessageDal>();
			VerificationResults = new HashSet<VerificationResultDal>();
		}

		public long ClientId { get; set; }
		public long UserId { get; set; }
		public long WhoIsInfoId { get; set; }
		public long PrimaryAddressId { get; set; }
		public long ContactRequisiteId { get; set; }
		public long? BankRequisiteId { get; set; }
		public int CountryId { get; set; }
		public int ClientTypeId { get; set; }
		public int PasswordRecoveryTypeId { get; set; }
		public string Unp { get; set; }
		public string ContractNumber { get; set; }
		public int ClientRegistrationStatusId { get; set; }
		public string ManagerComment { get; set; }
		public bool IsTldClient { get; set; }
		public bool? IsReseller { get; set; }
		public bool IsApiAvailable { get; set; }
		public int? DefaultUserCurrency { get; set; }
		public bool IsSubscription { get; set; }
		public int? DefaultApiCurrency { get; set; }
		public long? EgrRequisitesId { get; set; }
		public long? PassportRequisitesId { get; set; }
		public string ClientName { get; set; }
		public long? JuridicalRequisitesId { get; set; }
		public bool IsBlockedClientRequisites { get; set; }
		public bool IsBlockedPayments { get; set; }

		public BankRequisiteDal BankRequisite { get; set; }
		public ClientRegistrationStatusDal ClientRegistrationStatus { get; set; }
		public ClientTypeDal ClientType { get; set; }
		public ContactRequisiteDal ContactRequisite { get; set; }
		public CountryDal Country { get; set; }
		public CurrencyDal DefaultUserCurrencyNavigation { get; set; }
		public EgrRequisiteDal EgrRequisites { get; set; }
		public JuridicalRequisiteDal JuridicalRequisites { get; set; }
		public PassportRequisiteDal PassportRequisites { get; set; }
		public PasswordRecoveryTypeDal PasswordRecoveryType { get; set; }
		public AddressDal PrimaryAddress { get; set; }
		public UserDal User { get; set; }
		public WhoIsInfoDal WhoIsInfo { get; set; }
		public ICollection<ActAccessKeyDal> ActAccessKeys { get; set; }
		public ICollection<ActDal> Acts { get; set; }
		public ICollection<ApiRequestMessageDal> ApiRequestMessages { get; set; }
		public ICollection<CallDal> Calls { get; set; }
		public ICollection<ClientBalanceDal> ClientBalances { get; set; }
		public ICollection<ClientInfoForSslOrderDal> ClientInfoForSslOrders { get; set; }
		public ICollection<ClientRequisitesHistoryDal> ClientRequisitesHistories { get; set; }
		public ICollection<DebitBalanceDal> DebitBalances { get; set; }
		public ICollection<InvoiceDal> Invoices { get; set; }
		public ICollection<NotificationServiceCurrentMessageDal> NotificationServiceCurrentMessages { get; set; }
		public ICollection<PersonalDiscountDal> PersonalDiscounts { get; set; }
		public ICollection<ServiceHistoryDal> ServiceHistories { get; set; }
		public ICollection<ServiceRegistrationDal> ServiceRegistrations { get; set; }
		public ICollection<ServiceDal> Services { get; set; }
		public ICollection<StatisticDal> Statistics { get; set; }
		public ICollection<TransferOutgoingRequestDal> TransferOutgoingRequests { get; set; }
		public ICollection<UnsentSmsMessageDal> UnsentSmsMessages { get; set; }
		public ICollection<VerificationResultDal> VerificationResults { get; set; }
	}
}
