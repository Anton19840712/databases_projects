using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class PendingOperation
	{
		public PendingOperation()
		{
			LocalRegistryMessages = new HashSet<LocalRegistryMessage>();
		}

		public int PendingOperationId { get; set; }
		public string Description { get; set; }

		public virtual ICollection<LocalRegistryMessage> LocalRegistryMessages { get; set; }
	}
}
