﻿namespace bitirme_projesi.adminpanel.Dtos.MidPart
{
    public class CreateMidPartDto
    {        
        public string MidPartTitle { get; set; }
        public string MidPartDescription { get; set; }
        public string MidPartAuthor { get; set; }
        public string MidPartImageUrl { get; set; }
        public DateTime MidPartTime { get; set; }
    }
}
