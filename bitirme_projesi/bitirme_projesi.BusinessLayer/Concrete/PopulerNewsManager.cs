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
	public class PopulerNewsManager : IPopulerNewService
	{
		private readonly IPopulerNewsDal _populerNewsDal;
		public void TDelete(PopulerNews entity)
		{
			_populerNewsDal.Delete(entity);
		}

		public PopulerNews TGetById(int id)
		{
			return _populerNewsDal.GetById(id);
		}

		public List<PopulerNews> TGetListAll()
		{
			return _populerNewsDal.GetListAll();
		}

		public void TInsert(PopulerNews entity)
		{
			_populerNewsDal.Insert(entity);
		}

		public void TUpdate(PopulerNews entity)
		{
			_populerNewsDal.Update(entity);
		}
	}
}
