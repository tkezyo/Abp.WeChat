using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.Official.Services.Media.Response
{
    public class UploadImageResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
