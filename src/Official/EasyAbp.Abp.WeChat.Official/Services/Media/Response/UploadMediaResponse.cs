using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.Official.Services.Media
{
    public class UploadMediaResponse
    {
        public string Type { get; set; }
        public string Media_id { get; set; }
        public long Created_at { get; set; }
    }
}
