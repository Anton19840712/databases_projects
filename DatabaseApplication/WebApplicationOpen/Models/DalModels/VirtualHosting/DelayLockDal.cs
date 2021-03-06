using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;
using WebApplicationOpen.Models.DalModels.Users;

namespace WebApplicationOpen.Models.DalModels.VirtualHosting
{
	[Table("DelayLocks")]
	public class DelayLockDal
	{
		[Key]
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
