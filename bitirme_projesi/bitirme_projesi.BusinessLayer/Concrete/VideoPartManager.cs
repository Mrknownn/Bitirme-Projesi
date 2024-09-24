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
	public class VideoPartManager : IVideoPartService
	{
		private readonly IVideoPartDal _videoPartDal;

		public VideoPartManager(IVideoPartDal videoPartDal)
		{
			_videoPartDal = videoPartDal;
		}

		public void TDelete(VideoPart entity)
		{
			_videoPartDal.Delete(entity);
		}

		public VideoPart TGetById(int id)
		{
			return _videoPartDal.GetById(id);
		}

		public List<VideoPart> TGetListAll()
		{
			return _videoPartDal.GetListAll();
		}

		public void TInsert(VideoPart entity)
		{
			_videoPartDal.Insert(entity);
		}

		public void TUpdate(VideoPart entity)
		{
			_videoPartDal.Update(entity);
		}
	}
}
