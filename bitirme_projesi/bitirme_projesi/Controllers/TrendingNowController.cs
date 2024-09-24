using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DtoLayer.NewsDtos;
using bitirme_projesi.DtoLayer.TrendingNowDtos;
using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace bitirme_projesi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TrendingNowController : ControllerBase
	{
		private readonly ITrendingNowService _trendingNowservice;

		public TrendingNowController(ITrendingNowService trendingNowservice)
		{
			_trendingNowservice = trendingNowservice;
		}

		[HttpGet]
		public IActionResult TrendingNowList()
		{
			var values = _trendingNowservice.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateTrendingNow(CreateTrendingNowDto createTrendingNowDto)
		{
			TrendingNow trendingNow = new TrendingNow()
			{
				TrendingNowTitle = createTrendingNowDto.TrendingNowTitle,
				TrendingNowDescription = createTrendingNowDto.TrendingNowDescription,
				TrendingNowAuthor = createTrendingNowDto.TrendingNowAuthor,
				TrendingNowDate = createTrendingNowDto.TrendingNowDate
			};
			_trendingNowservice.TInsert(trendingNow);
			return Ok("Başarıyla eklendi.");
		}
		[HttpDelete]
		public IActionResult DeleteTrendingNow(int id)
		{
			var values = _trendingNowservice.TGetById(id);
			_trendingNowservice.TDelete(values);
			return Ok("Başarıyla silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetTrendingNow(int id)
		{
			var values = _trendingNowservice.TGetById(id);
			return Ok(values);
		}
		[HttpPut]
		public IActionResult UpdateTrendingNow(UpdateTrendingNowDto	updateTrendingNowDto)
		{
			TrendingNow trendingNow = new TrendingNow()
			{
				TrendingNowID = updateTrendingNowDto.TrendingNowID,
				TrendingNowTitle = updateTrendingNowDto.TrendingNowTitle,
				TrendingNowDescription = updateTrendingNowDto.TrendingNowDescription,
				TrendingNowAuthor = updateTrendingNowDto.TrendingNowAuthor,
				TrendingNowDate = updateTrendingNowDto.TrendingNowDate
			};
			_trendingNowservice.TUpdate(trendingNow);
			return Ok("Güncelleme işlemi tamamlandı.");
		}
	}
}
