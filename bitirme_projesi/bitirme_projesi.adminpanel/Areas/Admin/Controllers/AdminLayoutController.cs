using Microsoft.AspNetCore.Mvc;

namespace bitirme_projesi.adminpanel.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AdminLayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
