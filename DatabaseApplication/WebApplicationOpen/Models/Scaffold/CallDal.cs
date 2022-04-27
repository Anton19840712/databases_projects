using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class CallDal
	{
		public long Id { get; set; }
		public string Comment { get; set; }
		public string Phone { get; set; }
		public long CallStatusId { get; set; }
		public long ServiceHistoryId { get; set; }
		public DateTime Date { get; set; }
		public long BackEndUserId { get; set; }
		public long ClientId { get; set; }

		public virtual BackEndUserDal BackEndUser { get; set; }
		public virtual CallStatusDal CallStatus { get; set; }
		public virtual ClientDal Client { get; set; }
		public virtual ServiceHistory ServiceHistory { get; set; }
	}
}
