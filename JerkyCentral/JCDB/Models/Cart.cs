using System.Collections.Generic;

namespace JCDB.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
        public List<CartLine> CartLines { get; set; }
    }
}