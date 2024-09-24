namespace bitirme_projesi.adminpanel.Dtos.LatestArticles
{
    public class CreateLatestArticlesDto
    {
        public string LatestArticlesTitle { get; set; }
        public string LatestArticlesDescription { get; set; }
        public string LatestArticlesAuthor { get; set; }
        public string LatestArticlesImageUrl { get; set; }
        public DateTime LatestArticlesTime { get; set; }
    }
}
