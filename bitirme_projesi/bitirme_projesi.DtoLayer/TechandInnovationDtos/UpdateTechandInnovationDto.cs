using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.DtoLayer.TechandInnovationDtos
{
	public class UpdateTechandInnovationDto
	{
		public int TechandInnovationID { get; set; }
		public string TechandInnovationTitle { get; set; }
		public string TechandInnovationDescription { get; set; }
		public string TechandInnovationAuthor { get; set; }
		public string TechandInnovationImageUrl { get; set; }
		public DateTime TechandInnovationTime { get; set; }
	}
}
