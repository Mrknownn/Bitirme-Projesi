using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DtoLayer.MidPartDtos;
using bitirme_projesi.DtoLayer.MostViewedDtos;
using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bitirme_projesi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MostViewedController : ControllerBase
	{
		private readonly IMostViewedService _mostViewedService;

		public MostViewedController(IMostViewedService mostViewedService)
		{
			_mostViewedService = mostViewedService;
		}
		[HttpGet]
		public IActionResult MostViewedList()
		{
			var values = _mostViewedService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateMostViewed(CreateMostViewedDto createMostViewedDto)
		{
			MostViewed mostViewed = new MostViewed()
			{
				MostViewedTitle = createMostViewedDto.MostViewedTitle,
				MostViewedDescription = createMostViewedDto.MostViewedDescription,
				MostViewedAuthor = createMostViewedDto.MostViewedAuthor,
				MostViewedImageUrl = createMostViewedDto.MostViewedImageUrl,
				MostViewedTime = createMostViewedDto.MostViewedTime,

			};
			_mostViewedService.TInsert(mostViewed);
			return Ok("Başarıyla eklendi.");
		}
		[HttpDelete]
		public IActionResult DeleteMostViewed(int id)
		{
			var values = _mostViewedService.TGetById(id);
			_mostViewedService.TDelete(values);
			return Ok("Başarıyla silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetMostViewed(int id)
		{
			var values = _mostViewedService.TGetById(id);
			return Ok(values);
		}
		[HttpPut]
		public IActionResult UpdateMostViewed(UpdateMostViewedDto updateMostViewedDto)
		{
			MostViewed mostViewed = new MostViewed()
			{
				MostViewedID = updateMostViewedDto.MostViewedID,
				MostViewedTitle = updateMostViewedDto.MostViewedTitle,
				MostViewedDescription = updateMostViewedDto.MostViewedDescription,
				MostViewedAuthor = updateMostViewedDto.MostViewedAuthor,
				MostViewedImageUrl= updateMostViewedDto.MostViewedImageUrl,
				MostViewedTime = updateMostViewedDto.MostViewedTime,
			};
			_mostViewedService.TUpdate(mostViewed);
			return Ok("Başarıyla güncellendi.");
		}
	}
}
