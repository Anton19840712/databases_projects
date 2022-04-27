

namespace WebApplicationOpen.Models.Scaffold
{
	public class LogNote
	{
		public long LogNoteId { get; set; }
		public long LogId { get; set; }
		public string Note { get; set; }

		public virtual LogRepository Log { get; set; }
	}
}
