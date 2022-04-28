using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("LogType")]
	public sealed class LogTypeDal
	{
		public LogTypeDal()
		{
			LogRepositories = new HashSet<LogRepositoryDal>();
		}

		[Key]
		public int LogTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<LogRepositoryDal> LogRepositories { get; set; }
	}
}
