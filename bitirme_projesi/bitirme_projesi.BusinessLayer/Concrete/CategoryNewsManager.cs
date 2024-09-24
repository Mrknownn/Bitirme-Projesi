using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.DataAccessLayer.Abstract;
using bitirme_projesi.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.BusinessLayer.Concrete
{
	public class CategoryNewsManager : ICategoryNewsService
	{
		private readonly ICategoryNewsDal _categoryNewsDal;

		public CategoryNewsManager(ICategoryNewsDal categoryNewsDal)
		{
			_categoryNewsDal = categoryNewsDal;
		}

		public void TDelete(CategoryNews entity)
		{
			_categoryNewsDal.Delete(entity);
		}

		public CategoryNews TGetById(int id)
		{
			return _categoryNewsDal.GetById(id);
		}

		public List<CategoryNews> TGetListAll()
		{
			return _categoryNewsDal.GetListAll();
		}

		public void TInsert(CategoryNews entity)
		{
			_categoryNewsDal.Insert(entity);
		}

		public void TUpdate(CategoryNews entity)
		{
			_categoryNewsDal.Update(entity);
		}
	}
}
