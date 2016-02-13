using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace DemoSite.Controllers
{
    public class StudiegroepController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    public class NieuwsbriefController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
