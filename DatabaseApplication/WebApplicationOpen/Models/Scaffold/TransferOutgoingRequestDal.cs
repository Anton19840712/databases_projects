using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("TransferOutgoingRequest")]
	public class TransferOutgoingRequestDal
	{
		[Key]
		public long TransferOutgoingRequestId { get; set; }
		public long ClientId { get; set; }
		public string DomainName { get; set; }
		public string Comment { get; set; }
		public DateTime RequestDate { get; set; }
		public DateTime? AnswerDate { get; set; }
		public int TransferOperationId { get; set; }

		public virtual ClientDal Client { get; set; }
		public virtual TransferOperationDal TransferOperation { get; set; }
	}
}
