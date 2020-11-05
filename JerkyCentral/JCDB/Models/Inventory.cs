using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public Location Location { get; set; }

        public Product Product { get; set; }

        [Column("RemainingStock")]
        public int QuantityOnHand { get; set; }
    }
}