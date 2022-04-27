using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class PersonalDiscount
	{
		public long PersonalDiscountId { get; set; }
		public long ClientId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime? ExpirationDate { get; set; }
		public int DomainProlongationDiscount { get; set; }
		public int InitialDomainDiscount { get; set; }

		public virtual ClientDal Client { get; set; }
	}
}
