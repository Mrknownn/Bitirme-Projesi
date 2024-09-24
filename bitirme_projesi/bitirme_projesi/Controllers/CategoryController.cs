using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DtoLayer.CategoryDtos;
using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bitirme_projesi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService _categoryService;

		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}
		[HttpGet]
		public ActionResult CategoryList() 
		{ 
			var values = _categoryService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateCategory(CreateCategoryDtos createCategoryDtos)
		{
			Category category = new Category()
			{
				CategoryName = createCategoryDtos.CategoryName,
			};
			_categoryService.TInsert(category);
			return Ok("Başarıyla eklendi.");
		}
		[HttpDelete]
		public IActionResult DeleteCategory(int id)
		{
			var values = _categoryService.TGetById(id);
			_categoryService.TDelete(values);
			return Ok("Başarıyla silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetCategory(int id)
		{
			var values = _categoryService.TGetById(id);
			return Ok(values);
		}
		[HttpPut]
		public IActionResult UpdateCategory(UpdateCategoryDtos updateCategoryDtos)
		{
			Category category = new Category()
			{
				CategoryID = updateCategoryDtos.CategoryID,
				CategoryName = updateCategoryDtos.CategoryName,
			};
			_categoryService.TUpdate(category);
			return Ok("Güncelleme işlemi başarılı.");
		}
	}
}
