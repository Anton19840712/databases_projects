using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("VpsDriveType")]
	public sealed class VpsDriveTypeDal
	{
		public VpsDriveTypeDal()
		{
			VpsDrives = new HashSet<VpsDrifeDal>();
		}

		public int VpsDriveTypeId { get; set; }
		public string Value { get; set; }

		public ICollection<VpsDrifeDal> VpsDrives { get; set; }
	}
}
