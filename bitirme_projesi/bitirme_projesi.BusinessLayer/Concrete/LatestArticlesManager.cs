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
	public class LatestArticlesManager : ILatestArticlesService
	{
		private readonly ILatestArticlesDal _latestArticlesDal;

		public LatestArticlesManager(ILatestArticlesDal latestArticlesDal)
		{
			_latestArticlesDal = latestArticlesDal;
		}

		public void TDelete(LatestArticles entity)
		{
			_latestArticlesDal.Delete(entity);
		}

		public LatestArticles TGetById(int id)
		{
			return _latestArticlesDal.GetById(id);
		}

		public List<LatestArticles> TGetListAll()
		{
			return _latestArticlesDal.GetListAll();
		}

		public void TInsert(LatestArticles entity)
		{
			_latestArticlesDal.Insert(entity);
		}

		public void TUpdate(LatestArticles entity)
		{
			_latestArticlesDal.Update(entity);
		}
	}

}
