using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Domains
{
	[Table("LocalRegistryMessages")]
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
