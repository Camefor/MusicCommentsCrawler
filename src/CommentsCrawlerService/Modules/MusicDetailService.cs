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
    /// 获取歌曲详情
    /// </summary>
    public class MusicDetailService
    {
        private NeteaseMusicApiUrlManage neteaseMusicApiUrlManage = new NeteaseMusicApiUrlManage();

        /// <summary>
        /// 获取歌曲名称
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetMusicName(long id)
        {
            var music = GetMusicDetail(id);
            if (music?.songs == null) return null;
            if (music?.songs?.Count == 0) return null;
            return music.songs.ElementAt(0).name;
        }

        /// <summary>
        /// 获取歌曲详情简单数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SongsSimpleItem GetMusicSimpleItem(long id)
        {
            var music = GetMusicDetail(id);
            if (music?.songs == null) return null;
            if (music?.songs?.Count == 0) return null;
            var item = music.songs.ElementAt(0);
            return new SongsSimpleItem { id = item.id, name = item.name };
        }

        /// <summary>
        /// 歌曲详情数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MusicDetailOutModel GetMusicDetail(long id)
        {
            string url = neteaseMusicApiUrlManage.MusicDetail + id.ToString();
            var res = HttpMethods.Get(url);
            return res.ToObject<MusicDetailOutModel>();
        }


        /// <summary>
        /// 多个歌曲  详情数据
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public MusicDetailOutModel GetMusicDetails(List<long> ids)
        {
            var idsStr = string.Join(',', ids);
            string url = neteaseMusicApiUrlManage.MusicDetail + idsStr;
            var res = HttpMethods.Get(url);
            return res.ToObject<MusicDetailOutModel>();
        }

    }
}
