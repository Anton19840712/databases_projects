﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("HostingServerType")]
	public sealed class HostingServerTypeDal
	{
		public HostingServerTypeDal()
		{
			HostingServers = new HashSet<HostingServerDal>();
		}

		public int HostingServerTypeId { get; set; }
		public string Name { get; set; }

		public ICollection<HostingServerDal> HostingServers { get; set; }
	}
}
