using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Controllers
{
    public class IconController : Controller
    {
        public IActionResult BootstrapIcon()
        {
            return View();
        }
        public IActionResult RemixIcon()
        {
            return View();
        }
        public IActionResult BoxIcon()
        {
            return View();
        }
    }
}
