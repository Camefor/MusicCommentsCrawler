using Camefor.Tools.NetCore.Util;
using CommentsCrawlerService.Models;
using CommentsCrawlerService.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Config
{

    /// <summary>
    /// 维护全局状态数据
    /// </summary>
    public static class GlobalStateData
    {

        public static Dictionary<string, string> cookies
        {
            get
            {
                Dictionary<string, string> cookies = new Dictionary<string, string>();
                cookies.Add("__csrf", "");
                cookies.Add("MUSIC_U", "");
                cookies.Add("NMTID", "");
                return cookies;
            }
        }

        public static string uid { get; set; }

        //public static UserLoginOutModel LoginStateModel { get; set; }

        //添加需要的数据

        //public static bool IsLogin
        //{
        //    get
        //    {
        //        return !string.IsNullOrEmpty(uid);
        //    }
        //}

        ///// <summary>
        ///// 检查登陆 未登陆自动登陆
        ///// </summary>
        //public static void CheckLogin()
        //{
        //    try
        //    {
        //        if (!IsLogin)
        //        {
        //            //未登录 重新登陆
        //            UserLoginService userLoginService = new UserLoginService();
        //            var data = userLoginService.Login();
        //            LoginStateModel = data;
        //            uid = data.profile.userId.ToStr();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}

    }
}
