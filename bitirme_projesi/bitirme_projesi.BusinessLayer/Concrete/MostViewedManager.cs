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
	public class MostViewedManager : IMostViewedService
	{
		private readonly IMostViewedDal _mostViewedDal;

		public MostViewedManager(IMostViewedDal mostViewedDal)
		{
			_mostViewedDal = mostViewedDal;
		}

		public void TDelete(MostViewed entity)
		{
			_mostViewedDal.Delete(entity);
		}

		public MostViewed TGetById(int id)
		{
			return _mostViewedDal.GetById(id);
		}

		public List<MostViewed> TGetListAll()
		{
			return _mostViewedDal.GetListAll();
		}

		public void TInsert(MostViewed entity)
		{
			_mostViewedDal.Insert(entity);
		}

		public void TUpdate(MostViewed entity)
		{
			_mostViewedDal.Update(entity);
		}
	}
}
