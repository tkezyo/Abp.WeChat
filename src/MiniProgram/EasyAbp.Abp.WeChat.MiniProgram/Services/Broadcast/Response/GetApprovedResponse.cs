using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Response
{
    public class GetApprovedResponse : IMiniProgramResponse

    {
        public string ErrorMessage { get; set; }

        public int ErrorCode { get; set; }

        [JsonProperty("goods")]
        public List<GetApprovedGoods> Goods { get; set; }
    }

    public class GetApprovedGoods
    {

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

        [JsonProperty("thirdPartyTag")]
        public int ThirdPartyTag { get; set; }
    }
}
