using EasyAbp.Abp.WeChat.Official.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.Official.Services.Media.Request
{
    public class UploadMediaRequest : OfficialCommonRequest
    {
        public const string Image = "image";
        public const string Voice = "voice";
        public const string Video = "video";
        public const string Thumb = "thumb";
        [JsonProperty("type")]
        public string Type { get; set; }
        public UploadMediaRequest(string type)
        {
            Type = type;
        }
    }

    public class UploadVideoRequest
    {
        /// <summary>
        /// 视频素材的标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 视频素材的描述
        /// </summary>
        public string Introduction { get; set; }
    }
}
