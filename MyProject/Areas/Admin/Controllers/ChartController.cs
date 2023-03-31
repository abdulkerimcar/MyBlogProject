using Microsoft.AspNetCore.Mvc;
using MyProject.Areas.Admin.Models;

namespace MyProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ChartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult CategoryChart()
		{
			List<CategoryClass> list = new List<CategoryClass>();
			list.Add(new CategoryClass { categorycount = 10, categoryname = "Teknoloji" });
			list.Add(new CategoryClass { categorycount = 12, categoryname = "Yazıılım" });
			list.Add(new CategoryClass { categorycount = 8, categoryname = "Spor" });
			return Json(new { JSONlist = list });
		}
	}
}
