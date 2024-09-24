using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.EntityLayer.Concrete
{
	public class News
	{
		public int NewsID { get; set; }
		public string NewsTitle { get; set; }
		public string NewsDescription { get; set; }
		public string NewsAuthor { get; set; }
		public string NewsImageUrl { get; set; }
		public DateTime NewsDate { get; set; }
	}
}
