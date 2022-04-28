using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Common;
using WebApplicationOpen.Models.DalModels.VirtualHosting;

namespace WebApplicationOpen.Models.DalModels.Users
{
	[Table("BackEndUsers")]
	public sealed class BackEndUserDal
	{
		public BackEndUserDal()
		{
			Calls = new HashSet<CallDal>();
			DelayLocks = new HashSet<DelayLockDal>();
		}

		[Key]
		public long BackEndUserId { get; set; }
		public string FullName { get; set; }
		public long UserId { get; set; }

		public UserDal User { get; set; }
		public ICollection<CallDal> Calls { get; set; }
		public ICollection<DelayLockDal> DelayLocks { get; set; }
	}
}
