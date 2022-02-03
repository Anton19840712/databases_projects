namespace Mongo.DAL.Models
{
    public class Member
    {
        public int Id { get; set; }
        public int[] Friends { get; set; }
    }
}