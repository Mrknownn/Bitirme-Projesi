using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DtoLayer.LatestReviewsDtos;
using bitirme_projesi.DtoLayer.MidPartDtos;
using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bitirme_projesi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LatestReviewsController : ControllerBase
    {
        private readonly ILatestReviewsService _latestReviewsService;

        public LatestReviewsController(ILatestReviewsService latestReviewsService)
        {
            _latestReviewsService = latestReviewsService;
        }

        [HttpGet]
        public IActionResult LatestReviwsList()
        {
            var values = _latestReviewsService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateLatestReviews(CreateLatestReviewsDto createLatestReviewsDto)
        {
            LatestReviews latestReviews = new LatestReviews()
            {
                LatestReviewsTitle = createLatestReviewsDto.LatestReviewsTitle,
                LatestReviewsDescription = createLatestReviewsDto.LatestReviewsDescription,
                LatestReviewsAuthor = createLatestReviewsDto.LatestReviewsAuthor,
                LatestReviewsImageUrl = createLatestReviewsDto.LatestReviewsImageUrl,
                LatestReviewsTime = createLatestReviewsDto.LatestReviewsTime,

            };
            _latestReviewsService.TInsert(latestReviews);
            return Ok("Başarıyla eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteLatestReviews(int id)
        {
            var values = _latestReviewsService.TGetById(id);
            _latestReviewsService.TDelete(values);
            return Ok("Başarıyla silindi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetLatestReviews(int id)
        {
            var values = _latestReviewsService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateLatestReviews(UpdateLatestReviewsDto updateLatestReviewsDto)
        {
            LatestReviews latestReviews = new LatestReviews()
            {
                LatestReviewsID = updateLatestReviewsDto.LatestReviewsID,
                LatestReviewsDescription = updateLatestReviewsDto.LatestReviewsDescription,
                LatestReviewsTitle = updateLatestReviewsDto.LatestReviewsTitle,
                LatestReviewsImageUrl = updateLatestReviewsDto.LatestReviewsImageUrl,
                LatestReviewsTime = updateLatestReviewsDto.LatestReviewsTime,
                LatestReviewsAuthor = updateLatestReviewsDto.LatestReviewsAuthor
                };
            _latestReviewsService.TUpdate(latestReviews);
            return Ok("Başarıyla güncellendi.");
        }
    }
}
