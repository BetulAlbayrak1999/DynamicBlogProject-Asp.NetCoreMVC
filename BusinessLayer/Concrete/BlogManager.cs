using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager: IBlogService
    {
        private readonly IBlog _blog;

        public BlogManager(IBlog blog)
        {
            _blog = blog;
        }

        public void AddT(Blog t)
        {
            _blog.Add(t);
        }

        public void DeleteT(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllBlogs()
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllBlogsByWriter(int id)
        {
            return _blog.GetAll(x=> x.WriterId == id);
        }

        public List<Blog> GetAllBlogsWithCategory()
        {
            return _blog.GetListWithCategory();
        }

        public List<Blog> GetAllTs()
        {
            return _blog.GetAll();
        }

        public Blog GetBlogById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogsById(int id)
        {
            return _blog.GetAll(x => x.Id == id);
        }


        public List<Blog> GetLastThreeBlogs()
        {
            return _blog.GetAll().Take(3).ToList();
        }

        public Blog GetTById(int id)
        {
            throw new NotImplementedException();
        }
        public void UpdateT(Blog t)
        {
            throw new NotImplementedException();
        }
    }
}
