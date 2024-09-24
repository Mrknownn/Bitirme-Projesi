using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.DtoLayer.EditorsPicksDtos
{
	public class CreateEditorsPicksDto
	{
		public string EditorsPicksTitle { get; set; }
		public string EditorsPicksDescription { get; set; }
		public string EditorsPicksAuthor { get; set; }
		public string EditorsPicksImageUrl { get; set; }
		public DateTime EditorsPicksTime { get; set; }
	}
}
