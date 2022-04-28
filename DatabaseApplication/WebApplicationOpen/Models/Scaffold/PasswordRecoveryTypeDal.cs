using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("PasswordRecoveryType")]
	public sealed class PasswordRecoveryTypeDal
	{
		public PasswordRecoveryTypeDal()
		{
			Clients = new HashSet<ClientDal>();
		}

		[Key]
		public int PasswordRecoveryTypeId { get; set; }
		public string PasswordRecoveryTypeName { get; set; }

		public ICollection<ClientDal> Clients { get; set; }
	}
}
