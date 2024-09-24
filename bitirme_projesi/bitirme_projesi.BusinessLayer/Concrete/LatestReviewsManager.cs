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
    public class LatestReviewsManager : ILatestReviewsService
    {
        private readonly ILatestReviewsDal _latestReviewsDal;

        public LatestReviewsManager(ILatestReviewsDal latestReviewsDal)
        {
            _latestReviewsDal = latestReviewsDal;
        }

        public void TDelete(LatestReviews entity)
        {
            _latestReviewsDal.Delete(entity);
        }

        public LatestReviews TGetById(int id)
        {
            return _latestReviewsDal.GetById(id);
        }

        public List<LatestReviews> TGetListAll()
        {
            return _latestReviewsDal.GetListAll();
        }

        public void TInsert(LatestReviews entity)
        {
            _latestReviewsDal.Insert(entity);
        }

        public void TUpdate(LatestReviews entity)
        {
            _latestReviewsDal.Update(entity);
        }
    }
}
