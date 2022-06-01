﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);

        void DeleteBlog(Blog blog);

        void UpdateBlog(Blog blog);

        Blog GetBlogById(int id);

        List<Blog> GetBlogsById(int id);

        List<Blog> GetAllBlogs();

        List<Blog> GetAllBlogsWithCategory();

        List<Blog> GetAllBlogsByWriter(int id);


    }
}
