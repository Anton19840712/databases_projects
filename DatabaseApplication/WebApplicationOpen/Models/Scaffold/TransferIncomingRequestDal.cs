using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("TransferIncomingRequest")]
	public class TransferIncomingRequestDal
	{
		public long DomainId { get; set; }
		public DateTime RequestDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public string Comment { get; set; }

		public virtual DomainDal Domain { get; set; }
	}
}
