using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeSpotifyAPIs.Models
{


    public class GetNewReleaseResult
    {
        public Albums albums { get; set; }
    }

    public class Albums
    {
        public string href { get; set; }
        public Item[] items { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public string previous { get; set; }
        public int total { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }
    public class External_Urls
    {
        public string spotify { get; set; }
    }

    public class Artist
    {
        //public External_Urls external_urls { get; set; }
        public Followers followers { get; set; }
        public string[] genres { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        //public Image[] images { get; set; }
        public string name { get; set; }
        public int popularity { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }
    public class Item
    {
        public string name {get;set;}
        public string release_date  {get;set;}
        public Image[] images { get; set; }
        public External_Urls external_urls { get; set; }
        public Artist[] artists  { get; set; }
    }

    public class Followers
    {
        public string href { get; set; }
        public int total { get; set; }
    }

}
