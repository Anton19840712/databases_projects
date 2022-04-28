using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Clients
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
