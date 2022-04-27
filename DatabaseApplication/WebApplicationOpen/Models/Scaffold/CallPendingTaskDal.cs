using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class CallPendingTaskDal
	{
		public long Id { get; set; }
		public DateTime Date { get; set; }
		public long ServiceId { get; set; }
		public DateTime? HideExDate { get; set; }
		public long CallsCounts { get; set; }
		public DateTime PendingExDate { get; set; }

		public virtual Service Service { get; set; }
	}
}
