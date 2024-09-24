using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.EntityLayer.Concrete
{
    public class LatestReviews
    {
        public int LatestReviewsID { get; set; }
        public string LatestReviewsTitle { get; set; }
        public string LatestReviewsDescription { get; set; }
        public string LatestReviewsAuthor { get; set; }
        public string LatestReviewsImageUrl { get; set; }
        public string LatestReviewsTime { get; set; }
    }
}
