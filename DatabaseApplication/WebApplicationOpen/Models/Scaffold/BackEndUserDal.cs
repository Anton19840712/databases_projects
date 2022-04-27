using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class BackEndUserDal
	{
		public BackEndUserDal()
		{
			Calls = new HashSet<CallDal>();
			DelayLocks = new HashSet<DelayLock>();
		}

		public long BackEndUserId { get; set; }
		public string FullName { get; set; }
		public long UserId { get; set; }

		public User User { get; set; }
		public ICollection<CallDal> Calls { get; set; }
		public ICollection<DelayLock> DelayLocks { get; set; }
	}
}
