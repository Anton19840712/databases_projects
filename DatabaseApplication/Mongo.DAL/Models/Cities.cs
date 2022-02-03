using MongoDB.Bson;

namespace Mongo.DAL.Models
{
    public class Cities
    {
        //public ObjectId Id { get; set; }
        public ObjectId Id { get; set; }
        public string City { get; set; }
        public long Population { get; set; }
        public int CountryId { get; set; }
    }
}