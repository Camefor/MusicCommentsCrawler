using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Models
{
    /// <summary>
    /// 描   述  ：                          
    /// 版   本  ： V1.0.0                            
    /// 创 建 人 ： rhyswang                                  
    /// 日    期 ：                         
    /// 创 建 人 ：                                   
    /// 创建时间 ：                                  
    /// 修 改 人 ：                                   
    /// 修改时间 ：                                   
    /// 修改描述 ：                                   
    /// </summary> 
    public class TargetMusicCommentsOutModel
    {

        //    "commentId": 5425446678,
        //"content": "再测试",
        //"status": 0,
        //"time": 1632623082077,
        //"likedCount": 1,
        //"liked": "false",

        public long commentId { get; set; }
        public string content { get; set; }
        public long status { get; set; }
        public DateTime time { get; set; }
        //public long time { get; set; }
        public long likedCount { get; set; }
        public string liked { get; set; }

        /// <summary>
        /// 该评论所属的歌曲对象数据
        /// </summary>
        public SongsSimpleItem song { get; set; }

    }
}
