using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Request
{
    public class DeleteRoomRequest : MiniProgramCommonRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
