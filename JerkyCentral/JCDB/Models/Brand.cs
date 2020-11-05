using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }

        [Column("BrandName")]
        public string BrandName { get; set; }
    }
}