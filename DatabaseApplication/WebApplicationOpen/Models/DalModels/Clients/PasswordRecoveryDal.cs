using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Users;

namespace WebApplicationOpen.Models.DalModels.Clients
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
