using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("DomainDescendantContract")]
	public sealed class DomainDescendantContractDal
	{
		public DomainDescendantContractDal()
		{
			DomainDescendants = new HashSet<DomainDescendantDal>();
		}
		[Key]
		public long DescendantContractId { get; set; }
		public string ApplicantPosition { get; set; }
		public string ApplicantName { get; set; }
		public string ContractNumber { get; set; }
		public DateTime? OrderDate { get; set; }
		public DateTime? ValidityDate { get; set; }

		public ICollection<DomainDescendantDal> DomainDescendants { get; set; }
	}
}
