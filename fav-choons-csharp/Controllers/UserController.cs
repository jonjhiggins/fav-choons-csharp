﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using fav_choons_csharp.Data.Models;
using fav_choons_csharp.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace fav_choons_csharp.Controllers
{
    public class UserController : Controller
    {
        private IAppUserService _service;

        public UserController(IAppUserService service)
        {
            _service = service;
        }

        // GET: /user/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /user/profile/{id}
        public IActionResult Profile(Guid id)
        {
            var result = _service.GetById(id);
            if (result == null)
            {
                return NotFound();
            }
            return View(result);
        }
    }
}

