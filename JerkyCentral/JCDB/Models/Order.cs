using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }

        [Column("OrderDate")]
        public DateTime OrderDate { get; set; }

        public List<OrderLine> OrderLine { get; set; }
        
    }
}