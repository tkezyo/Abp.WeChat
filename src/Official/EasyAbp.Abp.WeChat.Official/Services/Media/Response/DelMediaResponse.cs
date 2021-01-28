using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.Official.Services.Media.Response
{
    public class DelMediaResponse
    {
        [JsonProperty("errcode")]

        public string ErrCode { get; set; }
        [JsonProperty("errmsg")]
        public string ErrMsg { get; set; }
    }
}
