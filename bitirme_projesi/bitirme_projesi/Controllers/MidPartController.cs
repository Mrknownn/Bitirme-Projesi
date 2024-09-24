using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DtoLayer.MidPartDtos;
using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bitirme_projesi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MidPartController : ControllerBase
	{
		private readonly IMidPartService _midPartService;

		public MidPartController(IMidPartService midPartService)
		{
			_midPartService = midPartService;
		}

		[HttpGet]
		public IActionResult MidPartList()
		{
			var values = _midPartService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateMidPart(CreateMidPartDto createMidPartDto)
		{
			MidPart midPart = new MidPart()
			{
				MidPartTitle = createMidPartDto.MidPartTitle,
				MidPartDescription = createMidPartDto.MidPartDescription,
				MidPartAuthor = createMidPartDto.MidPartAuthor,
				MidPartImageUrl = createMidPartDto.MidPartImageUrl,
				MidPartTime = createMidPartDto.MidPartTime,	
			
			};
			_midPartService.TInsert(midPart);
			return Ok("Başarıyla eklendi.");
		}
		[HttpDelete]
		public IActionResult DeleteMidPart(int id)
		{
			var values = _midPartService.TGetById(id);
			_midPartService.TDelete(values);
			return Ok("Başarıyla silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetMidPart(int id)
		{
			var values = _midPartService.TGetById(id);
			return Ok(values);
		}
		[HttpPut]
		public IActionResult UpdateMidPart(UpdateMidPartDto updateMidPartDto)
		{
			MidPart midPart = new MidPart()
			{
				MidPartID = updateMidPartDto.MidPartID,
				MidPartTitle = updateMidPartDto.MidPartTitle,
				MidPartDescription = updateMidPartDto.MidPartDescription,
				MidPartAuthor = updateMidPartDto.MidPartAuthor,
				MidPartImageUrl = updateMidPartDto.MidPartImageUrl,
				MidPartTime = updateMidPartDto.MidPartTime,
			};
			_midPartService.TUpdate(midPart);
			return Ok("Başarıyla güncellendi.");
		}
	}
}
