using Camefor.Tools.NetCore.Util;
using CommentsCrawlerService.Config;
using CommentsCrawlerService.Infrastructure.Redis;
using CommentsCrawlerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Modules
{
    /// <summary>
    /// 处理评论数据，筛选目标数据                               
    /// </summary> 
    public class ProcessingMusicCommentsService
    {
        private NeteaseMusicApiUrlManage neteaseMusicApiUrlManage = new NeteaseMusicApiUrlManage();


        public void MatchCommntsData(SongsSimpleItem asongs, List<CommentsItem> acommentList, string targetUserId)
        {
            var targetList = acommentList.Where(_ => _.user.userId.ToStr() == targetUserId)?.ToList();
            if (targetList?.Count == 0)
            {
                return;
            }
            //存在目标用户的评论
            else
            {
                foreach (var item in targetList)
                {
                    Console.WriteLine("发现了" + "\r\n" + item.content);
                }

                var tarKey = targetUserId + "targetList";
                var res = RedisHelper.Get(tarKey);
                var listInCache = res.ToObject<List<TargetMusicCommentsOutModel>>() ?? new List<TargetMusicCommentsOutModel>();
                var targetMusicComments = targetList.Select(_ => new TargetMusicCommentsOutModel
                {
                    time = Time.GetTime(_.time, true),
                    content = _.content,
                    commentId = _.commentId,
                    status = _.status,
                    liked = _.liked,
                    likedCount = _.likedCount,
                    song = asongs
                }).ToList();
                listInCache.AddRange(targetMusicComments);


                if (listInCache.Count > 0)
                {
                    //只追加到缓存中 非覆盖
                    RedisHelper.Set(tarKey, listInCache);
                    //缓存时长
                    RedisHelper.SetExpire(tarKey, DateTime.Now.AddHours(1));
                }
            }

        }

    }
}
