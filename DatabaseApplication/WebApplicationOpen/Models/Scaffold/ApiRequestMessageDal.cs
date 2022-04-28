using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("ApiRequestMessage")]
	public class ApiRequestMessageDal
	{
		[Key]
		public long ApiRequestMessagesId { get; set; }
		public long ClientId { get; set; }
		public string Domain { get; set; }
		public string Notice { get; set; }
		public DateTime? PendingExpirationDate { get; set; }
		public DateTime CreationDate { get; set; }

		public virtual ClientDal Client { get; set; }
	}
}
