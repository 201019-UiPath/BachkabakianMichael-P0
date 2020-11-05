using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class OrderLine
    {
        [Key]
        public int OrderLineId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }

        [Column("ItemQuantity")]
        public int Quantity { get; set; }
    }
}