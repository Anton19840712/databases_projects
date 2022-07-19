using System.Collections.Generic;
using Bogus;
using Vehicle = DataGeneratorSample.Models.Transport.Vehicle;

namespace DataGeneratorSample.Repositories
{
    public static class VehicleRepository
    {
        public static IEnumerable<Vehicle> GenerateListOfVehicles(int maxNumberOfRows)
        {
            var idsVehicle = 1;
            var vehicleGenerator = new Faker<Vehicle>()
                .RuleFor(o => o.VehicleId, f => idsVehicle++)
                .RuleFor(o => o.Vin, f => f.Vehicle.Vin())
                .RuleFor(o => o.Manufacturer, f => f.Vehicle.Manufacturer())
                .RuleFor(o => o.Model, f => f.Vehicle.Model())
                .RuleFor(o => o.Type, f => f.Vehicle.Type())
                .RuleFor(o => o.Fuel, f => f.Vehicle.Fuel())
                .RuleFor(o => o.Manufacturer, f => f.Vehicle.Manufacturer())
                .RuleFor(o => o.PersonId, f => f.Random.Number(1, maxNumberOfRows));

            return vehicleGenerator.Generate(maxNumberOfRows);
        }
    }
}