using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.DAL.Models
{
    public class Salaries
    {
        [BsonElement("_id")]
        public int Id { get; set; }
        [BsonElement("employee")]
        public string Employee { get; set; }
        [BsonElement("dept")]
        public string Dept { get; set; }
        [BsonElement("salary")]
        public double SalaryMonth { get; set; }

        [BsonElement("fiscal_year")]
        public int FiscalYear { get; set; }
    }
}