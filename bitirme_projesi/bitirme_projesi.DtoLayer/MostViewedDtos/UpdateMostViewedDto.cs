using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.DtoLayer.MostViewedDtos
{
	public class UpdateMostViewedDto
	{
		public int MostViewedID { get; set; }
		public string MostViewedTitle { get; set; }
		public string MostViewedDescription { get; set; }
		public string MostViewedAuthor { get; set; }
		public string MostViewedImageUrl { get; set; }
		public DateTime MostViewedTime { get; set; }
	}
}
