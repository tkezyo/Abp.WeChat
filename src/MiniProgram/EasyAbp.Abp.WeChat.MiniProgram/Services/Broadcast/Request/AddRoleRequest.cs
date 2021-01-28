using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Request
{
     public class AddRoleRequest : MiniProgramCommonRequest
    {

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("role")]
        public int Role { get; set; }
    }
}
