using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Request
{
    public class SortGoodsRequest : MiniProgramCommonRequest
    {
        [JsonProperty("roomId")]
        public int RoomId { get; set; }

        public List<Goods> Goods { get; set; }
    }
    public class Goods
    {

        [JsonProperty("goodsId")]
        public int GoodsId { get; set; }
    }
}
