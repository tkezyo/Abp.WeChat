using EasyAbp.Abp.WeChat.Official.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.Official.Services.Media.Request
{
    public class BatchgetMaterialRequest : OfficialCommonRequest
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

    }
}
