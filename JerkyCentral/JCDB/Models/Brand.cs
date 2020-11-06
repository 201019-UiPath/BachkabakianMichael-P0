using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCDB.Models
{
    public class Brand
    {
        
        public int BrandId { get; set; }

        
        public string BrandName { get; set; }
    }
}