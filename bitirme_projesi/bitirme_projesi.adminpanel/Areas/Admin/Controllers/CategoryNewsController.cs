using bitirme_projesi.adminpanel.Dtos.CategoryDtos;
using bitirme_projesi.adminpanel.Dtos.CategoryNewsDtos;
using bitirme_projesi.adminpanel.Dtos.NewsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using System.Text;

namespace bitirme_projesi.adminpanel.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[Area]/[Controller]/[Action]/{id?}")]
	public class CategoryNewsController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public CategoryNewsController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7272/api/CategoryNews");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultCategoryNewsDto>>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpGet]
		public IActionResult CreateCategoryNews()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateCategoryNews(CreateCategoryNewsDto createCategoryNewsDto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createCategoryNewsDto);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7272/api/CategoryNews", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index", new { area = "Admin" });
			}
			return View();
		}
		public async Task<IActionResult> DeleteCategoryNews(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync("https://localhost:7272/api/CategoryNews?id=" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> UpdateCategoryNews(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7272/api/CategoryNews/" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateCategoryNewsDto>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> UpdateCategoryNews(UpdateCategoryNewsDto updateCategoryNewsDto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateCategoryNewsDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("https://localhost:7272/api/CategoryNews", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
