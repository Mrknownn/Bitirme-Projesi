namespace bitirme_projesi.adminpanel.Dtos.RecentPost
{
    public class UpdateRecentPostDto
    {
        public int RecentPostID { get; set; }
        public string RecentPostTitle { get; set; }
        public string RecentPostDescription { get; set; }
        public string RecentPostAuthor { get; set; }
        public string RecentPostImageUrl { get; set; }
        public DateTime RecentPostTime { get; set; }
    }
}
