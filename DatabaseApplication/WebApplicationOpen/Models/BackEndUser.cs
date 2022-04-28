using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models
{
	public class BackEndUser
	{
		[Key]
		public long BackendUserId { get; set; }
		public long UserId { get; set; }
		public string FullName { get; set; }
	}
}