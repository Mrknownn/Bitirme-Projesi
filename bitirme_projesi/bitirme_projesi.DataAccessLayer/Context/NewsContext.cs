using bitirme_projesi.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.DataAccessLayer.Context
{
	public class NewsContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-T7IB1O9;initial catalog=BitirmeProjesiDB; integrated Security=true");			
		}
		public DbSet<News> Newss { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<TrendingNow> TrendingNows { get; set; }
		public DbSet<CategoryNews> CategoryNewss { get; set; }
		public DbSet<EditorsPicks> EditorsPickss { get; set; }
		public DbSet<LatestArticles> LatestArticless { get; set; }
		public DbSet<MidPart> MidParts { get; set; }
		public DbSet<MostViewed> MostVieweds { get; set; }
		public DbSet<PopulerNews> PopulerNewss { get; set; }
		public DbSet<RecentPost> RecentPosts { get; set; }
		public DbSet<TechandInnovation> TechandInnovations { get; set; }
		public DbSet<TopStories> TopStoriess { get; set; }
		public DbSet<LatestReviews> LatestReviewss { get; set; }
		public DbSet<VideoPart> VideoParts { get; set; }


	}
}
