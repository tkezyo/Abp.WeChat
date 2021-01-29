using EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Request;
using EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Response;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast
{
    public class BroadcastService : CommonService
    {
        protected const string CreateRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/create?";
        protected const string GetLiveInfoBusinessUrl = "https://api.weixin.qq.com/wxa/business/getliveinfo?";
        protected const string AddGoodsRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/addgoods";
        protected const string DeleteRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/deleteroom";
        protected const string EditRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/editroom?";
        protected const string GetPushRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/getpushurl";
        protected const string GetSharedCodeRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/getsharedcode?";
        protected const string AddAssistantRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/addassistant?";
        protected const string ModifyAssistantRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/modifyassistant?";
        protected const string RemoveAssistantRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/removeassistant?";
        protected const string GetAssistantlistRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/getassistantlist?";
        protected const string AddSubanChorRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/addsubanchor?";
        protected const string ModifySubanChorRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/modifysubanchor?";
        protected const string DeleteSubanChorRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/deletesubanchor?";
        protected const string GetSubanChorRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/getsubanchor?";
        protected const string UpdateFeedPublicRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/updatefeedpublic?";
        protected const string UpdateReplayRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/updatereplay?";
        protected const string UpdateKfRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/updatekf?";
        protected const string UpdateCommentRoomUrl = "https://api.weixin.qq.com/wxaapi/broadcast/room/updatecomment?";
        protected const string OnSaleGoodsUrl = "https://api.weixin.qq.com/wxaapi/broadcast/goods/onsale?";
        protected const string DeleteInRoomGoodsUrl = "https://api.weixin.qq.com/wxaapi/broadcast/goods/deleteInRoom?";
        protected const string PushGoodsUrl = "https://api.weixin.qq.com/wxaapi/broadcast/goods/push?";
        protected const string SortGoodsUrl = "https://api.weixin.qq.com/wxaapi/broadcast/goods/sort?";
        protected const string GetVideoGoodsUrl = "https://api.weixin.qq.com/wxaapi/broadcast/goods/getVideo?";
        protected const string AddGoodsUrl = "https://api.weixin.qq.com/wxaapi/broadcast/goods/add?";
        protected const string ResetauditGoodsUrl = "https://api.weixin.qq.com/wxaapi/broadcast/goods/resetaudit?";
        protected const string AuditGoodsUrl = "https://api.weixin.qq.com/wxaapi/broadcast/goods/audit?";
        protected const string DeleteGoodsUrl = "https://api.weixin.qq.com/wxaapi/broadcast/goods/delete?";
        protected const string UpdateGoodsUrl = "https://api.weixin.qq.com/wxaapi/broadcast/goods/update?";
        protected const string GetGoodsWareHouseUrl = "https://api.weixin.qq.com/wxa/business/getgoodswarehouse?";
        protected const string GetApprovedUrl = "https://api.weixin.qq.com/wxaapi/broadcast/goods/getapproved?";

        protected const string AddRoleUrl = "https://api.weixin.qq.com/wxaapi/broadcast/role/addrole?";

        protected const string DeleteRoleUrl = "https://api.weixin.qq.com/wxaapi/broadcast/role/deleterole?";
        protected const string GetRoleListUrl = "https://api.weixin.qq.com/wxaapi/broadcast/role/getrolelist?";


        public Task<CreateRoomResponse> CreateRoomAsync(CreateRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<CreateRoomResponse>(CreateRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<GetLiveInfoBusinessResponse> GetLiveInfoBusinessAsync(GetLiveInfoBusinessRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<GetLiveInfoBusinessResponse>(GetLiveInfoBusinessUrl,
              HttpMethod.Post,
              request);
        }


        public Task<GetLivePlayBackResponse> GetLivePlayBackAsync(GetLivePlayBackRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<GetLivePlayBackResponse>(GetLiveInfoBusinessUrl,
              HttpMethod.Post,
              request);
        }

        public Task<AddGoodsRoomResponse> AddGoodsRoom(AddGoodsRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<AddGoodsRoomResponse>(AddGoodsRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<DeleteRoomResponse> DeleteRoomAsync(DeleteRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<DeleteRoomResponse>(DeleteRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<EditRoomResponse> EditRoomAsync(EditRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<EditRoomResponse>(EditRoomUrl,
              HttpMethod.Post,
              request);
        }


        public Task<GetPushRoomResponse> GetPushRoomAsync(GetPushRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<GetPushRoomResponse>(GetPushRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<GetSharedCodeRoomResponse> GetSharedCodeRoomAsync(GetSharedCodeRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<GetSharedCodeRoomResponse>(GetSharedCodeRoomUrl,
              HttpMethod.Post,
              request);
        }


        public Task<AddAssistantRoomResponse> AddAssistantRoomAsync(AddAssistantRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<AddAssistantRoomResponse>(AddAssistantRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<ModifyAssistantRoomResponse> ModifyAssistantRoomAsync(ModifyAssistantRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<ModifyAssistantRoomResponse>(ModifyAssistantRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<RemoveAssistantResponse> RemoveAssistantAsync(RemoveAssistantRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<RemoveAssistantResponse>(ModifyAssistantRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<GetAssistantlistResponse> GetAssistantlistAsync(GetAssistantlistRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<GetAssistantlistResponse>(GetAssistantlistRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<AddSubanChorRoomResponse> AddSubanChorRoomAsync(AddSubanChorRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<AddSubanChorRoomResponse>(AddSubanChorRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<ModifySubanChorRoomResponse> ModifySubanChorRoomAsync(ModifySubanChorRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<ModifySubanChorRoomResponse>(ModifySubanChorRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<DeleteSubanChorResponse> DeleteSubanChorAsync(DeleteSubanChorRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<DeleteSubanChorResponse>(DeleteSubanChorRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<GetSubanChorRoomResponse> GetSubanChorRoomAsync(GetSubanChorRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<GetSubanChorRoomResponse>(GetSubanChorRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<UpdateFeedPublicRoomResponse> UpdateFeedPublicRoomAsync(UpdateFeedPublicRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<UpdateFeedPublicRoomResponse>(UpdateFeedPublicRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<UpdateReplayRoomResponse> UpdateReplayRoomAsync(UpdateReplayRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<UpdateReplayRoomResponse>(UpdateReplayRoomUrl,
              HttpMethod.Post,
              request);
        }
        public Task<UpdateKfRoomResponse> UpdateKfRoomAsync(UpdateKfRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<UpdateKfRoomResponse>(UpdateKfRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<UpdateCommentRoomResponse> UpdateCommentRoomAsync(UpdateCommentRoomRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<UpdateCommentRoomResponse>(UpdateCommentRoomUrl,
              HttpMethod.Post,
              request);
        }

        public Task<OnSaleGoodsResponse> OnSaleGoodsAsync(OnSaleGoodsRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<OnSaleGoodsResponse>(OnSaleGoodsUrl,
              HttpMethod.Post,
              request);
        }

        public Task<DeleteInRoomGoodsResponse> DeleteInRoomGoodsAsync(DeleteInRoomGoodsRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<DeleteInRoomGoodsResponse>(DeleteInRoomGoodsUrl,
              HttpMethod.Post,
              request);
        }

        public Task<PushGoodsResponse> PushGoodsAsync(PushGoodsRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<PushGoodsResponse>(PushGoodsUrl,
              HttpMethod.Post,
              request);
        }

        public Task<SortGoodsResponse> SortGoodsAsync(SortGoodsRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<SortGoodsResponse>(SortGoodsUrl,
              HttpMethod.Post,
              request);
        }

        public Task<GetVideoGoodsResponse> GetVideoGoodsAsync(GetVideoGoodsRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<GetVideoGoodsResponse>(GetVideoGoodsUrl,
              HttpMethod.Post,
              request);
        }

        public Task<AddGoodsResponse> AddGoodsAsync(AddGoodsRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<AddGoodsResponse>(AddGoodsUrl,
              HttpMethod.Post,
              request);
        }

        public Task<DeleteInRoomGoodsResponse> ResetauditGoodsAsync(ResetauditGoodsResquest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<DeleteInRoomGoodsResponse>(ResetauditGoodsUrl,
              HttpMethod.Post,
              request);
        }

        public Task<AuditGoodsResponse> AuditGoodsAsync(AuditGoodsRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<AuditGoodsResponse>(AuditGoodsUrl,
              HttpMethod.Post,
              request);
        }

        public Task<DeleteInRoomGoodsResponse> DeleteGoodsAsync(DeleteGoodsRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<DeleteInRoomGoodsResponse>(DeleteGoodsUrl,
              HttpMethod.Post,
              request);
        }

        public Task<DeleteInRoomGoodsResponse> DeleteGoodsAsync(UpdateGoodsRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<DeleteInRoomGoodsResponse>(UpdateGoodsUrl,
              HttpMethod.Post,
              request);
        }
        public Task<GetGoodsWareHouseResponse> GetGoodsWareHouseAsync(GetGoodsWareHouseRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<GetGoodsWareHouseResponse>(GetGoodsWareHouseUrl,
              HttpMethod.Post,
              request);
        }

        public Task<DeleteInRoomGoodsResponse> AddRoleAsync(AddRoleRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<DeleteInRoomGoodsResponse>(AddRoleUrl,
              HttpMethod.Post,
              request);
        }

        public Task<DeleteInRoomGoodsResponse> DeleteRoleAsync(DeleteRoleRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<DeleteInRoomGoodsResponse>(DeleteRoleUrl,
              HttpMethod.Post,
              request);
        }

        public Task<GetRoleListResponse> GetRoleListAsync(GetRoleListRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<GetRoleListResponse>(GetRoleListUrl,
              HttpMethod.Post,
              request);
        }

        public Task<GetApprovedResponse> vAsync(GetAssistantlistRequest request)
        {

            return WeChatMiniProgramApiRequester.RequestAsync<GetApprovedResponse>(GetApprovedUrl,
              HttpMethod.Post,
              request);
        }
    }
}





