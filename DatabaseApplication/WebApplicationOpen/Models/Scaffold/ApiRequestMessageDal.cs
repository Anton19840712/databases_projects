using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class ApiRequestMessageDal
	{
		public long ApiRequestMessagesId { get; set; }
		public long ClientId { get; set; }
		public string Domain { get; set; }
		public string Notice { get; set; }
		public DateTime? PendingExpirationDate { get; set; }
		public DateTime CreationDate { get; set; }

		public virtual ClientDal Client { get; set; }
	}
}
