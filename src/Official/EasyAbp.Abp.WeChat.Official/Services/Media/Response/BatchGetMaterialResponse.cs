using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.Official.Services.Media.Response
{
    public class BatchGetMaterialResponse
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("item_count")]
        public int ItemCount { get; set; }

        public List<Item> Item { get; set; }

    }

    public class Item 
    {
        [JsonProperty("media_id")]
        public string MediaId { get; set; }
        public List<Content> Content { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }


        [JsonProperty("update_time")]
        public string UpdateTime { get; set; }

    }
    public class Content
    {
        public List<NewsItem> NewsItem { get; set; }

    }
    public class NewsItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("thumb_media_id")]
        public string ThumbMediaId { get; set; }

        [JsonProperty("show_cover_pic")]
        public int ShowCoverPic { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("digest")]
        public string Digest { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("content_source_url")]
        public string ContentSourceUrl { get; set; }
    }
}
