using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class TransferOperation
	{
		public TransferOperation()
		{
			TransferOutgoingRequests = new HashSet<TransferOutgoingRequest>();
		}

		public int TransferOperationId { get; set; }
		public string Name { get; set; }

		public ICollection<TransferOutgoingRequest> TransferOutgoingRequests { get; set; }
	}
}
