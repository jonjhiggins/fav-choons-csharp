using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fav_choons_csharp.Controllers
{
    public class UserController : Controller
    {
        // GET: /user/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /user/profile/{id}
        public IActionResult Profile(int id)
        {
            ViewData["Id"] = id.ToString();

            return View();
        }
    }
}

