using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Response
{
    public class GetPushRoomResponse : IMiniProgramResponse
    {
        public string ErrorMessage { get; set; }

        public int ErrorCode { get; set; }

        [JsonProperty("pushAddr")]
        public string PushAddr { get; set; }
    }
}
