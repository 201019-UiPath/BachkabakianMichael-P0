using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class CartLine
    {
        [Key]
        public int CartLineId { get; set; }

        [ForeignKey("Cart")]
        public int CartId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public Cart Cart { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }
    }
}