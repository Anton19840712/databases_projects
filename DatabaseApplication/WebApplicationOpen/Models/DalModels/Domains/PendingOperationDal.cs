using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Domains
{
	[Table("PendingOperations")]
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
