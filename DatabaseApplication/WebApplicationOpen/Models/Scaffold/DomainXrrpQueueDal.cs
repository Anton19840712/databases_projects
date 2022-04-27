using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("DomainXrrpQueue")]
	public class DomainXrrpQueueDal
	{
		public long DomainQueueId { get; set; }
		public long DomainId { get; set; }
		public int XrrpCommand { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime? FailUpdateDate { get; set; }

		public virtual DomainDal Domain { get; set; }
	}
}
