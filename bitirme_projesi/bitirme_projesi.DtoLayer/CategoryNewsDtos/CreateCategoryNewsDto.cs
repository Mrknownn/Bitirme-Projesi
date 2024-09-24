using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.DtoLayer.CategoryNewsDtos
{
	public class CreateCategoryNewsDto
	{

		public string CategoryNewsTitle { get; set; }
		public string CategoryNewsDescription { get; set; }
		public string CategoryNewsAuthor { get; set; }
		public string CategoryNewsImageUrl { get; set; }
		public DateTime CategoryNewsTime { get; set; }
	}
}
