using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Request
{
    public class GetRoleListRequestcs : MiniProgramCommonRequest
    {

        [JsonProperty("role")]
        public int Role { get; set; }


        [JsonProperty("offset")]
        public int offset { get; set; }


        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("keyword")]
        public int KeyWord { get; set; }
    }
}
