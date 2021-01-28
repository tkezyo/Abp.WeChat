using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Response
{
    public class GetSharedCodeRoomResponse : IMiniProgramResponse
    {
        public string ErrorMessage { get; set; }

        public int ErrorCode { get; set; }


        [JsonProperty("cdnUrl")]
        public string CdnUrl { get; set; }

        [JsonProperty("pagePath")]
        public string PagePath { get; set; }

        [JsonProperty("posterUrl")]
        public string PosterUrl { get; set; }

    }
}
