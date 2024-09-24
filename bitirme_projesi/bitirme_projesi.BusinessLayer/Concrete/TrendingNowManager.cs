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
	public class TrendingNowManager : ITrendingNowService
	{
		private readonly ITrendingNowDal _trendingNowDal;

		public TrendingNowManager(ITrendingNowDal trendingNowDal)
		{
			_trendingNowDal = trendingNowDal;
		}

		public void TDelete(TrendingNow entity)
		{
			_trendingNowDal.Delete(entity);
		}

		public TrendingNow TGetById(int id)
		{
			return _trendingNowDal.GetById(id);
		}

		public List<TrendingNow> TGetListAll()
		{
			return _trendingNowDal.GetListAll();
		}

		public void TInsert(TrendingNow entity)
		{
			_trendingNowDal.Insert(entity);
		}

		public void TUpdate(TrendingNow entity)
		{
			_trendingNowDal.Update(entity);
		}
	}
}
