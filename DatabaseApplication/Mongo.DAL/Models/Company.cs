using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.DAL.Models
{
    public class Company
    {
        [BsonId]
        [BsonElement("_id")]
        public int Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }
    }
}