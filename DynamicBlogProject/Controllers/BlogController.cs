using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicBlogProject.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            var result = blogManager.GetAllBlogsWithCategory();
            return View(result);
        }

        public IActionResult BlogReadAll(int id) 
        {
            ViewBag.i = id;
            var result = blogManager.GetBlogsById(id);
            return View(result);
        }

    }
}
