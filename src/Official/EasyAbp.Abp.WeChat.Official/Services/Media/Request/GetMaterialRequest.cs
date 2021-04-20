using EasyAbp.Abp.WeChat.Official.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.Official.Services.Media.Request
{
    public class GetMaterialRequest : OfficialCommonRequest
    {
        [JsonProperty("media_id")]
        public string MediaId { get; set; }
    }
}
