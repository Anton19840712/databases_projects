using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Common
{
	[Table("Variables")]
	public class VariableDal
	{
		public string Name { get; set; }
		public string Value { get; set; }
	}
}
