﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HrPortal.Controllers
{
    public class JobsController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }
    }
}