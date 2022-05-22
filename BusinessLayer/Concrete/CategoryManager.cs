using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategory _category;
        public CategoryManager(ICategory category)
        {
            _category = category;
        }

        public void AddCategory(Category category)
        {
            _category.Add(category);
        }

        public void DeleteCategory(Category category)
        {
            _category.Delete(category);
        }

        public List<Category> GetAllCategories()
        {
            return _category.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _category.GetById(id);
        }

        public void UpdateCategory(Category category)
        {
            _category.Update(category);
        }
    }
}
