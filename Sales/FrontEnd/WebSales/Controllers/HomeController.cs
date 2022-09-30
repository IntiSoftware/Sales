using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebSales.Data;
using WebSales.Models;

namespace WebSales.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			//First Test Devops
			//First test Docker
			//Second test Docker
			//Third test Docker
			return View(ProductContext.Products);
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
	}
}