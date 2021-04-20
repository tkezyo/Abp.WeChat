using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Response
{
    public class GetRoleListResponse : IMiniProgramResponse
    {
        public string ErrorMessage { get; set; }

        public int ErrorCode { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("list")]
        public List<GetRoleListList> List { get; set; }
    }

    public class GetRoleListList {

        [JsonProperty("headingimg")]
        public string HeadingImg { get; set; }

        [JsonProperty("nickname")]
        public string NickName { get; set; }

        [JsonProperty("openid")]
        public string OpenId { get; set; }

        [JsonProperty("updateTimestamp")]
        public int UpdateTimestamp { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("roleList")]
        public List<RoleList> RoleList { get; set; }
    }
    public class RoleList { 
        
    }
}
