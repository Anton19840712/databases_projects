using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Clients;

namespace WebApplicationOpen.Models.DalModels.Domains
{
	[Table("ApiRequestMessages")]
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
