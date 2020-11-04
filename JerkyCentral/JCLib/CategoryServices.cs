using JCDB;
using JCDB.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JCLib
{
    public class CategoryServices
    {
        private ICategoryRepo repo;

        public CategoryServices(ICategoryRepo repo)
        {
            this.repo = repo;
        }
        public void AddCategory(Category category)
        {
            repo.AddCategoryAsync(category);
        }
        public void UpdateCategory(Category category)
        {
            repo.UpdateCategory(category);
        }
        public void DeleteCategory(Category category)
        {
            repo.DeleteCategory(category);
        }
        public Category GetCategoryById(int id)
        {
            Category category = repo.GetCategoryById(id);
            return category;
        }
        public Category GetCategoryByName(string name)
        {
            Category category = repo.GetCategoryByName(name);
            return category;
        }
        public Task<List<Category>> GetAllCategories()
        {
            Task<List<Category>> categories = repo.GetAllCategoriesAsync();
            return categories;
        }
    }
}