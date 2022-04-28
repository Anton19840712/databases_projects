using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Billing
{
	[Table("Vat")]
	public sealed class VatDal
	{
		public VatDal()
		{
			Acts = new HashSet<ActDal>();
			ServiceHistories = new HashSet<ServiceHistoryDal>();
		}

		[Key]
		public long VatId { get; set; }
		public int Value { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime OfficialCreationDate { get; set; }

		public ICollection<ActDal> Acts { get; set; }
		public ICollection<ServiceHistoryDal> ServiceHistories { get; set; }
	}
}
