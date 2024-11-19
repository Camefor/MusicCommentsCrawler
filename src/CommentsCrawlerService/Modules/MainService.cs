using Camefor.Tools.NetCore.Util;
using CommentsCrawlerService.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Modules
{
    /// <summary>
    /// 业务入口
    /// </summary> 
    public class MainService
    {

        private readonly UserPlayListService _userPlayListService = new UserPlayListService();
        private readonly UserPlayDetailService _userPlayDetailService = new UserPlayDetailService();
        private readonly MusicCommentsService _musicCommentsService = new MusicCommentsService();
        private readonly ProcessingMusicCommentsService _processingMusicCommentsService = new ProcessingMusicCommentsService();
        private readonly MusicDetailService _musicDetailService = new MusicDetailService();

        /// <summary>
        /// 要查询的用户id
        /// </summary>
        public string _uid { get; set; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="atargetUserId">要查询的用户id</param>
        public MainService(string atargetUserId)
        {
            _uid = atargetUserId;
        }


        public async Task Main()
        {
            var req = new Models.PlayListRequestModel { uid = _uid };

            Console.WriteLine("正在获取用户歌单列表数据……");
            var allPlayList = _userPlayListService.GetPlayList(req);

            //只获取 用户 “喜欢的音乐” 歌单

            if (allPlayList?.code == 200)
            {
                Console.WriteLine($"获取用户歌单列表成功，共有 {allPlayList.playlist?.Count} 个歌单");

                allPlayList.playlist = allPlayList.playlist.Where(c => c.name.Contains("喜欢的音乐")).ToList();

                //一个用户的所有歌单 
                foreach (var play in allPlayList.playlist)
                {
                    Console.WriteLine($"正在获取用户 {play.name} 歌单详情数据……");
                    //一个歌单里面所有的歌曲id  
                    var playDetailList = _userPlayDetailService.GetPlayDetail(play.id.ToStr());

                    if (playDetailList.code == 200)
                    {
                        Console.WriteLine($"获取歌单中歌曲完成 共 {playDetailList.playlist.trackIds.Count} 首歌曲");

                        foreach (var trackId in playDetailList.playlist.trackIds)
                        {
                            //得到评论数据 且匹配目标数据
                            await _musicCommentsService.GetComments(trackId.id.ToStr(), _uid);
                        }
                    }

                }
            }
            else
            {
                Console.WriteLine(" 获取用户歌单列表数据失败！");
            }


        }

    }
}
