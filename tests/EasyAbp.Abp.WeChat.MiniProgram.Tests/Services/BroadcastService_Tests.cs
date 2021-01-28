using EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EasyAbp.Abp.WeChat.MiniProgram.Tests.Services
{
    public class BroadcastService_Tests : AbpWeChatMiniProgramTestBase
    {
        private readonly BroadcastService _aCodeService;

        public BroadcastService_Tests()
        {
            _aCodeService = GetRequiredService<BroadcastService>();
        }

        [Fact]
        public async Task Should_Get_Unlimited_ACode()
        {
            var result = await _aCodeService.GetAssistantlistAsync(new MiniProgram.Services.Broadcast.Request.GetAssistantlistRequest { RoomId = 11 });

            result.ShouldNotBeNull();
            result.ErrorMessage.ShouldBeNull();
            result.ErrorCode.ShouldBe(0);
        }
    }
}
