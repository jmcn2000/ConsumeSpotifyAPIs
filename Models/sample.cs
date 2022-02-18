//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ConsumeSpotifyAPIs.Models
//{

//    public class Rootobject
//    {
//        public Album[] albums { get; set; }
//    }

//    public class Album
//    {
//        public string album_type { get; set; }
//        public int total_tracks { get; set; }
//        public string[] available_markets { get; set; }
//        public External_Urls external_urls { get; set; }
//        public string href { get; set; }
//        public string id { get; set; }
//        public Image[] images { get; set; }
//        public string name { get; set; }
//        public string release_date { get; set; }
//        public string release_date_precision { get; set; }
//        public Restrictions restrictions { get; set; }
//        public string type { get; set; }
//        public string uri { get; set; }
//        public Artist[] artists { get; set; }
//        public Tracks tracks { get; set; }
//    }

//    public class External_Urls
//    {
//        public string spotify { get; set; }
//    }

//    public class Restrictions
//    {
//        public string reason { get; set; }
//    }

//    public class Tracks
//    {
//        public string href { get; set; }
//        public Item[] items { get; set; }
//        public int limit { get; set; }
//        public string next { get; set; }
//        public int offset { get; set; }
//        public string previous { get; set; }
//        public int total { get; set; }
//    }

//    public class Item
//    {
//    }

//    public class Image
//    {
//        public string url { get; set; }
//        public int height { get; set; }
//        public int width { get; set; }
//    }

//    public class Artist
//    {
//        public External_Urls1 external_urls { get; set; }
//        public Followers followers { get; set; }
//        public string[] genres { get; set; }
//        public string href { get; set; }
//        public string id { get; set; }
//        public Image1[] images { get; set; }
//        public string name { get; set; }
//        public int popularity { get; set; }
//        public string type { get; set; }
//        public string uri { get; set; }
//    }

//    public class External_Urls1
//    {
//        public string spotify { get; set; }
//    }

//    public class Followers
//    {
//        public string href { get; set; }
//        public int total { get; set; }
//    }

//    public class Image1
//    {
//        public string url { get; set; }
//        public int height { get; set; }
//        public int width { get; set; }
//    }

//}
