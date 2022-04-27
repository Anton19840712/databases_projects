using GraphQlСhocolateDataPackage.DataBaseContexts;
using GraphQlСhocolateDataPackage.Models;
using HotChocolate;

namespace GraphQlСhocolateDataPackage.InstanceCommands.PersonCommands
{
	public class PersonCommandsGeneralCrudApi
	{
		public Person Save([Service] PersonContext context, Person model)
		{
			context.Persons.Add(model);

			context.SaveChanges();

			return model;
		}
	}
}