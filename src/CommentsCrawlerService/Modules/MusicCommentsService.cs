using Camefor.Tools.NetCore.Util;
using Camefor.Tools.NetCore.Util.Log;
using Camefor.Tools.NetCore.Util.Web;
using CommentsCrawlerService.Config;
using CommentsCrawlerService.Infrastructure.Redis;
using CommentsCrawlerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Modules
{

    /// <summary>
    /// 获取歌曲评论数据
    /// </summary>
    public class MusicCommentsService
    {
        ProcessingMusicCommentsService processingMusicCommentsService = new ProcessingMusicCommentsService();
        MusicDetailService musicDetailService = new MusicDetailService();
        HttpClientStream _httpClient = new HttpClientStream();


        private MusicCommentsOutModel _data = null;

        /// <summary>
        /// 获取歌曲评论
        /// </summary>
        /// <param name="trackid">歌曲id</param>
        /// <returns></returns>
        public async Task GetComments(string trackid, string targetUserId)
        {

            try
            {
                if (string.IsNullOrEmpty(trackid))
                {
                    return;
                }

                var thisMusic = musicDetailService.GetMusicSimpleItem(trackid.ToInt());

                Console.WriteLine("\r\n");
                Console.WriteLine($"正在获取歌曲 {thisMusic.name} 的评论数据");
                Console.WriteLine("\r\n");

                var id = $"R_SO_4_{trackid.Trim()}";


                //EventLog _log = new EventLog(thisMusic.name + "_的评论数据");

                //默认先请求第一页评论
                int pageNo = 1;
                int pageSize = 40;
                int offset = 0;

                var d = new MusicCommentsRequestModel
                {
                    rid = id,
                    threadId = id,
                    pageNo = pageNo.ToStr(),
                    pageSize = pageSize.ToStr(),
                    cursor = "-1",
                    offset = offset.ToStr(),
                    orderType = "1"
                };
                var url = new NeteaseMusicApiUrlManage().MusicComments;

                string totalCountStr = string.Empty;


                //var allCommentsJsonBuilderList = new List<string>();


                //allCommentsJsonBuilderList.Add(data.data.comments.ToJson());

                //var allCommentsList = data.data.comments.Select(c => new { c.content, c.commentId }).ToList();

                _data = null;
                _data = await ExecuteRequestComments(url, d.ToJson(), targetUserId);
                processingMusicCommentsService.MatchCommntsData(thisMusic, _data.data.comments, targetUserId);

                //根据评论总数 连续翻页
                //评论总数
                var totalCount = _data.data.totalCount;


                //需要的请求次数
                var reqCount = (totalCount / pageSize) + 1;
                //已经请求 第一页数据了
                //从第二页开始
                for (int i = 0; i < reqCount; i++)
                {
                    pageNo++;
                    //offset = (pageNo - 1) * pageSize;
                    offset = 80;

                    Console.WriteLine($"正在获取第 {pageNo} 页评论数据");

                    d.offset = offset.ToStr();
                    d.pageNo = pageNo.ToStr();
                    Thread.Sleep(100);
                    _data = null;
                    _data = await ExecuteRequestComments(url, d.ToJson(), targetUserId);
                    processingMusicCommentsService.MatchCommntsData(thisMusic, _data.data.comments, targetUserId);

                    //allCommentsJsonBuilderList.Add(tempData.data.comments.ToJson());
                    //allCommentsList.AddRange(tempData.data.comments.Select(c => new { c.content, c.commentId }).ToList());
                }

                //查看评论数据完整性
                //var see = allCommentsJsonBuilderList;
                //var see = allCommentsList;
                //var seeed = see.DistinctBy(c => c.commentId).ToList();

                //return data;
            }
            catch (Exception ex)
            {
                throw new Exception("获取歌曲评论失败", ex);
            }

        }


        private async Task<MusicCommentsOutModel> ExecuteRequestComments(string aurl, string d, string targetUserId, SongsSimpleItem thisMusic = null)
        {
            try
            {
                var jsResult = NeteaseMusicCoreJsService.ExecuteCoreJs(d);
                var p_arams = jsResult.Item1;
                var encSecKey = jsResult.Item2;
                var postData = new Dictionary<string, string>
                     {
                            { "params", p_arams },
                            { "encSecKey", encSecKey }
                     };

                //var res = HttpMethods.Post(NeteaseMusicApiUrlManage.MusicComments, postData);
                //var data = res.ToObject<MusicCommentsOutModel>();

                return await _httpClient.PostWithStream<MusicCommentsOutModel>(aurl, postData);
            }
            catch (Exception ex)
            {
                throw new Exception("歌曲评论数据反序列化失败", ex);
            }
        }


        /// <summary>
        /// 歌曲评论 第三方封装api接口
        /// </summary>
        /// <param name="id"></param>
        public void GetCommentsFrom_neteasecloudmusicapi(long id)
        {


        }

    }


}
