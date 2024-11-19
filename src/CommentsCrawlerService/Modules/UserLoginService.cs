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
    /// 模拟用户登陆
    /// </summary>
    public class UserLoginService
    {
        /// <summary>
        /// 
        /// </summary>
        public UserLoginOutModel Login()
        {
            var url = "http://camefor.top:3000/login/cellphone?phone=xxxxx&password=xxxxxxx";
            var res = HttpMethods.Get(url);
            var data = res.ToObject<UserLoginOutModel>();
            return data;
        }
    }
}
