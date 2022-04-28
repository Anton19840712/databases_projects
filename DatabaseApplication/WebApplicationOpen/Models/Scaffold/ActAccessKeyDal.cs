using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
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
