﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitirme_projesi.EntityLayer.Concrete
{
	public class VideoPart
	{
		public int videoPartID { get; set; }
		public string videoDataNumber { get; set; }
		public string videoPartName { get; set; }
		public string videoUrl { get; set; }
		public string videoAuthor { get; set; }
	}
}
