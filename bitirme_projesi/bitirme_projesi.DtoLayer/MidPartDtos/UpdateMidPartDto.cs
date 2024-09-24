using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.DtoLayer.MidPartDtos
{
	public class UpdateMidPartDto
	{
		public int MidPartID { get; set; }
		public string MidPartTitle { get; set; }
		public string MidPartDescription { get; set; }
		public string MidPartAuthor { get; set; }
		public string MidPartImageUrl { get; set; }
		public DateTime MidPartTime { get; set; }
	}
}
