using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DtoLayer.VideoPartDtos;
using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace bitirme_projesi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class VideoPartController : ControllerBase
	{
		private readonly IVideoPartService _videoPartService;

		public VideoPartController(IVideoPartService videoPartService)
		{
			_videoPartService = videoPartService;
		}

		[HttpGet]
		public IActionResult NewsList()
		{
			var values = _videoPartService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateVideoPart(CreateVideoPartDto createVideoPartDto)
		{
			VideoPart videoPart = new VideoPart()
			{
				videoPartName = createVideoPartDto.videoPartName,
				videoDataNumber = createVideoPartDto.videoDataNumber,
				videoAuthor = createVideoPartDto.videoAuthor,
				videoUrl = createVideoPartDto.videoUrl,
			};
			_videoPartService.TInsert(videoPart);
			return Ok("Haber eklendi.");
		}
		[HttpDelete]
		public IActionResult DeleteVideoPart(int id)
		{
			var values = _videoPartService.TGetById(id);
			_videoPartService.TDelete(values);
			return Ok("Haber Başarıyla silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetVideoPart(int id)
		{
			var values = _videoPartService.TGetById(id);
			return Ok(values);
		}
		[HttpPut]
		public IActionResult UpdateNews(UpdateVideoPartDto updateVideoPartDto)
		{
			VideoPart videoPart = new VideoPart()
			{
				videoPartID = updateVideoPartDto.videoPartID,
				videoUrl = updateVideoPartDto.videoUrl,
				videoDataNumber = updateVideoPartDto.videoDataNumber,
				videoPartName = updateVideoPartDto.videoPartName,
				videoAuthor = updateVideoPartDto.videoAuthor,
			};
			_videoPartService.TUpdate(videoPart);
			return Ok("Güncelleme işlemi tamamlandı.");
		}
	}
}
