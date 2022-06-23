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

        public void AddT(Category t)
        {
            _category.Add(t);
        }


        public void DeleteT(Category t)
        {
            _category.Delete(t);
        }

        public List<Category> GetAllTs()
        {
            return _category.GetAll();
        }

        public Category GetTById(int id)
        {
            return _category.GetById(id);
        }

        public void UpdateT(Category t)
        {
            _category.Update(t);
        }
    }
}
