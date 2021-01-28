using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Response
{
    public class CreateRoomResponse : IMiniProgramResponse
    {
        public string ErrorMessage { get; set; }

        public int ErrorCode { get; set; }

        [JsonProperty("roomId")]
        public int RoomId { get; set; }

        [JsonProperty("qrcode_url")]
        public string QrcodeUrl { get; set; }

    }
}
