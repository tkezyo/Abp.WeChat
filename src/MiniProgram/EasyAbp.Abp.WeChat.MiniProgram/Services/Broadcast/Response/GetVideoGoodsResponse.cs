using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Response
{
    public class GetVideoGoodsResponse : IMiniProgramResponse
    {
        public string ErrorMessage { get; set; }

        public int ErrorCode { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
