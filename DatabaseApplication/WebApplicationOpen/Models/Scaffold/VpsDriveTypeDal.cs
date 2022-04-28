using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("VpsDriveType")]
	public sealed class VpsDriveTypeDal
	{
		public VpsDriveTypeDal()
		{
			VpsDrives = new HashSet<VpsDrifeDal>();
		}

		[Key]
		public int VpsDriveTypeId { get; set; }
		public string Value { get; set; }

		public ICollection<VpsDrifeDal> VpsDrives { get; set; }
	}
}
