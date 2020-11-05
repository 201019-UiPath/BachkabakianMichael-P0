using JCDB;
using JCDB.Models;
using System.Collections.Generic;

namespace JCLib
{
    public class ProductServices
    {
        private IProductRepo repo;

        public ProductServices(IProductRepo repo)
        {
            this.repo = repo;
        }
        public void AddProduct(Product product)
        {
            repo.AddProduct(product);
        }
        public void UpdateProduct(Product product)
        {
            repo.UpdateProduct(product);
        }
        public void DeleteProduct(Product product)
        {
            repo.DeleteProduct(product);
        }
        public Product GetProductById(int id)
        {
            Product product = repo.GetProductById(id);
            return product;
        }
        public Product GetProductByName(string name)
        {
            Product product = repo.GetProductByName(name);
            return product;
        }
        public List<Product> GetAllProducts()
        {
            List<Product> products = repo.GetAllProducts();
            return products;
        }
    }
}