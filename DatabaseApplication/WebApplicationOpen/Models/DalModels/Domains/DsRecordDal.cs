using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Domains
{
	[Table("DsRecords")]
	public class DsRecordDal
	{
		[Key]
		public long DsRecordId { get; set; }
		public long DomainId { get; set; }
		public string Tag { get; set; }
		public string Alg { get; set; }
		public string Type { get; set; }
		public string Digest { get; set; }

		public virtual DomainDal Domain { get; set; }
	}
}
