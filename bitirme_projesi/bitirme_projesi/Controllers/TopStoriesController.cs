using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DtoLayer.NewsDtos;
using bitirme_projesi.DtoLayer.TopStoriesDtos;
using bitirme_projesi.DtoLayer.TrendingNowDtos;
using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace bitirme_projesi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TopStoriesController : ControllerBase
	{
		private readonly ITopStoriesService _topStoriesService;
		public TopStoriesController(ITopStoriesService topStoriesService)
		{
			_topStoriesService = topStoriesService;
		}
		[HttpGet]
		public IActionResult TopStoriesList()
		{
			var values = _topStoriesService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateTopStories(CreateTopStoriesDto createTopStoriesDto)
		{
			TopStories topStories = new TopStories()
			{
				TopStoriesTitle = createTopStoriesDto.TopStoriesTitle,
				TopStoriesDescription = createTopStoriesDto.TopStoriesDescription,
				TopStoriesAuthor = createTopStoriesDto.TopStoriesAuthor,
				TopStoriesImageUrl = createTopStoriesDto.TopStoriesImageUrl,
				TopStoriesTime = createTopStoriesDto.TopStoriesTime
			};
			_topStoriesService.TInsert(topStories);
			return Ok("Başarıyla eklendi.");
		}
		[HttpDelete]
		public IActionResult DeleteTopStories(int id)
		{
			var values = _topStoriesService.TGetById(id);
			_topStoriesService.TDelete(values);
			return Ok("Başarıyla silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetTopStories(int id)
		{
			var values = _topStoriesService.TGetById(id);
			return Ok(values);
		}
		[HttpPut]
		public IActionResult UpdateTopStories(UpdateTopStoriesDto updateTopStoriesDto)
		{
			TopStories topStories = new TopStories()
			{
				TopStoriesID = updateTopStoriesDto.TopStoriesID,
				TopStoriesTitle = updateTopStoriesDto.TopStoriesTitle,
				TopStoriesDescription = updateTopStoriesDto.TopStoriesDescription,
				TopStoriesAuthor = updateTopStoriesDto.TopStoriesAuthor,
				TopStoriesImageUrl = updateTopStoriesDto.TopStoriesImageUrl,
				TopStoriesTime = updateTopStoriesDto.TopStoriesTime
			};
			_topStoriesService.TUpdate(topStories);
			return Ok("Güncelleme işlemi tamamlandı.");
		}
	}
}
