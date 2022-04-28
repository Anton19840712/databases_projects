using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Domains
{
	[Table("DomainDescendants")]
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
