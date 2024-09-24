﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.DtoLayer.RecentPostDtos
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
