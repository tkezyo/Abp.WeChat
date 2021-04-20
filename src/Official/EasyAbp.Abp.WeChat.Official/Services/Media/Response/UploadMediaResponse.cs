using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.Official.Services.Media
{
    public class UploadMediaResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("media_id")]
        public string Media_id { get; set; }

        [JsonProperty("created_at")]
        public long Created_at { get; set; }
    }
}
