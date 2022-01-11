using System.Threading.Tasks;
using DataGeneratorSample.Contexts;
using DataGeneratorSample.Repositories;

namespace DataGeneratorSample
{
    class Program
    {
        private static async Task Main()
        {
            var context = new EntitiesDbContext();

            var maxNumberOfRows = 1000;

            var vehicles = VehicleRepository.GenerateListOfVehicles(maxNumberOfRows);

            var persons = PersonRepository.GeneratePersonModel(maxNumberOfRows);

            var orders = OrderRepository.GenerateOrderList(maxNumberOfRows);

            var categories = CategoryRepository.GenerateCategoryList(maxNumberOfRows);

            var products = ProductRepository.GenerateProductList(maxNumberOfRows);

            var orderProducts = OrderProductRepository.GenerateOrderProductList(maxNumberOfRows);

            var personAddresses = PersonAddressRepository.GenerateListOfAddresses(maxNumberOfRows);

            context.Vehicles.AddRange(vehicles);

            context.Orders.AddRange(orders);

            context.Categories.AddRange(categories);

            context.Products.AddRange(products);

            context.OrderProducts.AddRange(orderProducts);

            context.Persons.AddRange(persons);

            context.PersonAddresses.AddRange(personAddresses);

            await context.SaveChangesAsync();

            // var addresses = repository.GenerateListOfPersons();
            // Console.WriteLine(JsonConvert.SerializeObject(addresses, Formatting.Indented));
        }
    }
}
