using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.Official.Services.Media.Response
{
    public class AddNewsResponse
    {
        [JsonProperty("media_id")]
        public string MediaId { get; set; }
    }
}
