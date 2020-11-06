using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class Category
    {
        
        public int CategoryId { get; set; }

        
        public string CategoryName { get; set; }

        
        public string ExpDate { get; set; }
    }
}