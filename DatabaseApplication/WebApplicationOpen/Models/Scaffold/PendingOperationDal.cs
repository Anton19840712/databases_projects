using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("PendingOperation")]
	public sealed class PendingOperationDal
	{
		public PendingOperationDal()
		{
			LocalRegistryMessages = new HashSet<LocalRegistryMessageDal>();
		}

		[Key]
		public int PendingOperationId { get; set; }
		public string Description { get; set; }

		public ICollection<LocalRegistryMessageDal> LocalRegistryMessages { get; set; }
	}
}
