using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DtoLayer.CategoryDtos;
using bitirme_projesi.DtoLayer.CategoryNewsDtos;
using bitirme_projesi.DtoLayer.EditorsPicksDtos;
using bitirme_projesi.DtoLayer.LatestArticlesDtos;
using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bitirme_projesi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LatestArticlesController : ControllerBase
	{
		private readonly ILatestArticlesService _latestArticlesService;

		public LatestArticlesController(ILatestArticlesService latestArticlesService)
		{
			_latestArticlesService = latestArticlesService;
		}

		[HttpGet]
		public ActionResult LatestArticlesList()
		{
			var values = _latestArticlesService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateLatestArticles(CreateLatestArticlesDto createLatestArticlesDto)
		{
			LatestArticles latestArticles = new LatestArticles()
			{
				LatestArticlesTitle = createLatestArticlesDto.LatestArticlesTitle,
				LatestArticlesDescription = createLatestArticlesDto.LatestArticlesDescription,
				LatestArticlesAuthor = createLatestArticlesDto.LatestArticlesAuthor,
				LatestArticlesImageUrl = createLatestArticlesDto.LatestArticlesImageUrl,
				LatestArticlesTime = createLatestArticlesDto.LatestArticlesTime,
			};
			_latestArticlesService.TInsert(latestArticles);
			return Ok("Başarıyla eklendi.");
		}
		[HttpDelete]
		public IActionResult DeleteLatestArticles(int id)
		{
			var values = _latestArticlesService.TGetById(id);
			_latestArticlesService.TDelete(values);
			return Ok("Başarıyla silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetLatestArticles(int id)
		{
			var values = _latestArticlesService.TGetById(id);
			return Ok(values);
		}
		[HttpPut]
		public IActionResult UpdateLatestArticles(UpdateLatestArticlesDto updateLatestArticlesDto)
		{
			LatestArticles latestArticles = new LatestArticles()
			{
				LatestArticlesID = updateLatestArticlesDto.LatestArticlesID,
				LatestArticlesTitle = updateLatestArticlesDto.LatestArticlesTitle,
				LatestArticlesDescription = updateLatestArticlesDto.LatestArticlesDescription,
				LatestArticlesAuthor = updateLatestArticlesDto.LatestArticlesAuthor,
				LatestArticlesImageUrl = updateLatestArticlesDto.LatestArticlesImageUrl,
				LatestArticlesTime = updateLatestArticlesDto.LatestArticlesTime,
			};
			_latestArticlesService.TUpdate(latestArticles);
			return Ok("Güncelleme işlemi başarılı.");
		}
	}
}
