using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("LocalRegistryMessage")]
	public class LocalRegistryMessageDal
	{
		[Key]
		public long LocalRegistryMessageId { get; set; }
		public string DomainName { get; set; }
		public int PendingOperationId { get; set; }
		public DateTime PendingExpirationUtcDate { get; set; }
		public DateTime PendingActionUtcDate { get; set; }
		public string Message { get; set; }

		public virtual PendingOperationDal PendingOperation { get; set; }
	}
}
