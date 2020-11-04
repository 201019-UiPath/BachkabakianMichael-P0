using JCDB;
using JCDB.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JCLib
{
    public class BrandServices
    {
        private IBrandRepo repo;

        public BrandServices(IBrandRepo repo)
        {
            this.repo = repo;
        }
        public void AddBrand(Brand brand)
        {
            repo.AddBrandAsync(brand);
        }
        public void UpdateBrand(Brand brand)
        {
            repo.UpdateBrand(brand);
        }
        public void DeleteBrand(Brand brand)
        {
            repo.DeleteBrand(brand);
        }
        public Brand GetBrandById(int id)
        {
            Brand brand = repo.GetBrandById(id);
            return brand;
        }
        public Brand GetBrandByName(string name)
        {
            Brand brand = repo.GetBrandByName(name);
            return brand;
        }
        public Task<List<Brand>> GetAllBrands()
        {
            Task<List<Brand>> brands = repo.GetAllBrandsAsync();
            return brands;
        }
    }
}