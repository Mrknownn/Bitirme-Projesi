using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.EntityLayer.Concrete
{
	public class Author
	{
		public int AuthorID { get; set; }
		public string AuthorName { get; set; }
		public string AuthorSurname { get; set; }
		public string AuthorEmail { get; set; }
		public string AuthorImage { get; set; }
	}
}
