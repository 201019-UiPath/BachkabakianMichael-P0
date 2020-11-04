using System.Collections.Generic;

namespace JCDB.Models
{
    public class Location
    {
        // public int InventoryId { get; set; }
        // public int OrderId { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public List<Inventory> Inventory { get; set; }
    }
}