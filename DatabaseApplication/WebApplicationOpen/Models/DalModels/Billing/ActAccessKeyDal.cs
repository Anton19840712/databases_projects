using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Clients;

namespace WebApplicationOpen.Models.DalModels.Billing
{
	[Table("ActAccessKey")]
	public class ActAccessKeyDal
	{
		[Key]
		public long ActAccessKeyId { get; set; }
		public string AccessKey { get; set; }
		public DateTime Date { get; set; }
		public long ClientId { get; set; }

		public virtual ClientDal Client { get; set; }
	}
}
