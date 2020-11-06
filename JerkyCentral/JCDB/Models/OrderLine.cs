using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class OrderLine
    {
        
        public int OrderLineId { get; set; }

        
        public int OrderId { get; set; }

        
        public int ProductId { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }

        
        public int Quantity { get; set; }
    }
}