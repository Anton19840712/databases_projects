using Mongo.DAL.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.DAL.UnwindModel
{
    public class PersonalityUnwind
    {
        [BsonElement("_id")]
        public long Id { get; set; }

        //[BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Surname")]
        public string Surname { get; set; }

        [BsonIgnoreIfNull] //To avoid adding elements if null to the deserialized document
        public Company Company { get; set; }

        [BsonElement("Age")]
        [BsonIgnoreIfDefault] //To avoid adding elements if null to the deserialized document but for the VALUE TYPES...:
        public int Age { get; set; }
        [BsonElement("Friends")]
        public Friend Friends { get; set; }
        //public Friend Friends { get; set; }
    }
}