using System.Collections.Generic;
using System.Threading.Tasks;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for JerkyCentral products
    /// </summary>
    public interface IProductRepo
    {
        void AddProductAsync(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        Product GetProductById(int id);
        Product GetProductByName(string name);
        Task<List<Product>> GetAllProductsAsync();
    }
}