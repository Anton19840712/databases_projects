using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class DelayLock
	{
		public long DelayLockId { get; set; }
		public long ServiceId { get; set; }
		public int DelayLockTypeId { get; set; }
		public DateTime ActionDate { get; set; }
		public DateTime PendingExDate { get; set; }
		public long BackEndUserId { get; set; }
		public string Comment { get; set; }

		public virtual BackEndUserDal BackEndUser { get; set; }
		public virtual DelayLockType DelayLockType { get; set; }
		public virtual Service Service { get; set; }
	}
}
