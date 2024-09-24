using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DtoLayer.CategoryDtos;
using bitirme_projesi.DtoLayer.CategoryNewsDtos;
using bitirme_projesi.DtoLayer.EditorsPicksDtos;
using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bitirme_projesi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EditorsPicksController : ControllerBase
	{
		private readonly IEditorsPickesService _editorsPickesService;

		public EditorsPicksController(IEditorsPickesService editorsPickesService)
		{
			_editorsPickesService = editorsPickesService;
		}

		[HttpGet]
		public ActionResult EditorsPicksList()
		{
			var values = _editorsPickesService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateEditorsPicks(CreateEditorsPicksDto createEditorsPicksDto)
		{
			EditorsPicks editorsPicks = new EditorsPicks()
			{
				EditorsPicksTitle = createEditorsPicksDto.EditorsPicksTitle,
				EditorsPicksDescription = createEditorsPicksDto.EditorsPicksDescription,
				EditorsPicksAuthor = createEditorsPicksDto.EditorsPicksAuthor,
				EditorsPicksImageUrl = createEditorsPicksDto.EditorsPicksImageUrl,
				EditorsPicksTime = createEditorsPicksDto.EditorsPicksTime,
			};
			_editorsPickesService.TInsert(editorsPicks);
			return Ok("Başarıyla eklendi.");
		}
		[HttpDelete]
		public IActionResult DeleteEditorsPicks(int id)
		{
			var values = _editorsPickesService.TGetById(id);
			_editorsPickesService.TDelete(values);
			return Ok("Başarıyla silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetEditorsPicks(int id)
		{
			var values = _editorsPickesService.TGetById(id);
			return Ok(values);
		}
		[HttpPut]
		public IActionResult UpdateEditorsPicks(UpdateEditorsPicksDto updateEditorsPicksDto)
		{
			EditorsPicks editorsPicks = new EditorsPicks()
			{
				EditorsPicksID = updateEditorsPicksDto.EditorsPicksID,
				EditorsPicksTitle = updateEditorsPicksDto.EditorsPicksTitle,
				EditorsPicksDescription = updateEditorsPicksDto.EditorsPicksDescription,
				EditorsPicksAuthor = updateEditorsPicksDto.EditorsPicksAuthor,
				EditorsPicksImageUrl = updateEditorsPicksDto.EditorsPicksImageUrl,
				EditorsPicksTime = updateEditorsPicksDto.EditorsPicksTime,
			};
			_editorsPickesService.TUpdate(editorsPicks);
			return Ok("Güncelleme işlemi başarılı.");
		}
	}
}
