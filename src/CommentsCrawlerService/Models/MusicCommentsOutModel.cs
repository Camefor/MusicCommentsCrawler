using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Models
{

    /// <summary>
    /// 歌曲评论 数据模型类
    /// </summary>
    public class MusicCommentsOutModel
    {
        /// <summary>
        /// 
        /// </summary>
        public long code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }
    }

    public class Associator
    {
        /// <summary>
        /// 
        /// </summary>
        public long vipCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rights { get; set; }
    }

    public class VipRights
    {
        /// <summary>
        /// 
        /// </summary>
        public Associator associator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public string musicPackage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long redVipAnnualCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long redVipLevel { get; set; }
    }

    public class User
    {
        /// <summary>
        /// 
        /// </summary>
        //public string avatarDetail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public string commonIdentity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public string locationInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public string liveInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public string followed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public VipRights vipRights { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public string relationTag { get; set; }
        /// <summary>
        /// 
        /// </summary>
    //    public long anonym { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long userId { get; set; }
        /// <summary>
        /// 
        /// </summary>
      //  public long userType { get; set; }
        /// <summary>
        /// 
        /// </summary>
       // public string nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
      //  public string avatarUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
       // public long authStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public string expertTags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public string experts { get; set; }

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
        public string isHug { get; set; }
    }

    public class ShowFloorComment
    {
        /// <summary>
        /// 
        /// </summary>
        public long replyCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string comments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string showReplyCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string topCommentIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string target { get; set; }
    }

    public class Decoration
    {
        /// <summary>
        /// 
        /// </summary>
        public long repliedByAuthorCount { get; set; }
    }

    public class Tag
    {
        /// <summary>
        /// 
        /// </summary>
        public string datas { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string relatedCommentIds { get; set; }
    }

    public class ExtInfo
    {
    }

    public class CommentsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public User user { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public string beReplied { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long commentId { get; set; }
        /// <summary>
        /// 挺好的一首歌最后左耳的叮咚老是让我想到奥特曼没能量[哀伤]
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long likedCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string liked { get; set; }
        /// <summary>
        /// 
        /// </summary>
       // public string expressionUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public long parentCommentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
      //  public string repliedMark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public string pendantData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public ShowFloorComment showFloorComment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public Decoration decoration { get; set; }
        /// <summary>
        /// 
        /// </summary>
       // public long commentLocationType { get; set; }
        /// <summary>
        /// 
        /// </summary>
      //  public string args { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public Tag tag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public string source { get; set; }
        /// <summary>
        /// 
        /// </summary>
      //  public ExtInfo extInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
      //  public string commentVideoVO { get; set; }
    }

    public class SortTypeListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public long sortType { get; set; }
        /// <summary>
        /// 按推荐排序
        /// </summary>
        public string sortTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string target { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public List<CommentsItem> comments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public string currentComment { get; set; }
        /// <summary>
        /// 评论总数
        /// </summary>
        public long totalCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
       // public string hasMore { get; set; }
        /// <summary>
        /// 
        /// </summary>
       // public string cursor { get; set; }
        /// <summary>
        /// 
        /// </summary>
      //  public long sortType { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public List<SortTypeListItem> sortTypeList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        // string orderType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public string hotComments { get; set; }
    }


}
