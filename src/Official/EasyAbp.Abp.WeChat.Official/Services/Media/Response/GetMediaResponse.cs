using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.Official.Services.Media
{
    public class GetMediaResponse
    {
        [JsonProperty("video_url")]
        public string VideoUrl { get; set; }
    }
}
