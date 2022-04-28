using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("LogNote")]
	public class LogNoteDal
	{
		[Key]
		public long LogNoteId { get; set; }
		public long LogId { get; set; }
		public string Note { get; set; }

		public virtual LogRepositoryDal Log { get; set; }
	}
}
