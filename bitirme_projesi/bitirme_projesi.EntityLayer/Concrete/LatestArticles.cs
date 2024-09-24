using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.EntityLayer.Concrete
{
	public class LatestArticles
	{
		public int LatestArticlesID { get; set; }
		public string LatestArticlesTitle { get; set; }
		public string LatestArticlesDescription { get; set; }
		public string LatestArticlesAuthor { get; set; }
		public string LatestArticlesImageUrl { get; set; }
		public DateTime LatestArticlesTime { get; set; }
	}
}
