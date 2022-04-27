using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class PasswordRecoveryType
	{
		public PasswordRecoveryType()
		{
			Clients = new HashSet<ClientDal>();
		}

		public int PasswordRecoveryTypeId { get; set; }
		public string PasswordRecoveryTypeName { get; set; }

		public virtual ICollection<ClientDal> Clients { get; set; }
	}
}
