using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class PasswordRecovery
	{
		public long PasswordRecoveryId { get; set; }
		public long UserId { get; set; }
		public string RecoveryKey { get; set; }
		public DateTime Date { get; set; }

		public virtual User User { get; set; }
	}
}
