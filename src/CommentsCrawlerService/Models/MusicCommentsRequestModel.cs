using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Models
{

    /// <summary>
    /// 获取歌曲评论需要的参数
    /// </summary>
    public class MusicCommentsRequestModel
    {
        public string rid { get; set; }
        public string threadId { get; set; }
        public string pageNo { get; set; }
        public string pageSize { get; set; }
        public string cursor { get; set; }
        public string offset { get; set; }
        public string orderType { get; set; }
    }
}
