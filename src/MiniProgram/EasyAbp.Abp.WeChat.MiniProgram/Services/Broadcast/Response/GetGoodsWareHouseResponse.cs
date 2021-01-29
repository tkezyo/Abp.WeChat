using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Response
{
    public class GetGoodsWareHouseResponse : IMiniProgramResponse
    {

        public string ErrorMessage { get; set; }

        public int ErrorCode { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("goods")]
        public List <GetGoods> Goods { get; set; }


    }

    public class GetGoods {

        [JsonProperty("coverImgUrl")]
        public string CoverImgUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("priceType")]
        public int PriceType { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("price2")]
        public int Price2 { get; set; }

        [JsonProperty("url")]
        public int Url { get; set; }

        [JsonProperty("goodsId")]
        public int GoodsId { get; set; }
    }
}
