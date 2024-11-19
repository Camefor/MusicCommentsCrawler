using Camefor.Tools.NetCore.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Config
{
    public static class DecryptCoreJsCodeString
    {


        public static string Content
        {
            get
            {
                try
                {
                    //网易云音乐接口加密参数  js代码
                    var filePath = System.AppDomain.CurrentDomain.BaseDirectory + "Config\\Core.js";
                    return DirFileHelper.ReadText(filePath);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public static string TestContent
        {
            get
            {
                try
                {
                    //网易云音乐接口加密参数  js代码
                    var filePath = System.AppDomain.CurrentDomain.BaseDirectory + "Config\\Test.js";
                    var jsCode = DirFileHelper.ReadText(filePath);
                    return jsCode;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
