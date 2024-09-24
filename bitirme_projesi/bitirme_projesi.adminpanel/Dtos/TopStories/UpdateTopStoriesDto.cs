namespace bitirme_projesi.adminpanel.Dtos.TopStories
{
    public class UpdateTopStoriesDto
    {
        public int TopStoriesID { get; set; }
        public string TopStoriesTitle { get; set; }
        public string TopStoriesDescription { get; set; }
        public string TopStoriesAuthor { get; set; }
        public string TopStoriesImageUrl { get; set; }
        public DateTime TopStoriesTime { get; set; }
    }
}
