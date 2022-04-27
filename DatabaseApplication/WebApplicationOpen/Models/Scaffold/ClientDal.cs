using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class ClientDal
	{
		public ClientDal()
		{
			ActAccessKeys = new HashSet<ActAccessKeyDal>();
			Acts = new HashSet<ActDal>();
			ApiRequestMessages = new HashSet<ApiRequestMessageDal>();
			Calls = new HashSet<CallDal>();
			ClientBalances = new HashSet<ClientBalance>();
			ClientInfoForSslOrders = new HashSet<ClientInfoForSslOrderDal>();
			ClientRequisitesHistories = new HashSet<ClientRequisitesHistory>();
			DebitBalances = new HashSet<DebitBalance>();
			Invoices = new HashSet<Invoice>();
			NotificationServiceCurrentMessages = new HashSet<NotificationServiceCurrentMessage>();
			PersonalDiscounts = new HashSet<PersonalDiscount>();
			ServiceHistories = new HashSet<ServiceHistory>();
			ServiceRegistrations = new HashSet<ServiceRegistration>();
			Services = new HashSet<Service>();
			Statistics = new HashSet<Statistic>();
			TransferOutgoingRequests = new HashSet<TransferOutgoingRequest>();
			UnsentSmsMessages = new HashSet<UnsentSmsMessage>();
			VerificationResults = new HashSet<VerificationResult>();
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

		public virtual BankRequisiteDal BankRequisite { get; set; }
		public virtual ClientRegistrationStatusDal ClientRegistrationStatus { get; set; }
		public virtual ClientType ClientType { get; set; }
		public virtual ContactRequisite ContactRequisite { get; set; }
		public virtual Country Country { get; set; }
		public virtual Currency DefaultUserCurrencyNavigation { get; set; }
		public virtual EgrRequisite EgrRequisites { get; set; }
		public virtual JuridicalRequisite JuridicalRequisites { get; set; }
		public virtual PassportRequisite PassportRequisites { get; set; }
		public virtual PasswordRecoveryType PasswordRecoveryType { get; set; }
		public virtual AddressDal PrimaryAddress { get; set; }
		public virtual User User { get; set; }
		public virtual WhoIsInfo WhoIsInfo { get; set; }
		public virtual ICollection<ActAccessKeyDal> ActAccessKeys { get; set; }
		public virtual ICollection<ActDal> Acts { get; set; }
		public virtual ICollection<ApiRequestMessageDal> ApiRequestMessages { get; set; }
		public virtual ICollection<CallDal> Calls { get; set; }
		public virtual ICollection<ClientBalance> ClientBalances { get; set; }
		public virtual ICollection<ClientInfoForSslOrderDal> ClientInfoForSslOrders { get; set; }
		public virtual ICollection<ClientRequisitesHistory> ClientRequisitesHistories { get; set; }
		public virtual ICollection<DebitBalance> DebitBalances { get; set; }
		public virtual ICollection<Invoice> Invoices { get; set; }
		public virtual ICollection<NotificationServiceCurrentMessage> NotificationServiceCurrentMessages { get; set; }
		public virtual ICollection<PersonalDiscount> PersonalDiscounts { get; set; }
		public virtual ICollection<ServiceHistory> ServiceHistories { get; set; }
		public virtual ICollection<ServiceRegistration> ServiceRegistrations { get; set; }
		public virtual ICollection<Service> Services { get; set; }
		public virtual ICollection<Statistic> Statistics { get; set; }
		public virtual ICollection<TransferOutgoingRequest> TransferOutgoingRequests { get; set; }
		public virtual ICollection<UnsentSmsMessage> UnsentSmsMessages { get; set; }
		public virtual ICollection<VerificationResult> VerificationResults { get; set; }
	}
}
