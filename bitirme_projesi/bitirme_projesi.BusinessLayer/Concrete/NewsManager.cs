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
	public class NewsManager : INewsService
	{
		private readonly INewsDal _newsDal;
		public NewsManager(INewsDal newsDal)
		{
			_newsDal = newsDal;
		}

		public void TDelete(News entity)
		{
			_newsDal.Delete(entity);
		}

		public News TGetById(int id)
		{
			return _newsDal.GetById(id);
		}

		public List<News> TGetListAll()
		{
			return _newsDal.GetListAll();
		}

		public void TInsert(News entity)
		{
			_newsDal.Insert(entity);
		}

		public void TUpdate(News entity)
		{
			_newsDal.Update(entity);
		}
	}
}
