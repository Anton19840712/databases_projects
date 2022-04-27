using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class LocalRegistryMessage
	{
		public long LocalRegistryMessageId { get; set; }
		public string DomainName { get; set; }
		public int PendingOperationId { get; set; }
		public DateTime PendingExpirationUtcDate { get; set; }
		public DateTime PendingActionUtcDate { get; set; }
		public string Message { get; set; }

		public virtual PendingOperation PendingOperation { get; set; }
	}
}
