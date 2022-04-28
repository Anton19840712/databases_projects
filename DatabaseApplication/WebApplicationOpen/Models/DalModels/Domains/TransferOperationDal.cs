using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Domains
{
	[Table("TransferOperations")]
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
