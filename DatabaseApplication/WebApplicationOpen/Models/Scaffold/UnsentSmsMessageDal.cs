﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("UnsentSmsMessage")]
	public class UnsentSmsMessageDal
	{
		[Key]
		public long UnsentSmsMessageId { get; set; }
		public string PhoneNumber { get; set; }
		public string SmsText { get; set; }
		public bool IsSuccesfulSend { get; set; }
		public DateTime? SendingDate { get; set; }
		public int NumberOfSendingAttempts { get; set; }
		public long? ClientId { get; set; }

		public virtual ClientDal Client { get; set; }
	}
}
