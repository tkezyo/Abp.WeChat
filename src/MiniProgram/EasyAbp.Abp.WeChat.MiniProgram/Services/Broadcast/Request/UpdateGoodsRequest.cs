using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Request
{
   public  class UpdateGoodsRequest : MiniProgramCommonRequest
    {
        public List<UpdateGoodsInfo> UpdateGoodsInfo { get; set; }
    }
    public class UpdateGoodsInfo
    {
        [JsonProperty("coverImgUrl")]
        public string CoverImgUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("priceType")]
        public int PriceType { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("url")]
        public int Url { get; set; }

        [JsonProperty("goodsId")]
        public int GoodsId { get; set; }
    }
}
