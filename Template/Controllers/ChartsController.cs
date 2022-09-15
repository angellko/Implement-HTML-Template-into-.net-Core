using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult ChartJs()
        {
            return View();
        }
        public IActionResult ApexChart()
        {
            return View();
        }
        public IActionResult EChart()
        {
            return View();
        }
    }
}
