using Microsoft.AspNetCore.Mvc;

namespace bitirme_projesi.adminpanel.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
