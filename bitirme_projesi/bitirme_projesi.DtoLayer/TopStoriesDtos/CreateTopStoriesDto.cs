using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.DtoLayer.TopStoriesDtos
{
	public class CreateTopStoriesDto
	{
		public string TopStoriesTitle { get; set; }
		public string TopStoriesDescription { get; set; }
		public string TopStoriesAuthor { get; set; }
		public string TopStoriesImageUrl { get; set; }
		public DateTime TopStoriesTime { get; set; }
	}
}
