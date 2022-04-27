using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class PowerDnsregistryQueue
	{
		public long Id { get; set; }
		public string DomainName { get; set; }
		public int XrrpCommand { get; set; }
		public DateTime TimePushInQueue { get; set; }
		public string BodyRegistrant { get; set; }
		public string XrrpResultCode { get; set; }
		public string XrrpResultMessage { get; set; }
	}
}
