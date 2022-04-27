

namespace WebApplicationOpen.Models.Scaffold
{
	public class DsRecord
	{
		public long DsRecordId { get; set; }
		public long DomainId { get; set; }
		public string Tag { get; set; }
		public string Alg { get; set; }
		public string Type { get; set; }
		public string Digest { get; set; }

		public virtual Domain Domain { get; set; }
	}
}
