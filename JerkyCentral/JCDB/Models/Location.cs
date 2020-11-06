using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class Location
    {
        
        public int LocationId { get; set; }

        
        public string LocationName { get; set; }

        
        public string Address { get; set; }

        public List<Inventory> Inventory { get; set; }
    }
}