using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicBlogProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EFCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialAddComment() 
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult PartialAddComment(Comment comment)
        {
            comment.CreationDate = DateTime.Parse(DateTime.Now.ToString());
            comment.Status = true;
            comment.BlogId = 2;
            commentManager.AddComment(comment);

            return RedirectToRoute(new { controller = "Blog", action = "BlogReadAll",  Id = comment.BlogId });
        }

        public PartialViewResult ListCommentByBlog(int id)
        {
            var result = commentManager.GetAllComments(id);
            return PartialView(result);
        }
    }
}
