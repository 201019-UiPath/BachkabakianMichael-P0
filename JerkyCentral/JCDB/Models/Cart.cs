using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public User user { get; set; }

        public List<CartLine> CartLines { get; set; }
    }
}