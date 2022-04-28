using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Vps
{
	[Table("VpsDriveTypes")]
	public sealed class VpsDriveTypeDal
	{
		public VpsDriveTypeDal()
		{
			VpsDrives = new HashSet<VpsDriveDal>();
		}

		[Key]
		public int VpsDriveTypeId { get; set; }
		public string Value { get; set; }

		public ICollection<VpsDriveDal> VpsDrives { get; set; }
	}
}
