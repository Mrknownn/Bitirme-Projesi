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
	public class TechandInnovationManager : ITechandInnovationsService
	{
		private readonly ITechandInnovationDal _techandInnovationDal;

		public TechandInnovationManager(ITechandInnovationDal techandInnovationDal)
		{
			_techandInnovationDal = techandInnovationDal;
		}

		public void TDelete(TechandInnovation entity)
		{
			_techandInnovationDal.Delete(entity);
		}

		public TechandInnovation TGetById(int id)
		{
			return _techandInnovationDal.GetById(id);
		}

		public List<TechandInnovation> TGetListAll()
		{
			return _techandInnovationDal.GetListAll();
		}

		public void TInsert(TechandInnovation entity)
		{
			_techandInnovationDal.Insert(entity);
		}

		public void TUpdate(TechandInnovation entity)
		{
			_techandInnovationDal.Update(entity);
		}
	}
}
