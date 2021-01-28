using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Response
{
    public class AddGoodsResponse : IMiniProgramResponse
    {
        public string ErrorMessage { get; set; }

        public int ErrorCode { get; set; }

        [JsonProperty("goodsId")]
        public int GoodsId { get; set; }

        [JsonProperty("auditId")]
        public int AuditId { get; set; }
    }
}
