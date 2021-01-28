using EasyAbp.Abp.WeChat.Official.Services.Media.Request;
using EasyAbp.Abp.WeChat.Official.Services.Media.Response;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EasyAbp.Abp.WeChat.Official.Services.Media
{
    /// <summary>
    /// 素材管理 https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/New_temporary_materials.html
    /// </summary>
    public class MediaService : CommonService
    {
        protected const string UploadMediaUrl = "https://api.weixin.qq.com/cgi-bin/media/upload?";
        protected const string GetMediaUrl = "https://api.weixin.qq.com/cgi-bin/media/get?";
        protected const string UploadImgUrl = "https://api.weixin.qq.com/cgi-bin/media/uploadimg?";
        protected const string AddNewsUrl = "https://api.weixin.qq.com/cgi-bin/material/add_news?";
        protected const string AddMaterialUrl = "https://api.weixin.qq.com/cgi-bin/material/add_material?";
        protected const string GetMaterialUrl = "https://api.weixin.qq.com/cgi-bin/material/get_material?";
        protected const string DelMaterialUrl = "https://api.weixin.qq.com/cgi-bin/material/del_material?";
        protected const string UpdateNewsUrl = "https://api.weixin.qq.com/cgi-bin/material/update_news?";
        protected const string GetMaterialCountUrl = "https://api.weixin.qq.com/cgi-bin/material/get_materialcount?";
        protected const string BatchGetMaterialUrl = "https://api.weixin.qq.com/cgi-bin/material/batchget_material?";


        /// <summary>
        /// 新增临时素材
        /// </summary>
        /// <param name="type">类型，使用<see cref="UploadMediaRequest"/></param>
        /// <param name="bytes">文件</param>
        /// <param name="contentName">content名称</param>
        /// <param name="fileName">文件名称</param>
        /// <returns></returns>
        /// <remarks>
        /// 图片（image）: 10M，支持PNG\JPEG\JPG\GIF格式
        ///
        ///语音（voice）：2M，播放长度不超过60s，支持AMR\MP3格式
        ///
        ///视频（video）：10MB，支持MP4格式
        ///
        ///缩略图（thumb）：64KB，支持JPG格式
        /// </remarks>
        public Task<UploadMediaResponse> UploadMediaAsync(string type, byte[] bytes, string contentName, string fileName)
        {
            var content = new MultipartFormDataContent();
            content.Add(new ByteArrayContent(bytes), contentName, fileName);

            return WeChatOfficialApiRequester.RequestAsync<UploadMediaResponse>(UploadMediaUrl,
            HttpMethod.Post,
            new UploadMediaRequest(type), true, content);
        }
        /// <summary>
        /// 公众号可以使用本接口获取临时素材（即下载临时的多媒体文件）。
        /// </summary>
        /// <param name="mediaId"></param>
        /// <returns></returns>
        public Task<GetMediaResponse> GetMedia(string mediaId)
        {
            return WeChatOfficialApiRequester.RequestAsync<GetMediaResponse>(UploadMediaUrl,
                HttpMethod.Get,
                new GetMediaRequest() { MediaId = mediaId });
        }
        /// <summary>
        /// 新增永久图文素材
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<AddNewsResponse> AddNews(AddNewsRequest request)
        {
            return WeChatOfficialApiRequester.RequestAsync<AddNewsResponse>(UploadMediaUrl,
              HttpMethod.Post,
              request);
        }

        /// <summary>
        /// 上传图文消息内的图片获取URL
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="contentName"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public Task<UploadImageResponse> UploadImageAsync(byte[] bytes, string contentName, string fileName)
        {
            var content = new MultipartFormDataContent();
            content.Add(new ByteArrayContent(bytes), contentName, fileName);

            return WeChatOfficialApiRequester.RequestAsync<UploadImageResponse>(UploadImgUrl,
            HttpMethod.Post,
            null, true, content);
        }
        public Task<DelMediaResponse> DelMediaAsync(GetMediaRequest request)
        {
            return WeChatOfficialApiRequester.RequestAsync<DelMediaResponse>(DelMaterialUrl,
              HttpMethod.Post,
              request);
        }
        public Task<DelMediaResponse> UpdateNewsAsync(UpdateNewsRequest request)
        {
            return WeChatOfficialApiRequester.RequestAsync<DelMediaResponse>(UpdateNewsUrl,
              HttpMethod.Post,
              request);
        }
        public Task<GetMaterialCountResponse> GetMaterialCountAsync()
        {
            return WeChatOfficialApiRequester.RequestAsync<GetMaterialCountResponse>(GetMaterialCountUrl,
              HttpMethod.Post
              );
        }
        public Task<BatchGetMaterialResponse> BatchGetMaterialAsync(BatchgetMaterialRequest request)
        {
            return WeChatOfficialApiRequester.RequestAsync<BatchGetMaterialResponse>(BatchGetMaterialUrl,
              HttpMethod.Post,
              request);
        }


    }
}
