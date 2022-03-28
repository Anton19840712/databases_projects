using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.DAL.Models
{
    public class Budget
    {
        //[BsonElement("_id")] public List<object> Id
        //{
        //    get
        //    {
        //        Id.Add(FiscalYear);
        //        Id.Add(Dept);
        //        return Id;
        //    }
        //}

        [BsonElement("fiscal_year")]
        public int FiscalYear { get; set; }

        [BsonElement("dept")]
        public string Dept { get; set; }

        [BsonElement("salary")]
        public double SalaryMonth { get; set; }

    }
}