using Microsoft.EntityFrameworkCore;
using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class Dev1Context : DbContext
	{
		public Dev1Context()
		{
		}

		public Dev1Context(DbContextOptions<Dev1Context> options) : base(options)
		{
		}

		public virtual DbSet<ActDal> Acts { get; set; }
		public virtual DbSet<ActAccessKeyDal> ActAccessKeys { get; set; }
		public virtual DbSet<ActionTypeDal> ActionTypes { get; set; }
		public virtual DbSet<AddressDal> Addresses { get; set; }
		public virtual DbSet<ApiRequestMessageDal> ApiRequestMessages { get; set; }
		public virtual DbSet<BackEndUserDal> BackEndUsers { get; set; }
		public virtual DbSet<BalanceTypeDal> BalanceTypes { get; set; }
		public virtual DbSet<BankRequisiteDal> BankRequisites { get; set; }
		public virtual DbSet<BlockedSmsNumberDal> BlockedSmsNumbers { get; set; }
		public virtual DbSet<CallDal> Calls { get; set; }
		public virtual DbSet<CallPendingTaskDal> CallPendingTasks { get; set; }
		public virtual DbSet<CallStatusDal> CallStatuses { get; set; }
		public virtual DbSet<ClientDal> Clients { get; set; }
		public virtual DbSet<ClientBalance> ClientBalances { get; set; }
		public virtual DbSet<ClientBalanceTypeDal> ClientBalanceTypes { get; set; }
		public virtual DbSet<ClientInfoForSslOrderDal> ClientInfoForSslOrders { get; set; }
		public virtual DbSet<ClientRegistrationStatusDal> ClientRegistrationStatuses { get; set; }
		public virtual DbSet<ClientRequisitesHistory> ClientRequisitesHistories { get; set; }
		public virtual DbSet<ClientType> ClientTypes { get; set; }
		public virtual DbSet<ContactRequisite> ContactRequisites { get; set; }
		public virtual DbSet<Cost> Costs { get; set; }
		public virtual DbSet<Country> Countries { get; set; }
		public virtual DbSet<Currency> Currencies { get; set; }
		public virtual DbSet<DebitBalance> DebitBalances { get; set; }
		public virtual DbSet<DelayChangeTariffPlan> DelayChangeTariffPlans { get; set; }
		public virtual DbSet<DelayLock> DelayLocks { get; set; }
		public virtual DbSet<DelayLockType> DelayLockTypes { get; set; }
		public virtual DbSet<DnsMailProvider> DnsMailProviders { get; set; }
		public virtual DbSet<DnsMailRecord> DnsMailRecords { get; set; }
		public virtual DbSet<DnsServer> DnsServers { get; set; }
		public virtual DbSet<Domain> Domains { get; set; }
		public virtual DbSet<DomainDescendant> DomainDescendants { get; set; }
		public virtual DbSet<DomainDescendantContract> DomainDescendantContracts { get; set; }
		public virtual DbSet<DomainHistory> DomainHistories { get; set; }
		public virtual DbSet<DomainLog> DomainLogs { get; set; }
		public virtual DbSet<DomainXrrpQueue> DomainXrrpQueues { get; set; }
		public virtual DbSet<DomainZone> DomainZones { get; set; }
		public virtual DbSet<DsRecord> DsRecords { get; set; }
		public virtual DbSet<EgrRequisite> EgrRequisites { get; set; }
		public virtual DbSet<EmailFrom> EmailFroms { get; set; }
		public virtual DbSet<HostingServer> HostingServers { get; set; }
		public virtual DbSet<HostingServerType> HostingServerTypes { get; set; }
		public virtual DbSet<HostingServersIp> HostingServersIps { get; set; }
		public virtual DbSet<Invoice> Invoices { get; set; }
		public virtual DbSet<InvoiceEmoneyPayment> InvoiceEmoneyPayments { get; set; }
		public virtual DbSet<InvoicePayment> InvoicePayments { get; set; }
		public virtual DbSet<InvoicePaymentRequisite> InvoicePaymentRequisites { get; set; }
		public virtual DbSet<JuridicalRequisite> JuridicalRequisites { get; set; }
		public virtual DbSet<Language> Languages { get; set; }
		public virtual DbSet<LocalRegistryMessage> LocalRegistryMessages { get; set; }
		public virtual DbSet<LogEvent> LogEvents { get; set; }
		public virtual DbSet<LogEventType> LogEventTypes { get; set; }
		public virtual DbSet<LogNote> LogNotes { get; set; }
		public virtual DbSet<LogRepository> LogRepositories { get; set; }
		public virtual DbSet<LogType> LogTypes { get; set; }
		public virtual DbSet<NotificationEvent> NotificationEvents { get; set; }
		public virtual DbSet<NotificationSchedule> NotificationSchedules { get; set; }
		public virtual DbSet<NotificationServiceCurrentMessage> NotificationServiceCurrentMessages { get; set; }
		public virtual DbSet<OrderAction> OrderActions { get; set; }
		public virtual DbSet<PassportRequisite> PassportRequisites { get; set; }
		public virtual DbSet<PasswordRecovery> PasswordRecoveries { get; set; }
		public virtual DbSet<PasswordRecoveryType> PasswordRecoveryTypes { get; set; }
		public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }
		public virtual DbSet<PaymentType> PaymentTypes { get; set; }
		public virtual DbSet<PendingOperation> PendingOperations { get; set; }
		public virtual DbSet<Period> Periods { get; set; }
		public virtual DbSet<PeriodUnit> PeriodUnits { get; set; }
		public virtual DbSet<PersonalDiscount> PersonalDiscounts { get; set; }
		public virtual DbSet<PowerDnsregistryQueue> PowerDnsregistryQueues { get; set; }
		public virtual DbSet<PromoCode> PromoCodes { get; set; }
		public virtual DbSet<PromoCodeDiscountValue> PromoCodeDiscountValues { get; set; }
		public virtual DbSet<PromoCodeService> PromoCodeServices { get; set; }
		public virtual DbSet<PromoCodeTypeService> PromoCodeTypeServices { get; set; }
		public virtual DbSet<Redirect> Redirects { get; set; }
		public virtual DbSet<RedirectAction> RedirectActions { get; set; }
		public virtual DbSet<Registrant> Registrants { get; set; }
		public virtual DbSet<RegistrationOwnership> RegistrationOwnerships { get; set; }
		public virtual DbSet<Role> Roles { get; set; }
		public virtual DbSet<Service> Services { get; set; }
		public virtual DbSet<ServiceClass> ServiceClasses { get; set; }
		public virtual DbSet<ServiceHistory> ServiceHistories { get; set; }
		public virtual DbSet<ServiceInfo> ServiceInfos { get; set; }
		public virtual DbSet<ServiceNotificationQueue> ServiceNotificationQueues { get; set; }
		public virtual DbSet<ServiceRegistration> ServiceRegistrations { get; set; }
		public virtual DbSet<ServiceRegistrationStatus> ServiceRegistrationStatuses { get; set; }
		public virtual DbSet<ServiceStatistic> ServiceStatistics { get; set; }
		public virtual DbSet<ServiceStatus> ServiceStatuses { get; set; }
		public virtual DbSet<ServiceType> ServiceTypes { get; set; }
		public virtual DbSet<ServicesInHistory> ServicesInHistories { get; set; }
		public virtual DbSet<SslApiQueue> SslApiQueues { get; set; }
		public virtual DbSet<SslCertificateType> SslCertificateTypes { get; set; }
		public virtual DbSet<SslOrderStatus> SslOrderStatuses { get; set; }
		public virtual DbSet<SslService> SslServices { get; set; }
		public virtual DbSet<SslTariffSetting> SslTariffSettings { get; set; }
		public virtual DbSet<SslVerification> SslVerifications { get; set; }
		public virtual DbSet<SslVerificationType> SslVerificationTypes { get; set; }
		public virtual DbSet<Statistic> Statistics { get; set; }
		public virtual DbSet<SystemNotification> SystemNotifications { get; set; }
		public virtual DbSet<SystemNotificationErrorLevel> SystemNotificationErrorLevels { get; set; }
		public virtual DbSet<SystemNotificationType> SystemNotificationTypes { get; set; }
		public virtual DbSet<TariffPlan> TariffPlans { get; set; }
		public virtual DbSet<TariffPlanCost> TariffPlanCosts { get; set; }
		public virtual DbSet<TariffPlanDuration> TariffPlanDurations { get; set; }
		public virtual DbSet<TariffPlanInfo> TariffPlanInfos { get; set; }
		public virtual DbSet<TariffPlanTarificationType> TariffPlanTarificationTypes { get; set; }
		public virtual DbSet<TarifficationAmountWork> TarifficationAmountWorks { get; set; }
		public virtual DbSet<TransferIncomingRequest> TransferIncomingRequests { get; set; }
		public virtual DbSet<TransferOperation> TransferOperations { get; set; }
		public virtual DbSet<TransferOutgoingRequest> TransferOutgoingRequests { get; set; }
		public virtual DbSet<UnsentMail> UnsentMails { get; set; }
		public virtual DbSet<UnsentSmsMessage> UnsentSmsMessages { get; set; }
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<UserInRole> UserInRoles { get; set; }
		public virtual DbSet<UserLog> UserLogs { get; set; }
		public virtual DbSet<UserSession> UserSessions { get; set; }
		public virtual DbSet<Variable> Variables { get; set; }
		public virtual DbSet<Vat> Vats { get; set; }
		public virtual DbSet<VerificationField> VerificationFields { get; set; }
		public virtual DbSet<VerificationLog> VerificationLogs { get; set; }
		public virtual DbSet<VerificationResult> VerificationResults { get; set; }
		public virtual DbSet<VerificationStatus> VerificationStatuses { get; set; }
		public virtual DbSet<VirtualHosting> VirtualHostings { get; set; }
		public virtual DbSet<Vp> Vps { get; set; }
		public virtual DbSet<VpsConfig> VpsConfigs { get; set; }
		public virtual DbSet<VpsConfigItemsCost> VpsConfigItemsCosts { get; set; }
		public virtual DbSet<VpsDrife> VpsDrives { get; set; }
		public virtual DbSet<VpsDriveType> VpsDriveTypes { get; set; }
		public virtual DbSet<VpsOsType> VpsOsTypes { get; set; }
		public virtual DbSet<VpsTariffPlan> VpsTariffPlans { get; set; }
		public virtual DbSet<VpsTariffPlanConfigLimit> VpsTariffPlanConfigLimits { get; set; }
		public virtual DbSet<WhoIsInfo> WhoIsInfos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
				optionsBuilder.UseSqlServer("Data Source=dev.domain.by; Initial Catalog=dev1; User ID=sa; Password=WSXqaz123");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

			modelBuilder.Entity<ActDal>(entity =>
			{
				entity.Property(e => e.ActivationDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(((1945)/(12))/(12))");

				entity.Property(e => e.DurationDays).HasDefaultValueSql("((1))");

				entity.Property(e => e.ReportDate).HasColumnType("datetime");

				entity.Property(e => e.ReservedBalanceByService).HasColumnType("decimal(10, 4)");

				entity.HasOne(d => d.Cost)
					.WithMany(p => p.Acts)
					.HasForeignKey(d => d.CostId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Acts_Costs");

				entity.HasOne(d => d.RedelegateClient)
					.WithMany(p => p.Acts)
					.HasForeignKey(d => d.RedelegateClientId)
					.HasConstraintName("FK_Acts_Clients");

				entity.HasOne(d => d.ServiceHistory)
					.WithMany(p => p.Acts)
					.HasForeignKey(d => d.ServiceHistoryId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Acts_ServiceHistory");

				entity.HasOne(d => d.TariffPlan)
					.WithMany(p => p.Acts)
					.HasForeignKey(d => d.TariffPlanId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Acts_TariffPlans");

				entity.HasOne(d => d.TarifficationAmountWork)
					.WithMany(p => p.Acts)
					.HasForeignKey(d => d.TarifficationAmountWorkId)
					.HasConstraintName("FK_Acts_TarifficationAmountWork");

				entity.HasOne(d => d.Vat)
					.WithMany(p => p.Acts)
					.HasForeignKey(d => d.VatId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Acts_Vat");
			});

			modelBuilder.Entity<ActAccessKeyDal>(entity =>
			{
				entity.Property(e => e.AccessKey)
					.IsRequired()
					.HasMaxLength(16)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.Date).HasColumnType("date");

				entity.HasOne(d => d.Client)
					.WithMany(p => p.ActAccessKeys)
					.HasForeignKey(d => d.ClientId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ActAccessKeys_Clients");
			});

			modelBuilder.Entity<ActionTypeDal>(entity =>
			{
				entity.ToTable("ActionType");

				entity.Property(e => e.ActionTypeId).ValueGeneratedNever();

				entity.Property(e => e.ActionType1)
					.IsRequired()
					.HasMaxLength(50)
					.HasColumnName("ActionType");
			});

			modelBuilder.Entity<AddressDal>(entity =>
			{
				entity.Property(e => e.Building)
					.IsRequired()
					.HasMaxLength(20);

				entity.Property(e => e.City)
					.IsRequired()
					.HasMaxLength(128);

				entity.Property(e => e.District)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.Room)
					.IsRequired()
					.HasMaxLength(20);

				entity.Property(e => e.Street)
					.IsRequired()
					.HasMaxLength(128);

				entity.Property(e => e.ZipCode)
					.IsRequired()
					.HasMaxLength(16);

				//HERE:

				entity.HasOne(d => d.Country)
					.WithMany(p => p.Addresses)
					.HasForeignKey(d => d.CountryId) //<----------------------------------
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Address_Countries");
			});

			modelBuilder.Entity<ApiRequestMessageDal>(entity =>
			{
				entity.HasKey(e => e.ApiRequestMessagesId);

				entity.Property(e => e.CreationDate).HasColumnType("datetime");

				entity.Property(e => e.Domain).IsRequired();

				entity.Property(e => e.Notice).IsRequired();

				entity.Property(e => e.PendingExpirationDate).HasColumnType("datetime");

				entity.HasOne(d => d.Client)
					.WithMany(p => p.ApiRequestMessages)
					.HasForeignKey(d => d.ClientId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ApiRequestMessages_Clients");
			});

			modelBuilder.Entity<BackEndUserDal>(entity =>
			{
				entity.HasIndex(e => e.UserId, "IX_BackEndUsers_Users")
					.IsUnique();

				entity.Property(e => e.FullName)
					.IsRequired()
					.HasMaxLength(512);

				entity.HasOne(d => d.User)
					.WithOne(p => p.BackEndUser)
					.HasForeignKey<BackEndUserDal>(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BackEndUsers_Users");
			});

			modelBuilder.Entity<BalanceTypeDal>(entity =>
			{
				entity.Property(e => e.BalanceTypeId).ValueGeneratedNever();

				entity.HasOne(d => d.Currency)
					.WithMany(p => p.BalanceTypes)
					.HasForeignKey(d => d.CurrencyId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BalanceTypes_Currencies");
			});

			modelBuilder.Entity<BankRequisiteDal>(entity =>
			{
				entity.HasKey(e => e.BankRequisitesId);

				entity.Property(e => e.Account)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.BankCode)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.BankName)
					.IsRequired()
					.HasMaxLength(128);

				entity.Property(e => e.Payer).HasMaxLength(128);
			});

			modelBuilder.Entity<BlockedSmsNumberDal>(entity =>
			{
				entity.Property(e => e.PhoneNumber)
					.IsRequired()
					.HasMaxLength(13);
			});

			modelBuilder.Entity<CallDal>(entity =>
			{
				entity.Property(e => e.Comment).HasMaxLength(300);

				entity.Property(e => e.Date).HasColumnType("datetime");

				entity.Property(e => e.Phone)
					.IsRequired()
					.HasMaxLength(100);

				entity.HasOne(d => d.BackEndUser)
					.WithMany(p => p.Calls)
					.HasForeignKey(d => d.BackEndUserId)
					.HasConstraintName("FK_Calls_BackEndUsers");

				entity.HasOne(d => d.CallStatus)
					.WithMany(p => p.Calls)
					.HasForeignKey(d => d.CallStatusId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Calls_CallStatus");

				entity.HasOne(d => d.Client)
					.WithMany(p => p.Calls)
					.HasForeignKey(d => d.ClientId)
					.HasConstraintName("FK_Calls_Client");

				entity.HasOne(d => d.ServiceHistory)
					.WithMany(p => p.Calls)
					.HasForeignKey(d => d.ServiceHistoryId)
					.HasConstraintName("FK_Calls_ServiceHistory");
			});

			modelBuilder.Entity<CallPendingTaskDal>(entity =>
			{
				entity.Property(e => e.Date).HasColumnType("datetime");

				entity.Property(e => e.HideExDate).HasColumnType("datetime");

				entity.Property(e => e.PendingExDate).HasColumnType("datetime");

				entity.HasOne(d => d.Service)
					.WithMany(p => p.CallPendingTasks)
					.HasForeignKey(d => d.ServiceId)
					.HasConstraintName("FK_PendingTasks_Services");
			});

			modelBuilder.Entity<CallStatusDal>(entity =>
			{
				entity.ToTable("CallStatus");

				entity.Property(e => e.Status)
					.IsRequired()
					.HasMaxLength(100);
			});

			modelBuilder.Entity<ClientDal>(entity =>
			{
				entity.Property(e => e.ClientName).HasMaxLength(1024);

				entity.Property(e => e.ClientRegistrationStatusId).HasDefaultValueSql("((1))");

				entity.Property(e => e.ContractNumber)
					.IsRequired()
					.HasMaxLength(256)
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.IsReseller)
					.IsRequired()
					.HasDefaultValueSql("('0')");

				entity.Property(e => e.ManagerComment).HasMaxLength(1024);

				entity.Property(e => e.Unp).HasMaxLength(256);

				entity.HasOne(d => d.BankRequisite)
					.WithMany(p => p.Clients)
					.HasForeignKey(d => d.BankRequisiteId)
					.HasConstraintName("FK_ClientRequisites_BankRequisites");

				entity.HasOne(d => d.ClientRegistrationStatus)
					.WithMany(p => p.Clients)
					.HasForeignKey(d => d.ClientRegistrationStatusId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Clients_ClientRegistrationStatuses");

				entity.HasOne(d => d.ClientType)
					.WithMany(p => p.Clients)
					.HasForeignKey(d => d.ClientTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientRequisites_ClientType");

				entity.HasOne(d => d.ContactRequisite)
					.WithMany(p => p.Clients)
					.HasForeignKey(d => d.ContactRequisiteId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientRequisites_ContactRequisites");

				entity.HasOne(d => d.Country)
					.WithMany(p => p.Clients)
					.HasForeignKey(d => d.CountryId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientRequisites_Countries");

				entity.HasOne(d => d.DefaultUserCurrencyNavigation)
					.WithMany(p => p.Clients)
					.HasForeignKey(d => d.DefaultUserCurrency)
					.HasConstraintName("FK_Clients_Currencies");

				entity.HasOne(d => d.EgrRequisites)
					.WithMany(p => p.Clients)
					.HasForeignKey(d => d.EgrRequisitesId)
					.HasConstraintName("FK_Clients_EgrRequisites");

				entity.HasOne(d => d.JuridicalRequisites)
					.WithMany(p => p.Clients)
					.HasForeignKey(d => d.JuridicalRequisitesId)
					.HasConstraintName("FK_Clients_JuridicalRequisites");

				entity.HasOne(d => d.PassportRequisites)
					.WithMany(p => p.Clients)
					.HasForeignKey(d => d.PassportRequisitesId)
					.HasConstraintName("FK_Clients_PassportRequisites");

				entity.HasOne(d => d.PasswordRecoveryType)
					.WithMany(p => p.Clients)
					.HasForeignKey(d => d.PasswordRecoveryTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientRequisites_PasswordRecoveryType");

				entity.HasOne(d => d.PrimaryAddress)
					.WithMany(p => p.Clients)
					.HasForeignKey(d => d.PrimaryAddressId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientRequisites_Address");

				entity.HasOne(d => d.User)
					.WithMany(p => p.Clients)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientRequisites_User");

				entity.HasOne(d => d.WhoIsInfo)
					.WithMany(p => p.Clients)
					.HasForeignKey(d => d.WhoIsInfoId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientRequisites_WhoisInfo");
			});

			modelBuilder.Entity<ClientBalance>(entity =>
			{
				entity.HasKey(e => e.ClientBalanceId)
					.IsClustered(false);

				entity.Property(e => e.CreditLimit).HasColumnType("decimal(10, 0)");

				entity.Property(e => e.Value).HasColumnType("decimal(10, 2)");

				entity.HasOne(d => d.BalanceType)
					.WithMany(p => p.ClientBalances)
					.HasForeignKey(d => d.BalanceTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientBalances_BalanceTypes");

				entity.HasOne(d => d.Client)
					.WithMany(p => p.ClientBalances)
					.HasForeignKey(d => d.ClientId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientBalances_ClientRequisites");
			});

			modelBuilder.Entity<ClientBalanceTypeDal>(entity =>
			{
				entity.HasOne(d => d.BalanceType)
					.WithMany(p => p.ClientBalanceTypes)
					.HasForeignKey(d => d.BalanceTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientBalanceTypes_BalanceTypes");

				entity.HasOne(d => d.ClientType)
					.WithMany(p => p.ClientBalanceTypes)
					.HasForeignKey(d => d.ClientTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientBalanceTypes_ClientTypes");
			});

			modelBuilder.Entity<ClientInfoForSslOrderDal>(entity =>
			{
				entity.ToTable("ClientInfoForSslOrder");

				entity.Property(e => e.Address).HasMaxLength(128);

				entity.Property(e => e.City)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.Email)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.OrganizationName).HasMaxLength(128);

				entity.Property(e => e.Phone)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.PostalCode)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.Region)
					.IsRequired()
					.HasMaxLength(64);

				entity.HasOne(d => d.Client)
					.WithMany(p => p.ClientInfoForSslOrders)
					.HasForeignKey(d => d.ClientId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientInfoForSslOrder_Clients");

				entity.HasOne(d => d.ClientType)
					.WithMany(p => p.ClientInfoForSslOrders)
					.HasForeignKey(d => d.ClientTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientInfoForSslOrder_ClientType");

				entity.HasOne(d => d.Country)
					.WithMany(p => p.ClientInfoForSslOrders)
					.HasForeignKey(d => d.CountryId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientInfoForSslOrder_Countries");

				entity.HasOne(d => d.Service)
					.WithMany(p => p.ClientInfoForSslOrders)
					.HasForeignKey(d => d.ServiceId)
					.HasConstraintName("FK_ClientInfoForSslOrder_Services");
			});

			modelBuilder.Entity<ClientRegistrationStatusDal>(entity =>
			{
				entity.Property(e => e.ClientRegistrationStatusId).ValueGeneratedNever();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(64);
			});

			modelBuilder.Entity<ClientRequisitesHistory>(entity =>
			{
				entity.ToTable("ClientRequisitesHistory");

				entity.Property(e => e.Account).HasMaxLength(64);

				entity.Property(e => e.AccountEmail).HasMaxLength(64);

				entity.Property(e => e.BankCode).HasMaxLength(64);

				entity.Property(e => e.BankName).HasMaxLength(128);

				entity.Property(e => e.ChiefName).HasMaxLength(512);

				entity.Property(e => e.Date).HasColumnType("datetime");

				entity.Property(e => e.EgrDecisionDate).HasMaxLength(50);

				entity.Property(e => e.EgrDecisionNumber).HasMaxLength(50);

				entity.Property(e => e.EgrNumber).HasMaxLength(50);

				entity.Property(e => e.EgrRegistrar).HasMaxLength(100);

				entity.Property(e => e.Email).HasMaxLength(64);

				entity.Property(e => e.EnterpriseTitle).HasMaxLength(256);

				entity.Property(e => e.Fax).HasMaxLength(64);

				entity.Property(e => e.PassportIdentificationNumber).HasMaxLength(50);

				entity.Property(e => e.PassportIssue).HasMaxLength(256);

				entity.Property(e => e.PassportIssueDate).HasMaxLength(50);

				entity.Property(e => e.PassportNumber).HasMaxLength(64);

				entity.Property(e => e.PassportSeries).HasMaxLength(10);

				entity.Property(e => e.Payer).HasMaxLength(128);

				entity.Property(e => e.Phone).HasMaxLength(64);

				entity.Property(e => e.PrimaryAddressBuilding).HasMaxLength(20);

				entity.Property(e => e.PrimaryAddressCity).HasMaxLength(128);

				entity.Property(e => e.PrimaryAddressDistrict).HasMaxLength(100);

				entity.Property(e => e.PrimaryAddressRoom).HasMaxLength(20);

				entity.Property(e => e.PrimaryAddressStreet).HasMaxLength(128);

				entity.Property(e => e.PrimaryAddressZipZode).HasMaxLength(16);

				entity.Property(e => e.RepresenterName).HasMaxLength(512);

				entity.Property(e => e.SecondaryAddressBuilding).HasMaxLength(20);

				entity.Property(e => e.SecondaryAddressCity).HasMaxLength(128);

				entity.Property(e => e.SecondaryAddressDistrict).HasMaxLength(100);

				entity.Property(e => e.SecondaryAddressRoom).HasMaxLength(20);

				entity.Property(e => e.SecondaryAddressStreet).HasMaxLength(128);

				entity.Property(e => e.SecondaryAddressZipZode).HasMaxLength(16);

				entity.Property(e => e.Unp).HasMaxLength(256);

				entity.Property(e => e.UserName).HasMaxLength(512);

				entity.HasOne(d => d.Client)
					.WithMany(p => p.ClientRequisitesHistories)
					.HasForeignKey(d => d.ClientId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DebitBalance_Clients");

				//HERE:

				entity.HasOne(d => d.Country)
					.WithMany(p => p.ClientRequisitesHistoryCountries)
					.HasForeignKey(d => d.CountryId) // <----------------------------------------------
					.HasConstraintName("FK_ClientRequisitesHistory_Countries");

				entity.HasOne(d => d.PrimaryAddressCountry)
					.WithMany(p => p.ClientRequisitesHistoryPrimaryAddressCountries)
					.HasForeignKey(d => d.PrimaryAddressCountryId)
					.HasConstraintName("FK_ClientRequisitesHistory_Countries1");

				entity.HasOne(d => d.SecondaryAddressCountry)
					.WithMany(p => p.ClientRequisitesHistorySecondaryAddressCountries)
					.HasForeignKey(d => d.SecondaryAddressCountryId)
					.HasConstraintName("FK_ClientRequisitesHistory_Countries2");
			});

			modelBuilder.Entity<ClientType>(entity =>
			{
				entity.Property(e => e.ClientTypeId).ValueGeneratedNever();

				entity.Property(e => e.ClientTypeName)
					.IsRequired()
					.HasMaxLength(64);
			});

			modelBuilder.Entity<ContactRequisite>(entity =>
			{
				entity.Property(e => e.AdditionalEmail1).HasMaxLength(64);

				entity.Property(e => e.AdditionalEmail2).HasMaxLength(64);

				entity.Property(e => e.AdditionalEmail3).HasMaxLength(64);

				entity.Property(e => e.AdditionalPhone1).HasMaxLength(64);

				entity.Property(e => e.AdditionalPhone2).HasMaxLength(64);

				entity.Property(e => e.CpanelEmail).HasMaxLength(64);

				entity.Property(e => e.Email)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.Fax).HasMaxLength(64);

				entity.Property(e => e.Phone).HasMaxLength(64);
			});

			modelBuilder.Entity<Cost>(entity =>
			{
				entity.Property(e => e.Value).HasColumnType("decimal(30, 4)");

				entity.HasOne(d => d.Currency)
					.WithMany(p => p.Costs)
					.HasForeignKey(d => d.CurrencyId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Cost_Currency");
			});

			modelBuilder.Entity<Country>(entity =>
			{
				entity.Property(e => e.CountryName)
					.IsRequired()
					.HasMaxLength(128);
			});

			modelBuilder.Entity<Currency>(entity =>
			{
				entity.Property(e => e.CurrencyId).ValueGeneratedNever();

				entity.Property(e => e.CurrencyName)
					.IsRequired()
					.HasMaxLength(4);
			});

			modelBuilder.Entity<DebitBalance>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Value).HasColumnType("decimal(30, 2)");

				entity.HasOne(d => d.BalanceType)
					.WithMany(p => p.DebitBalances)
					.HasForeignKey(d => d.BalanceTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DebitBalances_BalanceTypes");

				entity.HasOne(d => d.Client)
					.WithMany(p => p.DebitBalances)
					.HasForeignKey(d => d.ClientId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DebitBalances_Clients");
			});

			modelBuilder.Entity<DelayChangeTariffPlan>(entity =>
			{
				entity.ToTable("DelayChangeTariffPlan");

				entity.Property(e => e.DateChange).HasColumnType("datetime");

				entity.Property(e => e.SumNeedForChange).HasColumnType("decimal(10, 2)");
			});

			modelBuilder.Entity<DelayLock>(entity =>
			{
				entity.Property(e => e.ActionDate).HasColumnType("datetime");

				entity.Property(e => e.Comment).HasMaxLength(300);

				entity.Property(e => e.PendingExDate).HasColumnType("datetime");

				entity.HasOne(d => d.BackEndUser)
					.WithMany(p => p.DelayLocks)
					.HasForeignKey(d => d.BackEndUserId)
					.HasConstraintName("FK_DelayLocks_BackEndUsers");

				entity.HasOne(d => d.DelayLockType)
					.WithMany(p => p.DelayLocks)
					.HasForeignKey(d => d.DelayLockTypeId)
					.HasConstraintName("FK_DelayLocks_DelayLockTypes");

				entity.HasOne(d => d.Service)
					.WithMany(p => p.DelayLocks)
					.HasForeignKey(d => d.ServiceId)
					.HasConstraintName("FK_DelayLocks_Services");
			});

			modelBuilder.Entity<DelayLockType>(entity =>
			{
				entity.Property(e => e.Description).HasMaxLength(50);
			});

			modelBuilder.Entity<DnsMailProvider>(entity =>
			{
				entity.Property(e => e.ProviderName)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<DnsMailRecord>(entity =>
			{
				entity.Property(e => e.DomainName)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.RecordType)
					.IsRequired()
					.HasMaxLength(10);

				entity.Property(e => e.RecordValue)
					.IsRequired()
					.HasMaxLength(70);

				entity.HasOne(d => d.DnsMailProvider)
					.WithMany(p => p.DnsMailRecords)
					.HasForeignKey(d => d.DnsMailProviderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DnsMailRecords_DnsMailProviders");
			});

			modelBuilder.Entity<DnsServer>(entity =>
			{
				entity.Property(e => e.DnsUrl).IsRequired();

				entity.HasOne(d => d.Domain)
					.WithMany(p => p.DnsServers)
					.HasForeignKey(d => d.DomainId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DnsServers_Domain");
			});

			modelBuilder.Entity<Domain>(entity =>
			{
				entity.HasIndex(e => e.ServiceId, "UK_ServiceId_Unique")
					.IsUnique();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100);

				entity.HasOne(d => d.DomainZone)
					.WithMany(p => p.Domains)
					.HasForeignKey(d => d.DomainZoneId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Domains_DomainZones");

				entity.HasOne(d => d.Registrant)
					.WithMany(p => p.Domains)
					.HasForeignKey(d => d.RegistrantId)
					.HasConstraintName("FK_Domains_Registrants");

				entity.HasOne(d => d.Service)
					.WithOne(p => p.Domain)
					.HasForeignKey<Domain>(d => d.ServiceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Domain_Service");

				entity.HasOne(d => d.WhoIsInfo)
					.WithMany(p => p.Domains)
					.HasForeignKey(d => d.WhoIsInfoId)
					.HasConstraintName("FK_Domain_WhoisInfo");
			});

			modelBuilder.Entity<DomainDescendant>(entity =>
			{
				entity.Property(e => e.CreateDate).HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100);

				entity.HasOne(d => d.DomainDescendantContract)
					.WithMany(p => p.DomainDescendants)
					.HasForeignKey(d => d.DomainDescendantContractId)
					.HasConstraintName("FK_DomainDescendants_DomainDescendantContracts");

				entity.HasOne(d => d.Domain)
					.WithMany(p => p.DomainDescendants)
					.HasForeignKey(d => d.DomainId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DomainDescendants_Domains");

				entity.HasOne(d => d.Registrant)
					.WithMany(p => p.DomainDescendants)
					.HasForeignKey(d => d.RegistrantId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DomainDescendants_Registrants");
			});

			modelBuilder.Entity<DomainDescendantContract>(entity =>
			{
				entity.HasKey(e => e.DescendantContractId)
					.HasName("PK_DescendantsContracts");

				entity.Property(e => e.ApplicantName).HasMaxLength(100);

				entity.Property(e => e.ApplicantPosition).HasMaxLength(100);

				entity.Property(e => e.ContractNumber).HasMaxLength(100);

				entity.Property(e => e.OrderDate).HasColumnType("date");

				entity.Property(e => e.ValidityDate).HasColumnType("date");
			});

			modelBuilder.Entity<DomainHistory>(entity =>
			{
				entity.ToTable("DomainHistory");

				entity.HasIndex(e => new { e.Name, e.DomainZoneId }, "IX_DomainHistory")
					.IsUnique();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100);

				entity.HasOne(d => d.DomainZone)
					.WithMany(p => p.DomainHistories)
					.HasForeignKey(d => d.DomainZoneId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DomainHistory_DomainZones");
			});

			modelBuilder.Entity<DomainLog>(entity =>
			{
				entity.ToTable("DomainLog");

				entity.HasOne(d => d.DomainHistory)
					.WithMany(p => p.DomainLogs)
					.HasForeignKey(d => d.DomainHistoryId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DomainLog_DomainHistory");

				entity.HasOne(d => d.Log)
					.WithMany(p => p.DomainLogs)
					.HasForeignKey(d => d.LogId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DomainLog_LogRepository");
			});

			modelBuilder.Entity<DomainXrrpQueue>(entity =>
			{
				entity.HasKey(e => e.DomainQueueId);

				entity.ToTable("DomainXrrpQueue");

				entity.Property(e => e.CreateDate).HasColumnType("datetime");

				entity.Property(e => e.FailUpdateDate).HasColumnType("datetime");

				entity.HasOne(d => d.Domain)
					.WithMany(p => p.DomainXrrpQueues)
					.HasForeignKey(d => d.DomainId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DomainXrrpQueue_Domains");
			});

			modelBuilder.Entity<DomainZone>(entity =>
			{
				entity.Property(e => e.DomainZoneId).ValueGeneratedNever();

				entity.Property(e => e.Label)
					.IsRequired()
					.HasMaxLength(16)
					.HasDefaultValueSql("(N' ')");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(16);
			});

			modelBuilder.Entity<DsRecord>(entity =>
			{
				entity.Property(e => e.Alg)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.Digest)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.Tag)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.Type)
					.IsRequired()
					.HasMaxLength(50);

				entity.HasOne(d => d.Domain)
					.WithMany(p => p.DsRecords)
					.HasForeignKey(d => d.DomainId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DsRecords_Domains");
			});

			modelBuilder.Entity<EgrRequisite>(entity =>
			{
				entity.HasKey(e => e.EgrRequisitesId);

				entity.Property(e => e.DecisionDate)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.DecisionNumber).HasMaxLength(50);

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Registrar)
					.IsRequired()
					.HasMaxLength(100);
			});

			modelBuilder.Entity<EmailFrom>(entity =>
			{
				entity.Property(e => e.From)
					.IsRequired()
					.HasMaxLength(100);
			});

			modelBuilder.Entity<HostingServer>(entity =>
			{
				entity.Property(e => e.Dcnumber)
					.IsRequired()
					.HasMaxLength(128)
					.HasColumnName("DCNumber");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(128);

				entity.Property(e => e.Ports)
					.IsRequired()
					.HasMaxLength(512);

				entity.Property(e => e.Token).HasMaxLength(128);

				entity.HasOne(d => d.HostingServerType)
					.WithMany(p => p.HostingServers)
					.HasForeignKey(d => d.HostingServerTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HostingServers_HostingServerTypes");
			});

			modelBuilder.Entity<HostingServerType>(entity =>
			{
				entity.Property(e => e.HostingServerTypeId).ValueGeneratedNever();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(64);
			});

			modelBuilder.Entity<HostingServersIp>(entity =>
			{
				entity.Property(e => e.Ip)
					.IsRequired()
					.HasMaxLength(128)
					.IsUnicode(false);

				entity.HasOne(d => d.HostingServer)
					.WithMany(p => p.HostingServersIps)
					.HasForeignKey(d => d.HostingServerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_HostingServersIps_HostingServers");
			});

			modelBuilder.Entity<Invoice>(entity =>
			{
				entity.Property(e => e.AccessKey)
					.IsRequired()
					.HasMaxLength(16)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.CreationDate).HasColumnType("datetime");

				entity.Property(e => e.DomainName).HasMaxLength(256);

				entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

				entity.Property(e => e.PaymentTypeId).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.Client)
					.WithMany(p => p.Invoices)
					.HasForeignKey(d => d.ClientId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Invoices_ClientRequisites");

				entity.HasOne(d => d.Cost)
					.WithMany(p => p.Invoices)
					.HasForeignKey(d => d.CostId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Invoices_Costs");

				entity.HasOne(d => d.PaymentType)
					.WithMany(p => p.Invoices)
					.HasForeignKey(d => d.PaymentTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Invoices_PaymentTypes");

				entity.HasOne(d => d.PromoCode)
					.WithMany(p => p.Invoices)
					.HasForeignKey(d => d.PromoCodeId)
					.HasConstraintName("FK_Invoices_PromoCodes");

				entity.HasOne(d => d.TarifficationAmountWork)
					.WithMany(p => p.Invoices)
					.HasForeignKey(d => d.TarifficationAmountWorkId)
					.HasConstraintName("FK_Invoices_TarifficationAmountWork");
			});

			modelBuilder.Entity<InvoiceEmoneyPayment>(entity =>
			{
				entity.HasIndex(e => e.InvoiceId, "UK_InvoiceId_Unique")
					.IsUnique();

				entity.Property(e => e.WalletId).HasMaxLength(256);

				entity.HasOne(d => d.Invoice)
					.WithOne(p => p.InvoiceEmoneyPayment)
					.HasForeignKey<InvoiceEmoneyPayment>(d => d.InvoiceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InvoiceEmoneyPayment_Invoice");

				entity.HasOne(d => d.PaymentStatus)
					.WithMany(p => p.InvoiceEmoneyPayments)
					.HasForeignKey(d => d.PaymentStatusId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InvoiceEmoneyPayment_EmoneyPaymentStatus");
			});

			modelBuilder.Entity<InvoicePayment>(entity =>
			{
				entity.HasIndex(e => e.InvoiceId, "UK_InvoicePayment_Unique")
					.IsUnique();

				entity.Property(e => e.CreationDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(((1945)/(12))/(12))");

				entity.Property(e => e.LastModificationDate).HasColumnType("datetime");

				entity.Property(e => e.Note)
					.IsRequired()
					.HasMaxLength(200);

				entity.Property(e => e.PaymentDate).HasColumnType("datetime");

				entity.Property(e => e.PaymentDocumentNumber)
					.IsRequired()
					.HasMaxLength(100);

				entity.HasOne(d => d.Invoice)
					.WithOne(p => p.InvoicePayment)
					.HasForeignKey<InvoicePayment>(d => d.InvoiceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InvoicePayment_Invoice");
			});

			modelBuilder.Entity<InvoicePaymentRequisite>(entity =>
			{
				entity.HasKey(e => e.InvoicePaymentRequsitesId)
					.HasName("PK_InvoiceBankRequsites");

				entity.Property(e => e.Account)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.Address)
					.IsRequired()
					.HasMaxLength(512);

				entity.Property(e => e.BankCode)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.BankName)
					.IsRequired()
					.HasMaxLength(128);

				entity.Property(e => e.Payer)
					.IsRequired()
					.HasMaxLength(128);

				entity.Property(e => e.Unp)
					.IsRequired()
					.HasMaxLength(256);

				entity.HasOne(d => d.Country)
					.WithMany(p => p.InvoicePaymentRequisites)
					.HasForeignKey(d => d.CountryId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InvoicePaymentRequisites_Countries");

				entity.HasOne(d => d.InvoicePayment)
					.WithMany(p => p.InvoicePaymentRequisites)
					.HasForeignKey(d => d.InvoicePaymentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InvoiceBankRequisites_InvoicePayments1");
			});

			modelBuilder.Entity<JuridicalRequisite>(entity =>
			{
				entity.HasIndex(e => e.SecondaryAddressId, "IX_JuridicalRequisites_Address")
					.IsUnique();

				entity.Property(e => e.ChiefName)
					.IsRequired()
					.HasMaxLength(512);

				entity.Property(e => e.RepresenterName)
					.IsRequired()
					.HasMaxLength(512);

				entity.HasOne(d => d.SecondaryAddress)
					.WithOne(p => p.JuridicalRequisite)
					.HasForeignKey<JuridicalRequisite>(d => d.SecondaryAddressId)
					.HasConstraintName("FK_JuridicalRequisites_Address");
			});

			modelBuilder.Entity<Language>(entity =>
			{
				entity.Property(e => e.LanguageId).ValueGeneratedNever();

				entity.Property(e => e.Language1)
					.IsRequired()
					.HasMaxLength(50)
					.HasColumnName("Language");
			});

			modelBuilder.Entity<LocalRegistryMessage>(entity =>
			{
				entity.Property(e => e.DomainName)
					.IsRequired()
					.HasMaxLength(150)
					.IsUnicode(false);

				entity.Property(e => e.Message)
					.IsRequired()
					.IsUnicode(false);

				entity.Property(e => e.PendingActionUtcDate).HasColumnType("datetime");

				entity.Property(e => e.PendingExpirationUtcDate).HasColumnType("datetime");

				entity.HasOne(d => d.PendingOperation)
					.WithMany(p => p.LocalRegistryMessages)
					.HasForeignKey(d => d.PendingOperationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LocalRegistryMessage_PendingOperation");
			});

			modelBuilder.Entity<LogEvent>(entity =>
			{
				entity.Property(e => e.Value).IsRequired();

				entity.HasOne(d => d.LogEventType)
					.WithMany(p => p.LogEvents)
					.HasForeignKey(d => d.LogEventTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LogEvents_LogEventTypes");

				entity.HasOne(d => d.Log)
					.WithMany(p => p.LogEvents)
					.HasForeignKey(d => d.LogId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LogEvent_LogRepository");
			});

			modelBuilder.Entity<LogEventType>(entity =>
			{
				entity.Property(e => e.LogEventTypeId).ValueGeneratedNever();

				entity.Property(e => e.Description).IsRequired();
			});

			modelBuilder.Entity<LogNote>(entity =>
			{
				entity.ToTable("LogNote");

				entity.Property(e => e.Note).IsRequired();

				entity.HasOne(d => d.Log)
					.WithMany(p => p.LogNotes)
					.HasForeignKey(d => d.LogId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LogNote_LogRepository");
			});

			modelBuilder.Entity<LogRepository>(entity =>
			{
				entity.HasKey(e => e.LogId);

				entity.ToTable("LogRepository");

				entity.Property(e => e.LogDate).HasColumnType("datetime");

				entity.HasOne(d => d.LogType)
					.WithMany(p => p.LogRepositories)
					.HasForeignKey(d => d.LogTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LogRepository_LogType");

				entity.HasOne(d => d.User)
					.WithMany(p => p.LogRepositories)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LogRepository_Users");

				entity.HasOne(d => d.UserSession)
					.WithMany(p => p.LogRepositories)
					.HasForeignKey(d => d.UserSessionId)
					.HasConstraintName("FK_LogRepository_UserSessions");
			});

			modelBuilder.Entity<LogType>(entity =>
			{
				entity.Property(e => e.LogTypeId).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<NotificationEvent>(entity =>
			{
				entity.ToTable("NotificationEvent");

				entity.Property(e => e.NotificationEventId).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<NotificationSchedule>(entity =>
			{
				entity.Property(e => e.NotificationScheduleId).ValueGeneratedNever();

				entity.HasOne(d => d.ServiceType)
					.WithMany(p => p.NotificationSchedules)
					.HasForeignKey(d => d.ServiceTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_NotificationSchedules_ServiceTypes");
			});

			modelBuilder.Entity<NotificationServiceCurrentMessage>(entity =>
			{
				entity.HasOne(d => d.Client)
					.WithMany(p => p.NotificationServiceCurrentMessages)
					.HasForeignKey(d => d.ClientId)
					.HasConstraintName("FK_NotificationServiceCurrentMessages_Client");

				entity.HasOne(d => d.Service)
					.WithMany(p => p.NotificationServiceCurrentMessages)
					.HasForeignKey(d => d.ServiceId)
					.HasConstraintName("FK_NotificationServiceCurrentMessages_Services");
			});

			modelBuilder.Entity<OrderAction>(entity =>
			{
				entity.Property(e => e.OrderActionId).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(100);
			});

			modelBuilder.Entity<PassportRequisite>(entity =>
			{
				entity.HasKey(e => e.PassportRequisitesId);

				entity.Property(e => e.PassportIdentificationNumber).HasMaxLength(50);

				entity.Property(e => e.PassportIssue)
					.IsRequired()
					.HasMaxLength(256);

				entity.Property(e => e.PassportIssueDate)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.PassportNumber)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.PassportSeries).HasMaxLength(10);
			});

			modelBuilder.Entity<PasswordRecovery>(entity =>
			{
				entity.ToTable("PasswordRecovery");

				entity.Property(e => e.PasswordRecoveryId).HasColumnName("PasswordRecoveryID");

				entity.Property(e => e.Date).HasColumnType("datetime");

				entity.Property(e => e.RecoveryKey)
					.IsRequired()
					.HasMaxLength(256)
					.IsFixedLength();

				entity.Property(e => e.UserId).HasColumnName("UserID");

				entity.HasOne(d => d.User)
					.WithMany(p => p.PasswordRecoveries)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PasswordRecovery_Users");
			});

			modelBuilder.Entity<PasswordRecoveryType>(entity =>
			{
				entity.Property(e => e.PasswordRecoveryTypeId).ValueGeneratedNever();

				entity.Property(e => e.PasswordRecoveryTypeName)
					.IsRequired()
					.HasMaxLength(64);
			});

			modelBuilder.Entity<PaymentStatus>(entity =>
			{
				entity.Property(e => e.PaymentStatusId).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<PaymentType>(entity =>
			{
				entity.Property(e => e.PaymentTypeId).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<PendingOperation>(entity =>
			{
				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Period>(entity =>
			{
				entity.HasOne(d => d.PeriodUnit)
					.WithMany(p => p.Periods)
					.HasForeignKey(d => d.PeriodUnitId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Periods_PeriodUnits");
			});

			modelBuilder.Entity<PeriodUnit>(entity =>
			{
				entity.Property(e => e.PeriodUnitId).ValueGeneratedNever();

				entity.Property(e => e.Unit)
					.IsRequired()
					.HasMaxLength(32);
			});

			modelBuilder.Entity<PersonalDiscount>(entity =>
			{
				entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

				entity.Property(e => e.StartDate).HasColumnType("datetime");

				entity.HasOne(d => d.Client)
					.WithMany(p => p.PersonalDiscounts)
					.HasForeignKey(d => d.ClientId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PersonalDiscounts_Clients");
			});

			modelBuilder.Entity<PowerDnsregistryQueue>(entity =>
			{
				entity.ToTable("PowerDNSRegistryQueue");

				entity.Property(e => e.DomainName)
					.IsRequired()
					.HasMaxLength(256);

				entity.Property(e => e.TimePushInQueue).HasColumnType("datetime");

				entity.Property(e => e.XrrpResultCode).HasMaxLength(15);
			});

			modelBuilder.Entity<PromoCode>(entity =>
			{
				entity.Property(e => e.PeriodEnd).HasColumnType("datetime");

				entity.Property(e => e.PeriodStart).HasColumnType("datetime");
			});

			modelBuilder.Entity<PromoCodeDiscountValue>(entity =>
			{
				entity.Property(e => e.Discount).HasColumnType("decimal(30, 4)");

				entity.HasOne(d => d.Currency)
					.WithMany(p => p.PromoCodeDiscountValues)
					.HasForeignKey(d => d.CurrencyId)
					.HasConstraintName("FK_PromoCodeDiscountValues_Currency");

				entity.HasOne(d => d.PromoCode)
					.WithMany(p => p.PromoCodeDiscountValues)
					.HasForeignKey(d => d.PromoCodeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PromoCodeDiscountValues_PromoCode");
			});

			modelBuilder.Entity<PromoCodeService>(entity =>
			{
				entity.Property(e => e.DataPaid).HasColumnType("datetime");

				entity.HasOne(d => d.PromoCode)
					.WithMany(p => p.PromoCodeServices)
					.HasForeignKey(d => d.PromoCodeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PromoCodeServices_PromoCode");
			});

			modelBuilder.Entity<PromoCodeTypeService>(entity =>
			{
				entity.HasOne(d => d.Period)
					.WithMany(p => p.PromoCodeTypeServices)
					.HasForeignKey(d => d.PeriodId)
					.HasConstraintName("FK_PromoCodeTypeServices_Periods");

				entity.HasOne(d => d.PromoCode)
					.WithMany(p => p.PromoCodeTypeServices)
					.HasForeignKey(d => d.PromoCodeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PromoCodeTypeServices_PromoCode");

				entity.HasOne(d => d.ServiceType)
					.WithMany(p => p.PromoCodeTypeServices)
					.HasForeignKey(d => d.ServiceTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PromoCodeTypeServices_ServiceTypes");

				entity.HasOne(d => d.TariffPlan)
					.WithMany(p => p.PromoCodeTypeServices)
					.HasForeignKey(d => d.TariffPlanId)
					.HasConstraintName("FK_PromoCodeTypeServices_TariffPlan");

				entity.HasOne(d => d.TarifficationAmountWork)
					.WithMany(p => p.PromoCodeTypeServices)
					.HasForeignKey(d => d.TarifficationAmountWorkId)
					.HasConstraintName("FK_PromoCodeTypeServices_TarifficationAmountWork");
			});

			modelBuilder.Entity<Redirect>(entity =>
			{
				entity.Property(e => e.DomainName)
					.IsRequired()
					.HasMaxLength(260);

				entity.Property(e => e.RedirectUrl)
					.IsRequired()
					.HasMaxLength(260);

				entity.HasOne(d => d.Domain)
					.WithMany(p => p.Redirects)
					.HasForeignKey(d => d.DomainId)
					.HasConstraintName("FK_Redirects_Domains");

				entity.HasOne(d => d.RedirectAction)
					.WithMany(p => p.Redirects)
					.HasForeignKey(d => d.RedirectActionId)
					.HasConstraintName("FK_Redirects_RedirectActions");
			});

			modelBuilder.Entity<RedirectAction>(entity =>
			{
				entity.Property(e => e.RedirectActionId).ValueGeneratedNever();

				entity.Property(e => e.ActionName)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<Registrant>(entity =>
			{
				entity.Property(e => e.ChiefName).HasMaxLength(255);

				entity.Property(e => e.CreationDate).HasColumnType("datetime");

				entity.Property(e => e.EgrDecisionDate).HasMaxLength(255);

				entity.Property(e => e.EgrDecisionNumber).HasMaxLength(255);

				entity.Property(e => e.EgrNumber).HasMaxLength(255);

				entity.Property(e => e.EgrRegistrant).HasMaxLength(255);

				entity.Property(e => e.Email)
					.IsRequired()
					.HasMaxLength(255);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255);

				entity.Property(e => e.PassportIdentificationNumber).HasMaxLength(255);

				entity.Property(e => e.PassportIssue).HasMaxLength(255);

				entity.Property(e => e.PassportIssueDate).HasMaxLength(255);

				entity.Property(e => e.PassportNumber).HasMaxLength(255);

				entity.Property(e => e.PassportSeries).HasMaxLength(255);

				entity.Property(e => e.Phone)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Unp).HasMaxLength(255);

				entity.HasOne(d => d.Address)
					.WithMany(p => p.Registrants)
					.HasForeignKey(d => d.AddressId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Registrants_Addresses");

				entity.HasOne(d => d.ClientType)
					.WithMany(p => p.Registrants)
					.HasForeignKey(d => d.ClientTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Registrants_ClientTypes");
			});

			modelBuilder.Entity<RegistrationOwnership>(entity =>
			{
				entity.Property(e => e.RegistrationOwnershipId).ValueGeneratedNever();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(64);
			});

			modelBuilder.Entity<Role>(entity =>
			{
				entity.Property(e => e.RoleId).ValueGeneratedNever();

				entity.Property(e => e.RoleName)
					.IsRequired()
					.HasMaxLength(32);
			});

			modelBuilder.Entity<Service>(entity =>
			{
				entity.Property(e => e.CertificateAddress).HasMaxLength(300);

				entity.Property(e => e.ContractDate).HasColumnType("date");

				entity.Property(e => e.CpanelError).IsUnicode(false);

				entity.Property(e => e.DurationMonthes).HasDefaultValueSql("((1))");

				entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

				entity.Property(e => e.Login).HasMaxLength(100);

				entity.Property(e => e.ParentDomainName).HasMaxLength(256);

				entity.Property(e => e.PendingExpirationDate).HasColumnType("datetime");

				entity.Property(e => e.ServiceOrderDate).HasColumnType("datetime");

				entity.HasOne(d => d.Client)
					.WithMany(p => p.Services)
					.HasForeignKey(d => d.ClientId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Services_ClientRequisites");

				entity.HasOne(d => d.ParentService)
					.WithMany(p => p.InverseParentService)
					.HasForeignKey(d => d.ParentServiceId)
					.HasConstraintName("FK_Service_Service");

				entity.HasOne(d => d.ServiceStatus)
					.WithMany(p => p.Services)
					.HasForeignKey(d => d.ServiceStatusId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Service_ServiceStatus");

				entity.HasOne(d => d.ServiceType)
					.WithMany(p => p.Services)
					.HasForeignKey(d => d.ServiceTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Services_ServiceTypes");

				entity.HasOne(d => d.TariffPlan)
					.WithMany(p => p.Services)
					.HasForeignKey(d => d.TariffPlanId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Service_TariffPlan");

				entity.HasOne(d => d.TarifficationAmountWork)
					.WithMany(p => p.Services)
					.HasForeignKey(d => d.TarifficationAmountWorkId)
					.HasConstraintName("FK_Services_TarifficationAmountWork");

				entity.HasOne(d => d.WhoIsInfo)
					.WithMany(p => p.Services)
					.HasForeignKey(d => d.WhoIsInfoId)
					.HasConstraintName("FK_Services_WhoIsInfos");
			});

			modelBuilder.Entity<ServiceClass>(entity =>
			{
				entity.Property(e => e.ServiceClassId).ValueGeneratedNever();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(64);
			});

			modelBuilder.Entity<ServiceHistory>(entity =>
			{
				entity.ToTable("ServiceHistory");

				entity.Property(e => e.CostId).HasDefaultValueSql("((1))");

				entity.Property(e => e.DurationDays).HasDefaultValueSql("((1))");

				entity.Property(e => e.OrderActionId).HasDefaultValueSql("((1))");

				entity.Property(e => e.PaymentDate).HasColumnType("datetime");

				entity.Property(e => e.VatId).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.Client)
					.WithMany(p => p.ServiceHistories)
					.HasForeignKey(d => d.ClientId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ServiceHistory_Clients");

				entity.HasOne(d => d.Cost)
					.WithMany(p => p.ServiceHistories)
					.HasForeignKey(d => d.CostId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ServiceHistory_Costs");

				entity.HasOne(d => d.DomainHistory)
					.WithMany(p => p.ServiceHistories)
					.HasForeignKey(d => d.DomainHistoryId)
					.HasConstraintName("FK_ServiceHistory_DomainHistory");

				entity.HasOne(d => d.OrderAction)
					.WithMany(p => p.ServiceHistories)
					.HasForeignKey(d => d.OrderActionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ServiceHistory_OrderActions");

				entity.HasOne(d => d.ServiceType)
					.WithMany(p => p.ServiceHistories)
					.HasForeignKey(d => d.ServiceTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ServiceHistory_ServiceTypes");

				entity.HasOne(d => d.TarifficationAmountWork)
					.WithMany(p => p.ServiceHistories)
					.HasForeignKey(d => d.TarifficationAmountWorkId)
					.HasConstraintName("FK_ServiceHistory_TarifficationAmountWork");

				entity.HasOne(d => d.Vat)
					.WithMany(p => p.ServiceHistories)
					.HasForeignKey(d => d.VatId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ServiceHistory_Vats");
			});

			modelBuilder.Entity<ServiceInfo>(entity =>
			{
				entity.ToTable("ServiceInfo");

				entity.HasIndex(e => e.ServiceId, "UQ__ServiceI__C51BB00B0F2D40CE")
					.IsUnique();

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(1024);

				entity.HasOne(d => d.Service)
					.WithOne(p => p.ServiceInfo)
					.HasForeignKey<ServiceInfo>(d => d.ServiceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Services_ServiceInfo");
			});

			modelBuilder.Entity<ServiceNotificationQueue>(entity =>
			{
				entity.ToTable("ServiceNotificationQueue");

				entity.HasOne(d => d.NotificationEvent)
					.WithMany(p => p.ServiceNotificationQueues)
					.HasForeignKey(d => d.NotificationEventId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ServiceNotificationQueue_NotificationEvent");

				entity.HasOne(d => d.NotificationSchedule)
					.WithMany(p => p.ServiceNotificationQueues)
					.HasForeignKey(d => d.NotificationScheduleId)
					.HasConstraintName("FK_ServiceNotificationQueue_NotificationSchedules");

				entity.HasOne(d => d.Service)
					.WithMany(p => p.ServiceNotificationQueues)
					.HasForeignKey(d => d.ServiceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ServiceNotificationQueue_Services");
			});

			modelBuilder.Entity<ServiceRegistration>(entity =>
			{
				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(1024);

				entity.Property(e => e.DomainName)
					.IsRequired()
					.HasMaxLength(512);

				entity.Property(e => e.ManagerComment).HasMaxLength(1024);

				entity.Property(e => e.RegistrationNumber).HasMaxLength(128);

				entity.Property(e => e.ServiceRegistrationStatusId).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.Client)
					.WithMany(p => p.ServiceRegistrations)
					.HasForeignKey(d => d.ClientId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ServiceRegistrations_Clients");

				entity.HasOne(d => d.HostingServer)
					.WithMany(p => p.ServiceRegistrations)
					.HasForeignKey(d => d.HostingServerId)
					.HasConstraintName("FK_ServiceRegistrations_HostingServers");

				entity.HasOne(d => d.ParentService)
					.WithMany(p => p.ServiceRegistrationParentServices)
					.HasForeignKey(d => d.ParentServiceId)
					.HasConstraintName("FK_ServiceRegistrations_Services");

				entity.HasOne(d => d.RegistrationOwnership)
					.WithMany(p => p.ServiceRegistrations)
					.HasForeignKey(d => d.RegistrationOwnershipId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ServiceRegistrations_RegistrationOwnerships");

				entity.HasOne(d => d.ServiceRegistrationStatus)
					.WithMany(p => p.ServiceRegistrations)
					.HasForeignKey(d => d.ServiceRegistrationStatusId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ServiceRegistrations_ServiceRegistrationStatuses");

				entity.HasOne(d => d.TaxService)
					.WithMany(p => p.ServiceRegistrationTaxServices)
					.HasForeignKey(d => d.TaxServiceId)
					.HasConstraintName("FK_ServiceRegistrations_TaxService");
			});

			modelBuilder.Entity<ServiceRegistrationStatus>(entity =>
			{
				entity.Property(e => e.ServiceRegistrationStatusId).ValueGeneratedNever();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(64);
			});

			modelBuilder.Entity<ServiceStatistic>(entity =>
			{
				entity.Property(e => e.Date).HasColumnType("date");

				entity.Property(e => e.ServiceName)
					.IsRequired()
					.HasMaxLength(100);
			});

			modelBuilder.Entity<ServiceStatus>(entity =>
			{
				entity.Property(e => e.ServiceStatusId).ValueGeneratedNever();

				entity.Property(e => e.Description).HasMaxLength(50);
			});

			modelBuilder.Entity<ServiceType>(entity =>
			{
				entity.Property(e => e.ServiceTypeId).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(50);

				entity.HasOne(d => d.ServiceClass)
					.WithMany(p => p.ServiceTypes)
					.HasForeignKey(d => d.ServiceClassId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ServiceTypes_ServiceClasses");
			});

			modelBuilder.Entity<ServicesInHistory>(entity =>
			{
				entity.ToTable("ServicesInHistory");

				entity.HasOne(d => d.ServiceHistory)
					.WithMany(p => p.ServicesInHistories)
					.HasForeignKey(d => d.ServiceHistoryId)
					.HasConstraintName("FK_ServicesInHistory_ServiceHistory");

				entity.HasOne(d => d.Service)
					.WithMany(p => p.ServicesInHistories)
					.HasForeignKey(d => d.ServiceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ServicesInHistory_Services");
			});

			modelBuilder.Entity<SslApiQueue>(entity =>
			{
				entity.ToTable("SslApiQueue");

				entity.Property(e => e.Address).HasMaxLength(128);

				entity.Property(e => e.ApproverEmail)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.City)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.DomainName)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.Email)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.OrderActionId).HasDefaultValueSql("((1))");

				entity.Property(e => e.OrganizationName)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.Phone)
					.IsRequired()
					.HasMaxLength(20);

				entity.Property(e => e.PostalCode)
					.IsRequired()
					.HasMaxLength(30);

				entity.Property(e => e.ProductName)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.Region)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.ServerName)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.ValidMethod)
					.IsRequired()
					.HasMaxLength(10);

				entity.HasOne(d => d.ClientType)
					.WithMany(p => p.SslApiQueues)
					.HasForeignKey(d => d.ClientTypeId)
					.HasConstraintName("FK_SslApiQueue_ClientType");

				entity.HasOne(d => d.Country)
					.WithMany(p => p.SslApiQueues)
					.HasForeignKey(d => d.CountryId)
					.HasConstraintName("FK_SslApiQueue_Countries");

				entity.HasOne(d => d.OrderAction)
					.WithMany(p => p.SslApiQueues)
					.HasForeignKey(d => d.OrderActionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SslApiQueue_OrderAction");

				entity.HasOne(d => d.Service)
					.WithMany(p => p.SslApiQueues)
					.HasForeignKey(d => d.ServiceId)
					.HasConstraintName("FK_SslApiQueue_Services");

				entity.HasOne(d => d.SslCertificateType)
					.WithMany(p => p.SslApiQueues)
					.HasForeignKey(d => d.SslCertificateTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SslCertificateTypes_ClientInfoForSslOrder");
			});

			modelBuilder.Entity<SslCertificateType>(entity =>
			{
				entity.Property(e => e.SslCertificateTypeId).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<SslOrderStatus>(entity =>
			{
				entity.Property(e => e.SslOrderStatusId).ValueGeneratedNever();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<SslService>(entity =>
			{
				entity.Property(e => e.Csr).HasColumnName("CSR");

				entity.Property(e => e.Email).HasMaxLength(64);

				entity.Property(e => e.Pk).HasColumnName("PK");

				entity.Property(e => e.PlacementDate).HasColumnType("datetime");

				entity.HasOne(d => d.Service)
					.WithMany(p => p.SslServices)
					.HasForeignKey(d => d.ServiceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SslServices_Services");

				entity.HasOne(d => d.SslVerificationType)
					.WithMany(p => p.SslServices)
					.HasForeignKey(d => d.SslVerificationTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SslServices_SslVerificationTypes");
			});

			modelBuilder.Entity<SslTariffSetting>(entity =>
			{
				entity.HasOne(d => d.ParentTariffPlan)
					.WithMany(p => p.SslTariffSettingParentTariffPlans)
					.HasForeignKey(d => d.ParentTariffPlanId)
					.HasConstraintName("FK_SslTariffSettings_TariffPlans1");

				entity.HasOne(d => d.SslCertificateType)
					.WithMany(p => p.SslTariffSettings)
					.HasForeignKey(d => d.SslCertificateTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SslTariffSettings_SslCertificateTypes");

				entity.HasOne(d => d.TariffPlan)
					.WithMany(p => p.SslTariffSettingTariffPlans)
					.HasForeignKey(d => d.TariffPlanId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SslTariffSettings_TariffPlans");
			});

			modelBuilder.Entity<SslVerification>(entity =>
			{
				entity.HasOne(d => d.SslTariffSetting)
					.WithMany(p => p.SslVerifications)
					.HasForeignKey(d => d.SslTariffSettingId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SslVerifications_SslTariffSettings");

				entity.HasOne(d => d.SslVerificationType)
					.WithMany(p => p.SslVerifications)
					.HasForeignKey(d => d.SslVerificationTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SslVerifications_SslVerificationTypes");
			});

			modelBuilder.Entity<SslVerificationType>(entity =>
			{
				entity.Property(e => e.SslVerificationTypeId).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<Statistic>(entity =>
			{
				entity.ToTable("Statistic");

				entity.Property(e => e.ActionDate).HasColumnType("datetime");

				entity.Property(e => e.DomainName).IsRequired();

				entity.HasOne(d => d.ActionType)
					.WithMany(p => p.Statistics)
					.HasForeignKey(d => d.ActionTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Statistic_ActionType");

				entity.HasOne(d => d.Client)
					.WithMany(p => p.Statistics)
					.HasForeignKey(d => d.ClientId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Statistic_Clients");

				entity.HasOne(d => d.DomainZone)
					.WithMany(p => p.Statistics)
					.HasForeignKey(d => d.DomainZoneId)
					.HasConstraintName("FK_Statistic_DomainZones");

				entity.HasOne(d => d.ServiceHistory)
					.WithMany(p => p.Statistics)
					.HasForeignKey(d => d.ServiceHistoryId)
					.OnDelete(DeleteBehavior.Cascade)
					.HasConstraintName("FK_Statistic_ServiceHistory");

				entity.HasOne(d => d.TariffPlan)
					.WithMany(p => p.Statistics)
					.HasForeignKey(d => d.TariffPlanId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Statistic_TariffPlans");

				entity.HasOne(d => d.TarifficationAmountWork)
					.WithMany(p => p.Statistics)
					.HasForeignKey(d => d.TarifficationAmountWorkId)
					.HasConstraintName("FK_Statistic_TarifficationAmountWork");
			});

			modelBuilder.Entity<SystemNotification>(entity =>
			{
				entity.Property(e => e.CreateDate).HasColumnType("datetime");

				entity.Property(e => e.Description).IsRequired();

				entity.Property(e => e.UpdateDate).HasColumnType("datetime");

				entity.HasOne(d => d.SystemNotificationErrorLevelType)
					.WithMany(p => p.SystemNotifications)
					.HasForeignKey(d => d.SystemNotificationErrorLevelTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SystemNotifications_SystemNotificationErrorLevels");

				entity.HasOne(d => d.SystemNotificationType)
					.WithMany(p => p.SystemNotifications)
					.HasForeignKey(d => d.SystemNotificationTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SystemNotifications_SystemNotificationTypes");
			});

			modelBuilder.Entity<SystemNotificationErrorLevel>(entity =>
			{
				entity.HasKey(e => e.SystemNotificationErrorLevelTypeId)
					.HasName("PK_SystemNotificationsErrorLevel");

				entity.Property(e => e.SystemNotificationErrorLevelTypeId).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(100);
			});

			modelBuilder.Entity<SystemNotificationType>(entity =>
			{
				entity.Property(e => e.SystemNotificationTypeId).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(100);
			});

			modelBuilder.Entity<TariffPlan>(entity =>
			{
				entity.Property(e => e.PeriodUnitId).HasDefaultValueSql("((1))");

				entity.Property(e => e.UniqueName).HasMaxLength(256);

				entity.HasOne(d => d.DomainZone)
					.WithMany(p => p.TariffPlans)
					.HasForeignKey(d => d.DomainZoneId)
					.HasConstraintName("FK_TariffPlans_DomainZones");

				entity.HasOne(d => d.PeriodUnit)
					.WithMany(p => p.TariffPlans)
					.HasForeignKey(d => d.PeriodUnitId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TariffPlans_PeriodUnits");

				entity.HasOne(d => d.ServiceType)
					.WithMany(p => p.TariffPlans)
					.HasForeignKey(d => d.ServiceTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TariffPlans_ServiceTypes");

				entity.HasOne(d => d.TariffPlanTarificationType)
					.WithMany(p => p.TariffPlans)
					.HasForeignKey(d => d.TariffPlanTarificationTypeId)
					.HasConstraintName("FK_TariffPlans_TariffPlanTarificationTypes");
			});

			modelBuilder.Entity<TariffPlanCost>(entity =>
			{
				entity.Property(e => e.OrderActionId).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.Cost)
					.WithMany(p => p.TariffPlanCosts)
					.HasForeignKey(d => d.CostId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TariffPlanCost_Costs");

				entity.HasOne(d => d.OrderAction)
					.WithMany(p => p.TariffPlanCosts)
					.HasForeignKey(d => d.OrderActionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TariffPlanCost_OrderAction");

				entity.HasOne(d => d.TariffPlan)
					.WithMany(p => p.TariffPlanCosts)
					.HasForeignKey(d => d.TariffPlanId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TariffPlanCost_TariffPlan");
			});

			modelBuilder.Entity<TariffPlanDuration>(entity =>
			{
				entity.Property(e => e.DurationMonths).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.Period)
					.WithMany(p => p.TariffPlanDurations)
					.HasForeignKey(d => d.PeriodId)
					.HasConstraintName("FK_TariffPlanDurations_Periods");

				entity.HasOne(d => d.TariffPlan)
					.WithMany(p => p.TariffPlanDurations)
					.HasForeignKey(d => d.TariffPlanId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TariffPlanDuration_TariffPlan");

				entity.HasOne(d => d.TarifficationAmountWork)
					.WithMany(p => p.TariffPlanDurations)
					.HasForeignKey(d => d.TarifficationAmountWorkId)
					.HasConstraintName("FK_TariffPlanDurations_TarifficationAmountWork");
			});

			modelBuilder.Entity<TariffPlanInfo>(entity =>
			{
				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(200);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(200);

				entity.HasOne(d => d.Language)
					.WithMany(p => p.TariffPlanInfos)
					.HasForeignKey(d => d.LanguageId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TariffPlanInfo_Language1");

				entity.HasOne(d => d.TariffPlan)
					.WithMany(p => p.TariffPlanInfos)
					.HasForeignKey(d => d.TariffPlanId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TariffPlanInfo_TariffPlan1");
			});

			modelBuilder.Entity<TariffPlanTarificationType>(entity =>
			{
				entity.Property(e => e.TariffPlanTarificationTypeId).ValueGeneratedNever();

				entity.Property(e => e.Value)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<TarifficationAmountWork>(entity =>
			{
				entity.ToTable("TarifficationAmountWork");

				entity.Property(e => e.ValueWork).HasColumnType("decimal(10, 2)");

				entity.HasOne(d => d.PeriodUnits)
					.WithMany(p => p.TarifficationAmountWorks)
					.HasForeignKey(d => d.PeriodUnitsId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TarifficationAmountWork_PeriodUnits");
			});

			modelBuilder.Entity<TransferIncomingRequest>(entity =>
			{
				entity.HasKey(e => e.DomainId);

				entity.Property(e => e.DomainId).ValueGeneratedNever();

				entity.Property(e => e.Comment).HasMaxLength(300);

				entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

				entity.Property(e => e.RequestDate).HasColumnType("datetime");

				entity.HasOne(d => d.Domain)
					.WithOne(p => p.TransferIncomingRequest)
					.HasForeignKey<TransferIncomingRequest>(d => d.DomainId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TransferIncomingRequests_Domains");
			});

			modelBuilder.Entity<TransferOperation>(entity =>
			{
				entity.Property(e => e.TransferOperationId).ValueGeneratedNever();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50)
					.IsFixedLength();
			});

			modelBuilder.Entity<TransferOutgoingRequest>(entity =>
			{
				entity.HasIndex(e => e.DomainName, "UK_DomainName")
					.IsUnique();

				entity.Property(e => e.AnswerDate).HasColumnType("datetime");

				entity.Property(e => e.Comment)
					.IsRequired()
					.HasMaxLength(300);

				entity.Property(e => e.DomainName)
					.IsRequired()
					.HasMaxLength(260);

				entity.Property(e => e.RequestDate).HasColumnType("datetime");

				entity.HasOne(d => d.Client)
					.WithMany(p => p.TransferOutgoingRequests)
					.HasForeignKey(d => d.ClientId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TransferOutgoingRequests_Clients");

				entity.HasOne(d => d.TransferOperation)
					.WithMany(p => p.TransferOutgoingRequests)
					.HasForeignKey(d => d.TransferOperationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TransferOutgoingRequests_TransferOperations");
			});

			modelBuilder.Entity<UnsentMail>(entity =>
			{
				entity.ToTable("UnsentMail");

				entity.Property(e => e.Body).IsRequired();

				entity.Property(e => e.EmailFromId).HasDefaultValueSql("((1))");

				entity.Property(e => e.SendTo).IsRequired();

				entity.Property(e => e.SendingFailedDate).HasColumnType("datetime");

				entity.Property(e => e.Subject).IsRequired();

				entity.HasOne(d => d.EmailFrom)
					.WithMany(p => p.UnsentMails)
					.HasForeignKey(d => d.EmailFromId)
					.HasConstraintName("FK_UnsentMail_EmailFroms");
			});

			modelBuilder.Entity<UnsentSmsMessage>(entity =>
			{
				entity.Property(e => e.PhoneNumber)
					.IsRequired()
					.HasMaxLength(15);

				entity.Property(e => e.SendingDate).HasColumnType("datetime");

				entity.Property(e => e.SmsText)
					.IsRequired()
					.HasMaxLength(500);

				entity.HasOne(d => d.Client)
					.WithMany(p => p.UnsentSmsMessages)
					.HasForeignKey(d => d.ClientId)
					.HasConstraintName("FK_UnsentSmsMessages_Clients");
			});

			modelBuilder.Entity<User>(entity =>
			{
				entity.HasIndex(e => e.Login, "UK_Login_Unique")
					.IsUnique();

				entity.Property(e => e.Email)
					.IsRequired()
					.HasMaxLength(64);

				entity.Property(e => e.LastVisitDate).HasColumnType("datetime");

				entity.Property(e => e.Login)
					.IsRequired()
					.HasMaxLength(128);

				entity.Property(e => e.Password)
					.IsRequired()
					.HasMaxLength(32);

				entity.Property(e => e.RegistrationDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(((1945)/(12))/(12))");
			});

			modelBuilder.Entity<UserInRole>(entity =>
			{
				entity.HasKey(e => e.UserInRolesId);

				entity.HasIndex(e => new { e.UserId, e.RoleId }, "UK_UserInRoles")
					.IsUnique();

				entity.HasOne(d => d.Role)
					.WithMany(p => p.UserInRoles)
					.HasForeignKey(d => d.RoleId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserInRoles_Role");

				entity.HasOne(d => d.User)
					.WithMany(p => p.UserInRoles)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserInRoles_Users");
			});

			modelBuilder.Entity<UserLog>(entity =>
			{
				entity.ToTable("UserLog");

				entity.HasOne(d => d.Log)
					.WithMany(p => p.UserLogs)
					.HasForeignKey(d => d.LogId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserLog_LogRepository");

				entity.HasOne(d => d.User)
					.WithMany(p => p.UserLogs)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserLog_Users");
			});

			modelBuilder.Entity<UserSession>(entity =>
			{
				entity.Property(e => e.Ip)
					.IsRequired()
					.HasMaxLength(16)
					.IsFixedLength();

				entity.Property(e => e.StartDate).HasColumnType("datetime");
			});

			modelBuilder.Entity<Variable>(entity =>
			{
				entity.HasKey(e => e.Name);

				entity.Property(e => e.Name)
					.HasMaxLength(32)
					.IsFixedLength();

				entity.Property(e => e.Value).HasMaxLength(256);
			});

			modelBuilder.Entity<Vat>(entity =>
			{
				entity.Property(e => e.OfficialCreationDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("('1945/12/12')");

				entity.Property(e => e.StartDate).HasColumnType("date");
			});

			modelBuilder.Entity<VerificationField>(entity =>
			{
				entity.Property(e => e.VerificationFieldId).ValueGeneratedNever();

				entity.Property(e => e.Field)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<VerificationLog>(entity =>
			{
				entity.ToTable("VerificationLog");

				entity.Property(e => e.CreationDate).HasColumnType("datetime");

				entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

				entity.Property(e => e.VerificationDate).HasColumnType("datetime");

				entity.Property(e => e.VerificationKey)
					.IsRequired()
					.HasMaxLength(50);

				entity.HasOne(d => d.VerificationResult)
					.WithMany(p => p.VerificationLogs)
					.HasForeignKey(d => d.VerificationResultId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_VerificationLog_VerificationResults");
			});

			modelBuilder.Entity<VerificationResult>(entity =>
			{
				entity.HasOne(d => d.Client)
					.WithMany(p => p.VerificationResults)
					.HasForeignKey(d => d.ClientId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_VerificationResults_Clients");

				entity.HasOne(d => d.VerificationField)
					.WithMany(p => p.VerificationResults)
					.HasForeignKey(d => d.VerificationFieldId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_VerificationResults_VerificationFields");

				entity.HasOne(d => d.VerificationStatus)
					.WithMany(p => p.VerificationResults)
					.HasForeignKey(d => d.VerificationStatusId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_VerificationResults_VerificationStatuses");
			});

			modelBuilder.Entity<VerificationStatus>(entity =>
			{
				entity.Property(e => e.VerificationStatusId).ValueGeneratedNever();

				entity.Property(e => e.VerificationStatus1)
					.IsRequired()
					.HasMaxLength(50)
					.HasColumnName("VerificationStatus");
			});

			modelBuilder.Entity<VirtualHosting>(entity =>
			{
				entity.ToTable("VirtualHosting");

				entity.HasOne(d => d.HostingServer)
					.WithMany(p => p.VirtualHostings)
					.HasForeignKey(d => d.HostingServerId)
					.HasConstraintName("FK_VirtualHosting_HostingServers");

				entity.HasOne(d => d.Service)
					.WithMany(p => p.VirtualHostings)
					.HasForeignKey(d => d.ServiceId)
					.HasConstraintName("FK_VirtualHosting_Services");
			});

			modelBuilder.Entity<Vp>(entity =>
			{
				entity.HasKey(e => e.VpsId);

				entity.Property(e => e.Comment).HasMaxLength(1024);

				entity.Property(e => e.VirtManagerName).HasMaxLength(100);

				entity.HasOne(d => d.Service)
					.WithMany(p => p.Vps)
					.HasForeignKey(d => d.ServiceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Vps_Services");

				entity.HasOne(d => d.VpsConfig)
					.WithMany(p => p.Vps)
					.HasForeignKey(d => d.VpsConfigId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Vps_VpsConfigs");
			});

			modelBuilder.Entity<VpsConfig>(entity =>
			{
				entity.HasOne(d => d.OsType)
					.WithMany(p => p.VpsConfigs)
					.HasForeignKey(d => d.OsTypeId)
					.HasConstraintName("FK_VpsConfigs_VpsOsTypes");
			});

			modelBuilder.Entity<VpsConfigItemsCost>(entity =>
			{
				entity.Property(e => e.CpuCore).HasColumnType("decimal(30, 10)");

				entity.Property(e => e.CreationDate).HasColumnType("datetime");

				entity.Property(e => e.HddPerMb).HasColumnType("decimal(30, 10)");

				entity.Property(e => e.IpDefault).HasColumnType("decimal(30, 10)");

				entity.Property(e => e.RamPerMb).HasColumnType("decimal(30, 10)");

				entity.Property(e => e.SsdPerMb).HasColumnType("decimal(30, 10)");

				entity.HasOne(d => d.Currency)
					.WithMany(p => p.VpsConfigItemsCosts)
					.HasForeignKey(d => d.CurrencyId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_VpsConfigItemsCosts_Currencies");
			});

			modelBuilder.Entity<VpsDrife>(entity =>
			{
				entity.HasKey(e => e.VpsDriveId);

				entity.HasOne(d => d.DriveType)
					.WithMany(p => p.VpsDrives)
					.HasForeignKey(d => d.DriveTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_VpsDrives_VpsDriveTypes");

				entity.HasOne(d => d.VpsConfig)
					.WithMany(p => p.VpsDrives)
					.HasForeignKey(d => d.VpsConfigId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_VpsDrives_VpsConfigs");
			});

			modelBuilder.Entity<VpsDriveType>(entity =>
			{
				entity.Property(e => e.VpsDriveTypeId).ValueGeneratedNever();

				entity.Property(e => e.Value)
					.IsRequired()
					.HasMaxLength(20);
			});

			modelBuilder.Entity<VpsOsType>(entity =>
			{
				entity.Property(e => e.InternalName)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Uuid)
					.IsRequired()
					.HasMaxLength(50)
					.HasColumnName("UUID");
			});

			modelBuilder.Entity<VpsTariffPlan>(entity =>
			{
				entity.HasOne(d => d.TariffPlan)
					.WithMany(p => p.VpsTariffPlans)
					.HasForeignKey(d => d.TariffPlanId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_VpsTariffPlans_TariffPlans");

				entity.HasOne(d => d.VpsTariffPlanConfig)
					.WithMany(p => p.VpsTariffPlans)
					.HasForeignKey(d => d.VpsTariffPlanConfigId)
					.HasConstraintName("FK_VpsTariffPlans_VpsTariffPlanConfigs");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		private void OnModelCreatingPartial(ModelBuilder modelBuilder)
		{
			throw new NotImplementedException();
		}
	}
}
