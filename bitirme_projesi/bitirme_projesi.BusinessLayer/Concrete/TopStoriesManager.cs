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
	public class TopStoriesManager : ITopStoriesService
	{
		private readonly ITopStoriesDal _topStoriesDal;

		public TopStoriesManager(ITopStoriesDal topStoriesDal)
		{
			_topStoriesDal = topStoriesDal;
		}

		public void TDelete(TopStories entity)
		{
			_topStoriesDal.Delete(entity);
		}

		public TopStories TGetById(int id)
		{
			return _topStoriesDal.GetById(id);
		}

		public List<TopStories> TGetListAll()
		{
			return _topStoriesDal.GetListAll();
		}

		public void TInsert(TopStories entity)
		{
			_topStoriesDal.Insert(entity);
		}

		public void TUpdate(TopStories entity)
		{
			_topStoriesDal.Update(entity);
		}
	}
}
