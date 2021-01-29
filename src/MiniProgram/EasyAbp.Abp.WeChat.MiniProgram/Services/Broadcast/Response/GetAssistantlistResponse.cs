using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Response
{
    public class GetAssistantlistResponse : IMiniProgramResponse
    {
        public string ErrorMessage { get; set; }

        public int ErrorCode { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("maxcount")]
        public int MaxCount { get; set; }

        [JsonProperty("list")]
        public List<List> List { get; set; }
    }

    public class List
    { 
    

          [JsonProperty("timestamp")]
        public int TimesTamp { get; set; }

        [JsonProperty("headimg")]
        public string HeadImg { get; set; }

        [JsonProperty("nickname")]
        public string NickName { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }


        [JsonProperty("openid")]
        public string OpenId { get; set; }



    }
}
