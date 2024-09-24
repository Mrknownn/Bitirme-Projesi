using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.EntityLayer.Concrete
{
	public class CategoryNews
	{
		public int CategoryNewsID { get; set; }
		public string CategoryNewsTitle { get; set; }
		public string CategoryNewsDescription { get; set; }
		public string CategoryNewsAuthor { get; set; }
		public string CategoryNewsImageUrl { get; set; }
		public DateTime CategoryNewsTime { get; set; }
	}
}
