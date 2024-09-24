using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DtoLayer.AuthorDtos;
using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bitirme_projesi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthorController : ControllerBase
	{
		private readonly IAuthorService _authorService;
		public AuthorController(IAuthorService authorService)
		{
			_authorService = authorService;
		}
		[HttpGet]
		public IActionResult AuthorList()
		{
			var values = _authorService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateAuthor(CreateAuthorDtos createAuthorDtos)
		{
			Author author = new Author()
			{
				AuthorName = createAuthorDtos.AuthorName,
				AuthorEmail = createAuthorDtos.AuthorEmail,
				AuthorSurname = createAuthorDtos.AuthorSurname,
				AuthorImage = createAuthorDtos.AuthorImage,
			};
			_authorService.TInsert(author);
			return Ok("Yazar başarılı bir şekilde eklendi.");
		}
		[HttpDelete]
		public IActionResult DeleteAuthor(int id)
		{
			var values = _authorService.TGetById(id);
			_authorService.TDelete(values);
			return Ok("Yazar Başarıyla silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult Getauthor(int id)
		{
			var values = _authorService.TGetById(id);
			return Ok(values);
		}
		[HttpPut]
		public IActionResult UpdateNews(UpdateAuthorDtos updateAuthorDtos)
		{
			Author author = new Author()
			{
				AuthorName = updateAuthorDtos.AuthorName,
				AuthorSurname = updateAuthorDtos.AuthorSurname,
				AuthorEmail = updateAuthorDtos.AuthorEmail,
				AuthorImage = updateAuthorDtos.AuthorImage,
				AuthorID = updateAuthorDtos.AuthorID,
			};
			_authorService.TUpdate(author);
			return Ok("Güncelleme işlemi başarıyla tamamlandı.");
		}
	}
}
