﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("DsRecord")]
	public class DsRecordDal
	{
		[Key]
		public long DsRecordId { get; set; }
		public long DomainId { get; set; }
		public string Tag { get; set; }
		public string Alg { get; set; }
		public string Type { get; set; }
		public string Digest { get; set; }

		public virtual DomainDal Domain { get; set; }
	}
}
