using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Billing;
using WebApplicationOpen.Models.DalModels.Clients;
using WebApplicationOpen.Models.DalModels.Users;

namespace WebApplicationOpen.Models.DalModels.Common
{
	[Table("Calls")]
	public class CallDal
	{
		[Key]
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
		public virtual ServiceHistoryDal ServiceHistory { get; set; }
	}
}
