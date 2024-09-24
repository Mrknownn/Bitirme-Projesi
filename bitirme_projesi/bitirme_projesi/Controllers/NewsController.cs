using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DtoLayer.NewsDtos;
using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace bitirme_projesi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NewsController : ControllerBase
	{
		private readonly INewsService _newsService;
		public NewsController(INewsService newsService)
		{
			_newsService = newsService;
		}
		[HttpGet]
		public IActionResult NewsList()
		{
			var values = _newsService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateNews(CreateNewsDtos createNewsDtos)
		{
			News news = new News()
			{
				NewsTitle = createNewsDtos.NewsTitle,
				NewsAuthor = createNewsDtos.NewsAuthor,
				NewsDate = createNewsDtos.NewsDate,
				NewsDescription	= createNewsDtos.NewsDescription,
				NewsImageUrl = createNewsDtos.NewsImageUrl,
			};
			_newsService.TInsert(news);
			return Ok("Haber eklendi.");
		}
		[HttpDelete]
		public IActionResult DeleteNews(int id)
		{
			var values = _newsService.TGetById(id);
			_newsService.TDelete(values);
			return Ok("Haber Başarıyla silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetNews(int id)
		{
			var values = _newsService.TGetById(id);
			return Ok(values);
		}
		[HttpPut]
		public IActionResult UpdateNews(UpdateNewsDtos updateNewsDtos)
		{
			News news = new News()
			{
				NewsID = updateNewsDtos.NewsID,
				NewsTitle = updateNewsDtos.NewsTitle,
				NewsDescription = updateNewsDtos.NewsDescription,
				NewsAuthor = updateNewsDtos.NewsAuthor,
				NewsImageUrl = updateNewsDtos.NewsImageUrl,
				NewsDate = updateNewsDtos.NewsDate,
			};
			_newsService.TUpdate(news);
			return Ok("Güncelleme işlemi tamamlandı.");
		}
	}
}
