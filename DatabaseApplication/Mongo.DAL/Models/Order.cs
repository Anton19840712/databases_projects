using System.Collections.Generic;

namespace Mongo.DAL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Item> Items { get; set; }
        public double TotalPrice { get; set; }
    }
}