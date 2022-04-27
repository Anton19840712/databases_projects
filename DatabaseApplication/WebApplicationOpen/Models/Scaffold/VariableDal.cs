using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("Variable")]
	public class VariableDal
	{
		public string Name { get; set; }
		public string Value { get; set; }
	}
}
