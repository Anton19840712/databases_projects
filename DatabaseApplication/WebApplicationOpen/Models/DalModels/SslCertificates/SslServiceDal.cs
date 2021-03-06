using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;

namespace WebApplicationOpen.Models.DalModels.SslCertificates
{
	[Table("SslServices")]
	public class SslServiceDal
	{
		[Key]
		public long SslServiceId { get; set; }
		public long ServiceId { get; set; }
		public int SslVerificationTypeId { get; set; }
		public string Email { get; set; }
		public long? ApiOrderId { get; set; }
		public int? SslOrderStatusId { get; set; }
		public DateTime? PlacementDate { get; set; }
		public bool IsAct { get; set; }
		public long? SslThatWasRenewedOldOrderId { get; set; }
		public string Pk { get; set; }
		public string Csr { get; set; }

		public virtual ServiceDal Service { get; set; }
		public virtual SslVerificationTypeDal SslVerificationType { get; set; }
	}
}
