using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HangfireDashboardLang.Models;
using System.Globalization;
using System.Reflection;

namespace HangfireDashboardLang.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public string GetCulture()
        {
            var framework = Assembly
                .GetEntryAssembly()?
                .GetCustomAttribute<System.Runtime.Versioning.TargetFrameworkAttribute>()?
                .FrameworkName;
            return $"TargetFramework:{framework}, CurrentCulture:{CultureInfo.CurrentCulture.Name}, CurrentUICulture:{CultureInfo.CurrentUICulture.Name}";
        }
    }
}
