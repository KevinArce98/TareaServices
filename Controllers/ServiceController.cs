using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarea1.Models;

namespace Tarea1.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Programming()
        {
            return View();
        }
        public IActionResult Quality()
        {
            return View();
        }
        public IActionResult Software()
        {
            return View();
        }
    }
}
