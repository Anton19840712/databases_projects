using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.DAL.DTOs
{
    [BsonIgnoreExtraElements]
    public class CountriesDto
    {
        public ObjectId Id { get; set; }
        public string Country { get; set; }
        public int CountryNumber { get; set; }
    }
}