namespace Mongo.DAL.Models
{
    public class Person
    {
        public int Id { get; set; }
        public Friend[] Friends { get; set; }
    }
}