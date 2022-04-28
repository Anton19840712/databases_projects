using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.VirtualHosting
{
	[Table("HostingServerTypes")]
	public sealed class HostingServerTypeDal
	{
		public HostingServerTypeDal()
		{
			HostingServers = new HashSet<HostingServerDal>();
		}

		[Key]
		public int HostingServerTypeId { get; set; }
		public string Name { get; set; }

		public ICollection<HostingServerDal> HostingServers { get; set; }
	}
}
