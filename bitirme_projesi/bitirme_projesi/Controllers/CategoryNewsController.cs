using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DtoLayer.CategoryDtos;
using bitirme_projesi.DtoLayer.CategoryNewsDtos;
using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bitirme_projesi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryNewsController : ControllerBase
	{
		private readonly ICategoryNewsService _categoryNewsService;

		public CategoryNewsController(ICategoryNewsService categoryNewsService)
		{
			_categoryNewsService = categoryNewsService;
		}

		[HttpGet]
		public ActionResult CategoryNewsList()
		{
			var values = _categoryNewsService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateCategoryNews(CreateCategoryNewsDto createCategoryNewsDto)
		{
			CategoryNews categoryNews = new CategoryNews()
			{
				CategoryNewsTitle = createCategoryNewsDto.CategoryNewsTitle,
				CategoryNewsDescription = createCategoryNewsDto.CategoryNewsDescription,
				CategoryNewsImageUrl = createCategoryNewsDto.CategoryNewsImageUrl,
				CategoryNewsAuthor = createCategoryNewsDto.CategoryNewsAuthor,
				CategoryNewsTime = createCategoryNewsDto.CategoryNewsTime,
			};
			_categoryNewsService.TInsert(categoryNews);
			return Ok("Başarıyla eklendi.");
		}
		[HttpDelete]
		public IActionResult DeleteCategoryNews(int id)
		{
			var values = _categoryNewsService.TGetById(id);
			_categoryNewsService.TDelete(values);
			return Ok("Başarıyla silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetCategoryNews(int id)
		{
			var values = _categoryNewsService.TGetById(id);
			return Ok(values);
		}
		[HttpPut]
		public IActionResult UpdateCategoryNews(UpdateCategoryNewsDto updateCategoryNewsDto)
		{
			CategoryNews categoryNews = new CategoryNews()
			{
				CategoryNewsID = updateCategoryNewsDto.CategoryNewsID,
				CategoryNewsTitle = updateCategoryNewsDto.CategoryNewsTitle,
				CategoryNewsDescription = updateCategoryNewsDto.CategoryNewsDescription,
				CategoryNewsImageUrl = updateCategoryNewsDto.CategoryNewsImageUrl,
				CategoryNewsAuthor = updateCategoryNewsDto.CategoryNewsAuthor,
				CategoryNewsTime = updateCategoryNewsDto.CategoryNewsTime,
			};
			_categoryNewsService.TUpdate(categoryNews);
			return Ok("Güncelleme işlemi başarılı.");
		}
	}
}
