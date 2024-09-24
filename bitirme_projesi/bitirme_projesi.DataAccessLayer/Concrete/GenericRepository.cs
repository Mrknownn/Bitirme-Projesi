using bitirme_projesi.DataAccessLayer.Abstract;
using bitirme_projesi.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.DataAccessLayer.Concrete
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		private readonly NewsContext _newsContext;

		public GenericRepository(NewsContext newsContext)
		{
			_newsContext = newsContext;
		}

		public void Delete(T entity)
		{
			_newsContext.Remove(entity);
			_newsContext.SaveChanges();
		}
		public T GetById(int id)
		{
			return _newsContext.Set<T>().Find(id);
		}
		public List<T> GetListAll()
		{
			return _newsContext.Set<T>().ToList();
		}

		public void Insert(T entity)
		{
			_newsContext.Add(entity);
			_newsContext.SaveChanges();	
		}

		public void Update(T entity)
		{
			_newsContext.Update(entity);
			_newsContext.SaveChanges();
		}
	}
}
