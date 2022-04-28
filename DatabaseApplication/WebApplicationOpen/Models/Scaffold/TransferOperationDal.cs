using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("TransferOperation")]
	public sealed class TransferOperationDal
	{
		public TransferOperationDal()
		{
			TransferOutgoingRequests = new HashSet<TransferOutgoingRequestDal>();
		}

		[Key]
		public int TransferOperationId { get; set; }
		public string Name { get; set; }

		public ICollection<TransferOutgoingRequestDal> TransferOutgoingRequests { get; set; }
	}
}
