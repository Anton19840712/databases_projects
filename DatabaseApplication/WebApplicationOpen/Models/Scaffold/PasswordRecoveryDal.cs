using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("PasswordRecovery")]
	public class PasswordRecoveryDal
	{
		[Key]
		public long PasswordRecoveryId { get; set; }
		public long UserId { get; set; }
		public string RecoveryKey { get; set; }
		public DateTime Date { get; set; }

		public virtual UserDal User { get; set; }
	}
}
