using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.BusinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		void TInsert(T entity);
		void TDelete(T entity);
		void TUpdate(T entity);
		List<T> TGetListAll();
		T TGetById(int id);
	}
}
