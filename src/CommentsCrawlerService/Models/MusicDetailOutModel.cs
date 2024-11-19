using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Models
{
    /// <summary>
    /// 歌曲详情数据
    /// </summary>
    public class MusicDetailOutModel
    {
        /// <summary>
        /// 
        /// </summary>
        public List<SongsItem> songs { get; set; }
        /// <summary>
        /// 
        /// </summary>
       // public List<PrivilegesItem> privileges { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long code { get; set; }
    }



    public class H
    {
        /// <summary>
        /// 
        /// </summary>
        public long br { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long fid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long vd { get; set; }
    }

    public class M
    {
        /// <summary>
        /// 
        /// </summary>
        public long br { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long fid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long vd { get; set; }
    }


    public class ArtistsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
    }

    public class AlbumMeta
    {
        /// <summary>
        /// 
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
    }

    public class OriginSongSimpleData
    {
        /// <summary>
        /// 
        /// </summary>
        public long songId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ArtistsItem> artists { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public AlbumMeta albumMeta { get; set; }
    }

    public class SongsSimpleItem
    {
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long id { get; set; }
    }

    public class SongsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long pst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long t { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public List<ArItem> ar { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public List<string> alia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public long pop { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long st { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string rt { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long fee { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long v { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string crbt { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string cf { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public Al al { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public long dt { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public H h { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public M m { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public L l { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string a { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string cd { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long no { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string rtUrl { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long ftype { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public List<string> rtUrls { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long djId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public long copyright { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long s_id { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long mark { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long originCoverType { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public OriginSongSimpleData originSongSimpleData { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string tagPicList { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string resourceState { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long version { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string songJumpInfo { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long single { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string noCopyrightRcmd { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long mst { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long cp { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long rtype { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string rurl { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long mv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long publishTime { get; set; }
    }
}
