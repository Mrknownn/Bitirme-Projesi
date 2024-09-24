namespace bitirme_projesi.adminpanel.Dtos.NewsDtos
{
    public class UpdateNewsDto
	{
        public int NewsID { get; set; }
        public string NewsTitle { get; set; }
        public string NewsDescription { get; set; }
        public string NewsAuthor { get; set; }
        public string NewsImageUrl { get; set; }
        public DateTime NewsDate { get; set; }
    }
}
