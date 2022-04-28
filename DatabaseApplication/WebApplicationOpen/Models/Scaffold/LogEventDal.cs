﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("LogEvent")]
	public class LogEventDal
	{
		[Key]
		public long LogEventId { get; set; }
		public long LogId { get; set; }
		public long LogEventTypeId { get; set; }
		public string Value { get; set; }

		public virtual LogRepositoryDal Log { get; set; }
		public virtual LogEventTypeDal LogEventType { get; set; }
	}
}
