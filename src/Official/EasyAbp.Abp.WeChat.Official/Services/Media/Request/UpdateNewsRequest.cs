using EasyAbp.Abp.WeChat.Official.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.Official.Services.Media.Request
{
    public class UpdateNewsRequest : OfficialCommonRequest
    {
        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        public List<UpdateNewsArticle> Articles { get; set; }
    }
    public class UpdateNewsArticle
    {
        [JsonProperty("title")]
        public string Title { get; set; }
            
        [JsonProperty("humb_media_id")]
        public string ThumbMediaId { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }
        [JsonProperty("digest")]

        public string Digest { get; set; }
        [JsonProperty("show_cover_pic")]

        public int ShowCoverPic { get; set; }
        [JsonProperty("content")]

        public string Content { get; set; }

        [JsonProperty("content_source_url")]
        public string ContentSourceUrl { get; set; }
    }
}
