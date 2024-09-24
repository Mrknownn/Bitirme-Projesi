using bitirme_projesi.DataAccessLayer.Abstract;
using bitirme_projesi.DataAccessLayer.Concrete;
using bitirme_projesi.DataAccessLayer.Context;
using bitirme_projesi.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.DataAccessLayer.EntityFramework
{
	public class EfRecentPostDal : GenericRepository<RecentPost>, IRecentPostDal
	{
		public EfRecentPostDal(NewsContext newsContext) : base(newsContext)
		{
		}
	}
}
