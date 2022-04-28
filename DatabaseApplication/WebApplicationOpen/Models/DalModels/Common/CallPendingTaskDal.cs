using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;

namespace WebApplicationOpen.Models.DalModels.Common
{
	[Table("CallPendingTasks")]
	public class CallPendingTaskDal
	{
		[Key]
		public long Id { get; set; }
		public DateTime Date { get; set; }
		public long ServiceId { get; set; }
		public DateTime? HideExDate { get; set; }
		public long CallsCounts { get; set; }
		public DateTime PendingExDate { get; set; }

		public virtual ServiceDal Service { get; set; }
	}
}
