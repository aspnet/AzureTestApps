using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var sb = new StringBuilder();
            sb.AppendLine(typeof(object).GetTypeInfo().Assembly.Location);
            sb.AppendLine(typeof(Controller).GetTypeInfo().Assembly.Location);
            sb.AppendLine(typeof(IServiceCollection).GetTypeInfo().Assembly.Location);
            ViewData["Message"] = sb.ToString();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
