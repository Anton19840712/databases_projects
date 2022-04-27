using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("DelayLock")]
	public class DelayLockDal
	{
		public long DelayLockId { get; set; }
		public long ServiceId { get; set; }
		public int DelayLockTypeId { get; set; }
		public DateTime ActionDate { get; set; }
		public DateTime PendingExDate { get; set; }
		public long BackEndUserId { get; set; }
		public string Comment { get; set; }

		public virtual BackEndUserDal BackEndUser { get; set; }
		public virtual DelayLockTypeDal DelayLockType { get; set; }
		public virtual ServiceDal Service { get; set; }
	}
}
