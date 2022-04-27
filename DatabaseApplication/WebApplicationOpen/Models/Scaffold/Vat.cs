using System;
using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class Vat
	{
		public Vat()
		{
			Acts = new HashSet<ActDal>();
			ServiceHistories = new HashSet<ServiceHistory>();
		}

		public long VatId { get; set; }
		public int Value { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime OfficialCreationDate { get; set; }

		public ICollection<ActDal> Acts { get; set; }
		public ICollection<ServiceHistory> ServiceHistories { get; set; }
	}
}
