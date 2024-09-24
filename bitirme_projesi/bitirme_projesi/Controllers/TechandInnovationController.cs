using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DtoLayer.NewsDtos;
using bitirme_projesi.DtoLayer.PopulerNewsDtos;
using bitirme_projesi.DtoLayer.RecentPostDtos;
using bitirme_projesi.DtoLayer.TechandInnovationDtos;
using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace bitirme_projesi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TechandInnovationController : ControllerBase
	{
		private readonly ITechandInnovationsService _techandInnovationsService;

		public TechandInnovationController(ITechandInnovationsService techandInnovationsService)
		{
			_techandInnovationsService = techandInnovationsService;
		}

		[HttpGet]
		public IActionResult TechandInnovationList()
		{
			var values = _techandInnovationsService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateTechandInnovation(CreateTechandInnovationDto createTechandInnovationDto)
		{
			TechandInnovation techandInnovation = new TechandInnovation()
			{
				TechandInnovationTitle = createTechandInnovationDto.TechandInnovationTitle,
				TechandInnovationDescription = createTechandInnovationDto.TechandInnovationDescription,
				TechandInnovationAuthor = createTechandInnovationDto.TechandInnovationAuthor,
				TechandInnovationImageUrl = createTechandInnovationDto.TechandInnovationImageUrl,
				TechandInnovationTime = createTechandInnovationDto.TechandInnovationTime,
			};
			_techandInnovationsService.TInsert(techandInnovation);
			return Ok("Haber eklendi.");
		}
		[HttpDelete]
		public IActionResult DeleteTechandInnovation(int id)
		{
			var values = _techandInnovationsService.TGetById(id);
			_techandInnovationsService.TDelete(values);
			return Ok("Haber Başarıyla silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetTechandInnovation(int id)
		{
			var values = _techandInnovationsService.TGetById(id);
			return Ok(values);
		}
		[HttpPut]
		public IActionResult UpdateTechandInnovation(UpdateTechandInnovationDto updateTechandInnovationDto)
		{
			TechandInnovation techandInnovation = new TechandInnovation()
			{
				TechandInnovationID = updateTechandInnovationDto.TechandInnovationID,
				TechandInnovationTitle= updateTechandInnovationDto.TechandInnovationTitle,
				TechandInnovationDescription = updateTechandInnovationDto.TechandInnovationDescription,
				TechandInnovationAuthor = updateTechandInnovationDto.TechandInnovationAuthor,
				TechandInnovationImageUrl = updateTechandInnovationDto.TechandInnovationImageUrl,
				TechandInnovationTime = updateTechandInnovationDto.TechandInnovationTime,
			};
			_techandInnovationsService.TUpdate(techandInnovation);
			return Ok("Güncelleme işlemi tamamlandı.");
		}
	}
}
