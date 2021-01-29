using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.Official.Services.Media.Response
{
    public class GetMaterialCountResponse
    {
        [JsonProperty("voice_count")]
        public int VoiceCount { get; set; }

        [JsonProperty("video_count")]
        public int VideoCount { get; set; }

        [JsonProperty("image_count")]

        public int ImageCount { get; set; }

        [JsonProperty("news_count")]
        public int NewsCount { get; set; }
    }
}
