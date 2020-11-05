using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Password")]
        public string PassWord { get; set; }

        [Column("ManagerStatus")]
        public bool ManagerStatus { get; set; }

        public Cart cart { get; set; }

        public List<Order> Order { get; set; }
    }
}