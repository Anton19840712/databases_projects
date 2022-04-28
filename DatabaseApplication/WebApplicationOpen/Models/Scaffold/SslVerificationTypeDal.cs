﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("SslVerificationType")]
	public sealed class SslVerificationTypeDal
	{
		public SslVerificationTypeDal()
		{
			SslServices = new HashSet<SslServiceDal>();
			SslVerifications = new HashSet<SslVerificationDal>();
		}

		[Key]
		public int SslVerificationTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<SslServiceDal> SslServices { get; set; }
		public ICollection<SslVerificationDal> SslVerifications { get; set; }
	}
}
