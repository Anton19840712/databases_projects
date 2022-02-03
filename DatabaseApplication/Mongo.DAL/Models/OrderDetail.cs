using System.Collections.Generic;

namespace Mongo.DAL.Models
{
    public class OrderDetail : Order
    {
        public List<ItemDetail> Item { get; set; }
    }
}