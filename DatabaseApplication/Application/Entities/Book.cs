using MongoDB.Bson.Serialization.Attributes;

namespace Application.Entities
{
    public class Book
    {
        public Book(string name, int year) => (Name, Year) = (name, year);

        [BsonElement("name")]
        public string Name { get; }

        [BsonElement("year")]
        public int Year { get; }
    }
}
