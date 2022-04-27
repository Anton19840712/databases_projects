using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("PasswordRecoveryType")]
	public sealed class PasswordRecoveryTypeDal
	{
		public PasswordRecoveryTypeDal()
		{
			Clients = new HashSet<ClientDal>();
		}

		public int PasswordRecoveryTypeId { get; set; }
		public string PasswordRecoveryTypeName { get; set; }

		public ICollection<ClientDal> Clients { get; set; }
	}
}
