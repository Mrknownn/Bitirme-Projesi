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
	public class MidPartManager : IMidPartService
	{
		private readonly IMidPartDal _midPartDal;

		public MidPartManager(IMidPartDal midPartDal)
		{
			_midPartDal = midPartDal;
		}

		public void TDelete(MidPart entity)
		{
			_midPartDal.Delete(entity);
		}

		public MidPart TGetById(int id)
		{
			return _midPartDal.GetById(id);
		}

		public List<MidPart> TGetListAll()
		{
			return _midPartDal.GetListAll();
		}

		public void TInsert(MidPart entity)
		{
			_midPartDal.Insert(entity);
		}

		public void TUpdate(MidPart entity)
		{
			_midPartDal.Update(entity);
		}
	}
}
