using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        [Column("ProductName")]
        public string ProductName { get; set; }

        [Column("Price")]
        public double ListPrice { get; set; }

        public List <Category> Category { get; set; }

        public List <Brand> Brand { get; set; }
    }
}