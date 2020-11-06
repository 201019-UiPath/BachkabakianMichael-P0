using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class Inventory
    {
        
        public int InventoryId { get; set; }

        
        public int LocationId { get; set; }

        
        public int ProductId { get; set; }

        public Location Location { get; set; }

        public Product Product { get; set; }

        
        public int QuantityOnHand { get; set; }
    }
}