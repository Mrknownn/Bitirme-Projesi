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
	public class RecentPostManager : IRecentPostService
	{
		private readonly IRecentPostDal _recentPostDal;

		public RecentPostManager(IRecentPostDal recentPostDal)
		{
			_recentPostDal = recentPostDal;
		}

		public void TDelete(RecentPost entity)
		{
			_recentPostDal.Delete(entity);
		}

		public RecentPost TGetById(int id)
		{
			return _recentPostDal.GetById(id);
		}

		public List<RecentPost> TGetListAll()
		{
			return _recentPostDal.GetListAll();
		}

		public void TInsert(RecentPost entity)
		{
			_recentPostDal.Insert(entity);
		}

		public void TUpdate(RecentPost entity)
		{
			_recentPostDal.Update(entity);
		}
	}
}
