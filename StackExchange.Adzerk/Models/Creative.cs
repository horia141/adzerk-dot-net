﻿namespace StackExchange.Adzerk.Models
{
    public class Creative
    {
        public long Id { get; set; }
        public long AdvertiserId { get; set; }
        public long AdTypeId { get; set; }
        
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string Url { get; set; }
        public string Body { get; set; }
        public string ScriptBody { get; set; }
        public string ImageLink { get; set; }
        public string Alt { get; set; }

        public bool IsSync { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsHTMLJS { get; set; }
        public bool IsActive { get; set; }
    }
}
