using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DtoLayer.NewsDtos;
using bitirme_projesi.DtoLayer.PopulerNewsDtos;
using bitirme_projesi.DtoLayer.RecentPostDtos;
using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace bitirme_projesi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RecentPostController : ControllerBase
	{
		private readonly IRecentPostService _recentPostService;

		public RecentPostController(IRecentPostService recentPostService)
		{
			_recentPostService = recentPostService;
		}

		[HttpGet]
		public IActionResult RecentPostList()
		{
			var values = _recentPostService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateRecentPost(CreateRecentPostDto createRecentPostDto)
		{
			RecentPost recentPost = new RecentPost()
			{
				RecentPostTitle = createRecentPostDto.RecentPostTitle,
				RecentPostTime = createRecentPostDto.RecentPostTime,
				RecentPostDescription = createRecentPostDto.RecentPostDescription,
				RecentPostAuthor = createRecentPostDto.RecentPostAuthor,
				RecentPostImageUrl = createRecentPostDto.RecentPostImageUrl,
			};
			_recentPostService.TInsert(recentPost);
			return Ok("Haber eklendi.");
		}
		[HttpDelete]
		public IActionResult DeleteRecentPost(int id)
		{
			var values = _recentPostService.TGetById(id);
			_recentPostService.TDelete(values);
			return Ok("Haber Başarıyla silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetRecentPost(int id)
		{
			var values = _recentPostService.TGetById(id);
			return Ok(values);
		}
		[HttpPut]
		public IActionResult UpdateRecentPost(UpdateRecentPostDto updateRecentPostDto)
		{
			RecentPost recentPost = new RecentPost()
			{
				RecentPostID = updateRecentPostDto.RecentPostID,
				RecentPostTitle = updateRecentPostDto.RecentPostTitle,
				RecentPostDescription = updateRecentPostDto.RecentPostDescription,
				RecentPostAuthor = updateRecentPostDto.RecentPostAuthor,
				RecentPostImageUrl = updateRecentPostDto.RecentPostImageUrl,
				RecentPostTime = updateRecentPostDto.RecentPostTime,
			};
			_recentPostService.TUpdate(recentPost);
			return Ok("Güncelleme işlemi tamamlandı.");
		}
	}
}
