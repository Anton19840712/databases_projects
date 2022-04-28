using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("PersonalDiscount")]
	public class PersonalDiscountDal
	{
		[Key]
		public long PersonalDiscountId { get; set; }
		public long ClientId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime? ExpirationDate { get; set; }
		public int DomainProlongationDiscount { get; set; }
		public int InitialDomainDiscount { get; set; }

		public virtual ClientDal Client { get; set; }
	}
}
