using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.DtoLayer.AuthorDtos
{
	public class CreateAuthorDtos
	{
		public string AuthorName { get; set; }
		public string AuthorSurname { get; set; }
		public string AuthorEmail { get; set; }
		public string AuthorImage { get; set; }
	}
}
