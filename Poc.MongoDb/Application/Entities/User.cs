using Application.Entities.Base;
using MongoDB.Bson.Serialization.Attributes;

namespace Application.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string nin) => (Name, Nin) = (name, nin);

        [BsonElement("name")]
        public string Name { get; }

        [BsonElement("national_insurance_number")]
        public string Nin { get; }
    }
}
