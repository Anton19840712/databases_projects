using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("LogType")]
	public sealed class LogTypeDal
	{
		public LogTypeDal()
		{
			LogRepositories = new HashSet<LogRepository>();
		}

		public int LogTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<LogRepository> LogRepositories { get; set; }
	}
}
