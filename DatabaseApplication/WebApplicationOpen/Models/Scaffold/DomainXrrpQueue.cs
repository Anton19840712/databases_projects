using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class DomainXrrpQueue
	{
		public long DomainQueueId { get; set; }
		public long DomainId { get; set; }
		public int XrrpCommand { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime? FailUpdateDate { get; set; }

		public virtual Domain Domain { get; set; }
	}
}
