using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Config
{
    /// <summary>
    /// 统一维护 api 地址
    /// </summary>
    public class NeteaseMusicApiUrlManage
    {

        /// <summary>
        /// 获取用户歌单列表api 网易云音乐官方api
        /// </summary>
        public string PlayList
        {
            get
            {
                return "https://music.163.com/weapi/user/playlist?csrf_token=";
            }
        }


        /// <summary>
        /// 获取用户歌单详情 第三方封装api
        /// </summary>
        public string PlayDetail
        {
            get
            {
                return "xxx";
            }
        }


        /// <summary>
        /// 获取歌曲评论api 官方
        /// </summary>
        public string MusicComments
        {
            get
            {
                return "https://music.163.com/weapi/comment/resource/comments/get?csrf_token=";
            }
        }

        /// <summary>
        /// 获取歌曲详情 api 第三方
        /// </summary>
        public string MusicDetail
        {
            get
            {
                return "xxxx";
            }
        }
    }
}
