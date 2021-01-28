using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Request
{
   public  class ResetauditGoodsResquest : MiniProgramCommonRequest
    {
        [JsonProperty("goodsId")]
        public int GoodsId { get; set; }

        [JsonProperty("auditId")]
        public int AuditId { get; set; }
    }
}
