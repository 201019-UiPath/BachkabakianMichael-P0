using System.Collections.Generic;
using System.Threading.Tasks;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for product brands
    /// </summary>
    public interface IBrandRepo
    {
        void AddBrandAsync(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(Brand brand);
        Brand GetBrandById(int id);
        Brand GetBrandByName(string name);
        Task<List<Brand>> GetAllBrandsAsync();


    }
}