using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Column("LocationName")]
        public string LocationName { get; set; }

        [Column("Address")]
        public string Address { get; set; }

        public List<Inventory> Inventory { get; set; }
    }
}