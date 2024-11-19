using Camefor.Tools.NetCore;
using CommentsCrawlerService.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Modules
{

    /// <summary>
    /// 封装调用 Core.js 加密接口参数
    /// </summary>
    public class NeteaseMusicCoreJsService
    {

        /// <summary>
        /// 执行core.js  https://s3.music.126.net/web/s/core.js 那个代码里面的加密参数方法
        /// </summary>
        /// <param name="d"></param>
        /// <returns>item1返回 params,item2返回 encSecKey</returns>
        public static Tuple<string, string> ExecuteCoreJs(string d)
        {

            //执行js加密方法所需参数
            var p_arams = string.Empty;
            var encSecKey = string.Empty;
            try
            {
                using (ScriptEngine engine = new ScriptEngine("jscript"))
                {
                    var parsed = engine.Parse(DecryptCoreJsCodeString.Content);
                    dynamic jsResult = parsed.CallMethod("start", d);
                    p_arams = jsResult.p_arams as string;
                    encSecKey = jsResult.encSecKey as string;
                }

                return Tuple.Create(p_arams, encSecKey);
            }
            catch (Exception ex)
            {
                throw new Exception("执行js代码失败", ex);
            }
        }
    }
}
