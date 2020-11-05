using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column("CategoryName")]
        public string CategoryName { get; set; }

        [Column("TimeToExpire")]
        public string ExpDate { get; set; }
    }
}