using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Models
{


    public class PlayDetailOutModel
    {
        /// <summary>
        /// 
        /// </summary>
        public long code { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public string relatedVideos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Playlist playlist { get; set; }
        /// <summary>
        /// 
        /// </summary>
    //    public string urls { get; set; }
        /// <summary>
        /// 
        /// </summary>
   //     public List<PrivilegesItem> privileges { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public string sharedPrivilege { get; set; }
        /// <summary>
        /// 
        /// </summary>
       // public string resEntrance { get; set; }
    }



    public class SubscribersItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string defaultAvatar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long province { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long authStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string followed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatarUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long accountStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long birthday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long userId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long userType { get; set; }
        /// <summary>
        /// 柆尐
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string signature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string detailDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long avatarImgId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long backgroundImgId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string backgroundUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long authority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mutual { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string expertTags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string experts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long djStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long vipType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string remarkName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long authenticationTypes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatarDetail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string anchor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatarImgIdStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string backgroundImgIdStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatarImgId_str { get; set; }
    }


    public class ArItem
    {
        /// <summary>
        /// 
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<object> tns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<object> alias { get; set; }
    }

    public class Al
    {
        /// <summary>
        /// 
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string picUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<object> tns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pic_str { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long pic { get; set; }
    }

    public class L
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

    public class TracksItem
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
        //public long pst { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long t { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public List<ArItem> ar { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public List<object> alia { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
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
        ///// <summary>
        ///// 
        ///// </summary>
        //public long dt { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string h { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string m { get; set; }
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
        ///// <summary>
        ///// 
        ///// </summary>
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
        //public string originSongSimpleData { get; set; }
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
        //public long rtype { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string rurl { get; set; }
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
        //public long mv { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long publishTime { get; set; }
    }

    public class TrackIdsItem
    {
        /// <summary>
        /// 歌曲id
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public long v { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long t { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long at { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string alg { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long uid { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string rcmdReason { get; set; }
    }

    public class Playlist
    {
        /// <summary>
        /// 
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 「灵魂枯萎」寂静是末日最后的信
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
      //  public long coverImgId { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public string coverImgUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
      //  public string coverImgId_str { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public long adType { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long userId { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long createTime { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public string opRecommend { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string highQuality { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string newImported { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long updateTime { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long trackCount { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long specialType { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long privacy { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long trackUpdateTime { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string commentThreadId { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long playCount { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long trackNumberUpdateTime { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long subscribedCount { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public long cloudTrackCount { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string ordered { get; set; }


        ///// <summary>
        ///// december 20th, 2010
        ///// </summary>
        //public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
    //    public List<string> tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
   //     public string updateFrequency { get; set; }
        /// <summary>
        /// 
        /// </summary>
    //    public long backgroundCoverId { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public string backgroundCoverUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public long titleImage { get; set; }
        /// <summary>
        /// 
        /// </summary>
    //    public string titleImageUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
  //      public string englishTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
    //   public string officialPlaylistType { get; set; }
        /// <summary>
        /// 
        /// </summary>
   //     public List<SubscribersItem> subscribers { get; set; }
        /// <summary>
        /// 
        /// </summary>
      //  public string subscribed { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public Creator creator { get; set; }
        /// <summary>
        /// 
        /// </summary>
   //     public List<TracksItem> tracks { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public string videoIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string videos { get; set; }
        /// <summary>
        /// 歌曲id 全部
        /// </summary>
        public List<TrackIdsItem> trackIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long shareCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long commentCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public string remixVideo { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string sharedUsers { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string historySharedUsers { get; set; }
    }

    public class FreeTrialPrivilege
    {
        /// <summary>
        /// 
        /// </summary>
        public string resConsumable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string userConsumable { get; set; }
    }

    public class ChargeInfoListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public long rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string chargeUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string chargeMessage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long chargeType { get; set; }
    }

    public class PrivilegesItem
    {
        /// <summary>
        /// 
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long fee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long payed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long realPayed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long st { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long pl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long dl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long sp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long cp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long subp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long maxbr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long fl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public string pc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string toast { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long flag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string paidBigBang { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string preSell { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long playMaxbr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long downloadMaxbr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rscl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public FreeTrialPrivilege freeTrialPrivilege { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ChargeInfoListItem> chargeInfoList { get; set; }
    }


}