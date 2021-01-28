using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Request
{
    public class GetLiveInfoBusinessRequest : MiniProgramCommonRequest
    {
        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
       
    }
}
