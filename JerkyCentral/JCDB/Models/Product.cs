using System.Collections.Generic;

namespace JCDB.Models
{
    public class Product
    {
        // public int CategoryId { get; set; }
        // public int BrandId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string ProductName { get; set; }
        public double ListPrice { get; set; }
        public List <Category> Category { get; set; }
        public List <Brand> Brand { get; set; }
    }
}