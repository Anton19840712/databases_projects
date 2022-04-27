using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("PendingOperation")]
	public sealed class PendingOperationDal
	{
		public PendingOperationDal()
		{
			LocalRegistryMessages = new HashSet<LocalRegistryMessageDal>();
		}

		public int PendingOperationId { get; set; }
		public string Description { get; set; }

		public ICollection<LocalRegistryMessageDal> LocalRegistryMessages { get; set; }
	}
}
