using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.DtoLayer.PopulerNewsDtos
{
	public class UpdatePopulerNewsDto
	{
		public int PopulerNewsID { get; set; }
		public string PopulerNewsTitle { get; set; }
		public string PopulerNewsDescription { get; set; }
		public string PopulerNewsAuthor { get; set; }
		public string PopulerNewsImageUrl { get; set; }
		public DateTime PopulerNewsTime { get; set; }
	}
}
