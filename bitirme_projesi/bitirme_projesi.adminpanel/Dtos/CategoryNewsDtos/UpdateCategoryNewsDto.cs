namespace bitirme_projesi.adminpanel.Dtos.CategoryNewsDtos
{
	public class UpdateCategoryNewsDto
	{
		public int CategoryNewsID { get; set; }
		public string CategoryNewsTitle { get; set; }
		public string CategoryNewsDescription { get; set; }
		public string CategoryNewsAuthor { get; set; }
		public string CategoryNewsImageUrl { get; set; }
		public DateTime CategoryNewsTime { get; set; }
	}
}
