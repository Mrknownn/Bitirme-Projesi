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
	public class AuthorManager : IAuthorService
	{
		private readonly IAuthorDal _authorDal;
		public AuthorManager(IAuthorDal authorDal)
		{
			_authorDal = authorDal;
		}

		public void TDelete(Author entity)
		{
			_authorDal.Delete(entity);
		}

		public Author TGetById(int id)
		{
			return _authorDal.GetById(id);	
		}

		public List<Author> TGetListAll()
		{
			return _authorDal.GetListAll();
		}

		public void TInsert(Author entity)
		{
			_authorDal.Insert(entity);
		}

		public void TUpdate(Author entity)
		{
			_authorDal.Update(entity);
		}
	}
}
