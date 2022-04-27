using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class SslService
	{
		public long SslServiceId { get; set; }
		public long ServiceId { get; set; }
		public int SslVerificationTypeId { get; set; }
		public string Email { get; set; }
		public long? ApiOrderId { get; set; }
		public int? SslOrderStatusId { get; set; }
		public DateTime? PlacementDate { get; set; }
		public bool IsAct { get; set; }
		public long? SslThatWasRenewedOldOrderId { get; set; }
		public string Pk { get; set; }
		public string Csr { get; set; }

		public virtual Service Service { get; set; }
		public virtual SslVerificationType SslVerificationType { get; set; }
	}
}
