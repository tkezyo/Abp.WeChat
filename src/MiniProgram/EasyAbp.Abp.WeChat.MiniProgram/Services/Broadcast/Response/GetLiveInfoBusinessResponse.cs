using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Response
{
    public class GetLiveInfoBusinessResponse : IMiniProgramResponse
    {
        public string ErrorMessage { get; set; }

        public int ErrorCode { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        public List<RoomInfo> RoomInfo { get; set; }


    }

    public class RoomInfo
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roomid")]
        public string Roomid { get; set; }

        [JsonProperty("cover_img")]
        public string CoverImg { get; set; }

        [JsonProperty("share_img")]
        public string ShareImg { get; set; }

        [JsonProperty("live_status")]
        public string LiveStatus { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public int EndTime { get; set; }

        [JsonProperty("anchor_name")]
        public string AnchorName { get; set; }

        public List<Goods> Goods { get; set; }

        [JsonProperty("live_type")]
        public int LiveType { get; set; }

        [JsonProperty("close_like")]
        public int CloseLike { get; set; }

        [JsonProperty("close_goods")]
        public int CloseGoods { get; set; }

        [JsonProperty("close_comment")]
        public int CloseComment { get; set; }

        [JsonProperty("close_kf")]
        public int CloseKf { get; set; }

        [JsonProperty("close_replay")]
        public string CloseReplay { get; set; }

        [JsonProperty("is_feeds_public")]
        public int IsFeedsPublic { get; set; }

        [JsonProperty("creater_openid")]
        public string CreaterOpenid { get; set; }

        [JsonProperty("feeds_img")]
        public string FeedsImg { get; set; }
    }
    public class Goods
    {

        [JsonProperty("cover_img")]
        public string CoverImg { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("price2")]
        public int Price2 { get; set; }

        [JsonProperty("price_type")]
        public int PriceType { get; set; }

        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        [JsonProperty("third_party_appid")]
        public string ThirdPartyAppid { get; set; }
    }
}
