namespace bitirme_projesi.adminpanel.Dtos.LatestArticles
{
    public class UpdateLatestArticlesDto
    {
        public int LatestArticlesID { get; set; }
        public string LatestArticlesTitle { get; set; }
        public string LatestArticlesDescription { get; set; }
        public string LatestArticlesAuthor { get; set; }
        public string LatestArticlesImageUrl { get; set; }
        public DateTime LatestArticlesTime { get; set; }
    }
}
