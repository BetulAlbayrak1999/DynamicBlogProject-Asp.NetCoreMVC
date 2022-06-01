using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DynamicBlogProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Writer writer)
        {
            Context c = new Context();
            var data = c.Writers.FirstOrDefault(x => x.Email == writer.Email && x.Password == writer.Password);
            if (data != null )
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, writer.Email)
                };

                var userIdenty = new ClaimsIdentity(claims, "b");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdenty);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }
        }
    }
}
