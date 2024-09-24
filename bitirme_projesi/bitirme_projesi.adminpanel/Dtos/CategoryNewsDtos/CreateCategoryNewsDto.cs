namespace bitirme_projesi.adminpanel.Dtos.CategoryNewsDtos
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
