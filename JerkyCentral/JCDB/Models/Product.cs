using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class Product
    {
        
        public int ProductId { get; set; }

        
        public int CategoryId { get; set; }

        
        public int BrandId { get; set; }

        
        public string ProductName { get; set; }

        
        public double ListPrice { get; set; }

        public List <Category> Category { get; set; }

        public List <Brand> Brand { get; set; }
    }
}