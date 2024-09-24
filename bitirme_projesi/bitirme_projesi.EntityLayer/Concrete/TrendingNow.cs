using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.EntityLayer.Concrete
{
	public class TrendingNow
	{
		public int TrendingNowID { get; set; }
		public string TrendingNowTitle { get; set; }
		public string TrendingNowDescription { get; set; }
		public string TrendingNowAuthor { get; set; }
		public DateTime TrendingNowDate { get; set; }
	}
}
