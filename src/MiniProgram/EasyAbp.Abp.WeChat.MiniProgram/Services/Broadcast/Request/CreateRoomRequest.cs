using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Request
{
    public class CreateRoomRequest : MiniProgramCommonRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coverImg")]
        public string CoverImg { get; set; }

        [JsonProperty("startTime")]
        public int StartTime { get; set; }

        [JsonProperty("endTime")]
        public int EndTime { get; set; }

        [JsonProperty("anchorName")]
        public string AnchorName { get; set; }

        [JsonProperty("anchorWechat")]
        public string AnchorWechat { get; set; }

        [JsonProperty("subAnchorWechat")]
        public string SubAnchorWechat { get; set; }

        [JsonProperty("createrWechat")]
        public string CreaterWechat { get; set; }

        [JsonProperty("shareImg")]
        public string ShareImg { get; set; }

        [JsonProperty("feedsImg")]
        public string FeedsImg { get; set; }

        [JsonProperty("isFeedsPublic")]
        public int IsFeedsPublic { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("closeLike")]
        public int CloseLike { get; set; }

        [JsonProperty("closeGoods")]
        public int CloseGoods { get; set; }

        [JsonProperty("closeComment")]
        public int CloseComment { get; set; }

        [JsonProperty("closeReplay")]
        public int CloseReplay { get; set; }

        [JsonProperty("closeShare")]
        public int CloseShare { get; set; }

        [JsonProperty("closeKf")]
        public int CloseKf { get; set; }

    }
}
