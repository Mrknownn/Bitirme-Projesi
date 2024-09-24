namespace bitirme_projesi.adminpanel.Dtos.MostViewed
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
