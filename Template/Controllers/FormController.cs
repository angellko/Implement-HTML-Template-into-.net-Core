using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Controllers
{
    public class FormController : Controller
    {
        public IActionResult FormElement()
        {
            return View();
        }
        public IActionResult FormLayout()
        {
            return View();
        }
        public IActionResult FormEditor()
        {
            return View();
        }
        public IActionResult FormValidation()
        {
            return View();
        }
    }
}
