using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Application.Entities.Base
{
    public abstract class BaseEntity
    {
        //Interesting attributes...:

        [BsonElement("_id")]
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        public virtual string Id { get; private set; }

        public void SetId(string id) => Id = id;
    }
}
