using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("DomainDescendant")]
	public class DomainDescendantDal
	{
		[Key]
		public long DomainDescendantId { get; set; }
		public string Name { get; set; }
		public long DomainId { get; set; }
		public long RegistrantId { get; set; }
		public DateTime CreateDate { get; set; }
		public long? DomainDescendantContractId { get; set; }

		public virtual DomainDal Domain { get; set; }
		public virtual DomainDescendantContractDal DomainDescendantContract { get; set; }
		public virtual RegistrantDal Registrant { get; set; }
	}
}
