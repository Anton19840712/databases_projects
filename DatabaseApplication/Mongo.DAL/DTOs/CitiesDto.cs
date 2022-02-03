using MongoDB.Bson;

namespace Mongo.DAL.DTOs
{
    public class CitiesDto
    {
        public ObjectId Id { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
    }
}