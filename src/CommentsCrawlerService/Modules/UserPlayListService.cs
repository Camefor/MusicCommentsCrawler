using Camefor.Tools.NetCore;
using Camefor.Tools.NetCore.Util;
using Camefor.Tools.NetCore.Util.Web;
using CommentsCrawlerService.Config;
using CommentsCrawlerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Modules
{

    /// <summary>
    /// 获取用户歌单列表
    /// </summary>
    public class UserPlayListService
    {
        private NeteaseMusicApiUrlManage neteaseMusicApiUrlManage = new NeteaseMusicApiUrlManage();

        /// <summary>
        /// 获取用户歌单列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public PlayListOutModel GetPlayList(PlayListRequestModel req)
        {

            try
            {
                if (string.IsNullOrEmpty(req.uid))
                {
                    return null;
                }

                //执行js加密方法所需参数
                var d = req.ToJson();
                var jsResult = NeteaseMusicCoreJsService.ExecuteCoreJs(d);
                var p_arams = jsResult.Item1;
                var encSecKey = jsResult.Item2;
                var postData = new Dictionary<string, string>();
                postData.Add("params", p_arams);
                postData.Add("encSecKey", encSecKey);
                var res = HttpMethods.Post(neteaseMusicApiUrlManage.PlayList, postData, GlobalStateData.cookies);
                var data = res.ToObject<PlayListOutModel>();
                return data;
            }

            catch (Exception ex)
            {
                throw new Exception("获取用户歌单列表失败", ex);
            }

        }
    }
}
