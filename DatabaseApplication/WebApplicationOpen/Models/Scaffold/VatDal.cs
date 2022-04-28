using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
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
