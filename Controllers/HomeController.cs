using CodeSecurityTests.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeSecurityTests.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private const string ConnectionString = "Data Source=10.254.98.101; Initial Catalog=securityDB; User Id=sa; Password=hugytr45";
        private const string mongo_uri = "mongodb+srv://testuser:hub24aoeu@gg-is-awesome-gg273.mongodb.net/test?retryWrites=true&w=majority";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var user = new User
            {
                Login = "bertuzziTeste",
                Password = "YUEIYAjhas1"
            };

            return View();
        }

        public IActionResult Privacy()
        {
            return View();

            //AWS Key comentada
            //var = aws_lib.connect("AKIAF6BAFJKR45SAWSZ5", "hjshnk5ex5u34565AWS654/JKGjhz545d89sjkja")
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}