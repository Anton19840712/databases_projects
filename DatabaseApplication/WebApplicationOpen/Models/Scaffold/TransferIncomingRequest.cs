using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class TransferIncomingRequest
	{
		public long DomainId { get; set; }
		public DateTime RequestDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public string Comment { get; set; }

		public virtual Domain Domain { get; set; }
	}
}
