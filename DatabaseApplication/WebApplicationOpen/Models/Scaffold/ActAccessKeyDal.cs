using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class ActAccessKeyDal
	{
		public long ActAccessKeyId { get; set; }
		public string AccessKey { get; set; }
		public DateTime Date { get; set; }
		public long ClientId { get; set; }

		public virtual ClientDal Client { get; set; }
	}
}
