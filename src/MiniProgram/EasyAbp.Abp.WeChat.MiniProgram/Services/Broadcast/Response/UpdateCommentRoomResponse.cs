using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Response
{
   public  class UpdateCommentRoomResponse : IMiniProgramResponse
    {
   

        public string ErrorMessage { get; set; }

        public int ErrorCode { get; set; }
    }
}
