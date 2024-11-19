using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Models
{

    /// <summary>
    /// 请求歌单列表参数对象
    /// </summary>
    public class PlayListRequestModel
    {
        /// <summary>
        /// 用户id 必填
        /// </summary>
        public string uid { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string wordwrap { get; set; } = "7";


        /// <summary>
        ///  "0"
        /// </summary>
        public string offset { get; set; } = "0";


        /// <summary>
        /// 
        /// </summary>
        public string total { get; set; } = "true";


        /// <summary>
        ///分页 有多少歌单
        /// </summary>
        public string limit { get; set; } = "300";

        /// <summary>
        /// 
        /// </summary>
        public string csrf_token { get; set; } = "";
    }

}
