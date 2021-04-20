using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.Official.Services.Media.Response
{
    public class GetMaterialResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("down_url")]
        public string DownUrl { get; set; }

        [JsonProperty("news_item")]
        public List<MaterialNewsItem> NewsItem { get; set; }
    }

    public class MaterialNewsItem
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
}
