using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class VpsDriveType
	{
		public VpsDriveType()
		{
			VpsDrives = new HashSet<VpsDrife>();
		}

		public int VpsDriveTypeId { get; set; }
		public string Value { get; set; }

		public ICollection<VpsDrife> VpsDrives { get; set; }
	}
}
