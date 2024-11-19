using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Models
{

    /// <summary>
    /// 用户数据
    /// </summary>
    public class UserLoginOutModel
    {
        /// <summary>
        /// 
        /// </summary>
        public long loglongype { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Account account { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string token { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Profile profile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<BindingsItem> bindings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cookie { get; set; }
    }



    public class Account
    {
        /// <summary>
        /// 
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string userName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long whitelistAuthority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long createTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string salt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long tokenVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long ban { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long baoyueVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long donateVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long vipType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long viptypeVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string anonimousUser { get; set; }
    }

    public class Experts
    {
    }

    public class Profile
    {
        /// <summary>
        /// 
        /// </summary>
        public string detailDescription { get; set; }
        /// <summary>
        /// 起啥名字都存在
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long birthday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long avatarImgId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long vipType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long accountStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mutual { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string remarkName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long authStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Experts experts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatarUrl { get; set; }
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
        public long backgroundImgId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string expertTags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long userType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long djStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string followed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string backgroundUrl { get; set; }
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
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long userId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string signature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long authority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatarImgId_str { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long followeds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long follows { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long eventCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatarDetail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long playlistCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long playlistBeSubscribedCount { get; set; }
    }

    public class BindingsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string expired { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long expiresIn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long bindingTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tokenJsonStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long refreshTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long userId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long type { get; set; }
    }

 

}
