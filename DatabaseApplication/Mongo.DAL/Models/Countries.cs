using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.DAL.Models
{
    public class Countries
    {
        [BsonId] // Оно мало что дает, может сгенерировать просто нули для свойства Guid
        public ObjectId Id { get; set; }
        public string Country { get; set; }
        public long CountryArea { get; set; }
        public int CountryNumber { get; set; }
    }
}