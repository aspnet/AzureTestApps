using System.Diagnostics;
using System.Reflection;
using App2._0._0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace App2._0._0.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var assemblyInfo = $@"object assembly: {typeof(object).GetTypeInfo().Assembly.Location}
Controller assembly: {typeof(Controller).GetTypeInfo().Assembly.Location}
IServiceCollection assembly: {typeof(IServiceCollection).GetTypeInfo().Assembly.Location}";

            ViewData["Message"] = assemblyInfo;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
