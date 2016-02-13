using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.PlatformAbstractions;

namespace DemoSite.Controllers
{
    public class OverdotnedController : Controller
    {
        private readonly IRuntimeEnvironment _runtimeEnvironment;

        public OverdotnedController(IRuntimeEnvironment runtimeEnvironment)
        {
            _runtimeEnvironment = runtimeEnvironment;
        }

        public IActionResult Index()
        {
            ViewData["OperatingSystem"] = _runtimeEnvironment.OperatingSystem;
            ViewData["OperatingSystemVersion"] = _runtimeEnvironment.OperatingSystemVersion;
            ViewData["RuntimeType"] = _runtimeEnvironment.RuntimeType;
            ViewData["RuntimeArchitecture"] = _runtimeEnvironment.RuntimeArchitecture;
            ViewData["RuntimeVersion"] = _runtimeEnvironment.RuntimeVersion;

            return View();
        }
    }
}
