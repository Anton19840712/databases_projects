using Application.Entities.Base;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Application.Entities
{
    public class Author : BaseEntity
    {
        public Author(string name, IEnumerable<Book> books) => (Name, Books) = (name, books);

        [BsonElement("name")]
        public string Name { get; }

        [BsonElement("books")]
        //navigation property pattern...:
        public IEnumerable<Book> Books { get; }
    }
}
