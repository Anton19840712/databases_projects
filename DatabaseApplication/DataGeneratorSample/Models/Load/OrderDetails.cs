using System;

namespace DataGeneratorSample.Models.Load
{
	public class OrderDetails
	{
		public long OrderId{ get; set; }
		public DateTime OrderedDateTime { get; set; }
		public int ItemNumber { get; set; }
		public double ItemPrice { get; set; }
	}
}
