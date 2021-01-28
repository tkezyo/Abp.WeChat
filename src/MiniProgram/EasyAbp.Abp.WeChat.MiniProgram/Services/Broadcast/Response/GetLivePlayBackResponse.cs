using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Response
{
    public class GetLivePlayBackResponse : IMiniProgramResponse
    {
        public string ErrorMessage { get; set; }

        public int ErrorCode { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        public List<LiveReplay> LiveReplay { get; set; }

    }
    public class LiveReplay
    {

        [JsonProperty("expire_time")]
        public string ExpireTime { get; set; }

        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        [JsonProperty("media_url")]
        public string MediaUrl { get; set; }

    }
}
