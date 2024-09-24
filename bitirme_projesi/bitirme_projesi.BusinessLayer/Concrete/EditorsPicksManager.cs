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
	public class EditorsPicksManager : IEditorsPickesService
	{
		private readonly IEditorsPickesDal _editorsPickesDal;

		public EditorsPicksManager(IEditorsPickesDal editorsPickesDal)
		{
			_editorsPickesDal = editorsPickesDal;
		}

		public void TDelete(EditorsPicks entity)
		{
			_editorsPickesDal.Delete(entity);
		}

		public EditorsPicks TGetById(int id)
		{
			return _editorsPickesDal.GetById(id);
		}

		public List<EditorsPicks> TGetListAll()
		{
			return _editorsPickesDal.GetListAll();
		}

		public void TInsert(EditorsPicks entity)
		{
			_editorsPickesDal.Insert(entity);
		}

		public void TUpdate(EditorsPicks entity)
		{
			_editorsPickesDal.Update(entity);
		}
	}
}
