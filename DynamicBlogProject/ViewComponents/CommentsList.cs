using DynamicBlogProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicBlogProject.ViewComponents
{
    public class CommentsList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var CommentsValues = new List<UserComment>{
                new UserComment
                {
                    Id = 1, UserName = "betül"
                },
                new UserComment
                {
                    Id = 2,
                    UserName = "murat"
                },
                new UserComment
                {
                    Id = 3,
                    UserName = "hamido"
                }
            };
            return View(CommentsValues);
        }
    }
}
