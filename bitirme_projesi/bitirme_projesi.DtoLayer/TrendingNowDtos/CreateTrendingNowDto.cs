using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.DtoLayer.TrendingNowDtos
{
	public class CreateTrendingNowDto
	{
		public string TrendingNowTitle { get; set; }
		public string TrendingNowDescription { get; set; }
		public string TrendingNowAuthor { get; set; }
		public DateTime TrendingNowDate { get; set; }
	}
}
