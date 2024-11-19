using Camefor.Tools.NetCore.Util;
using CommentsCrawlerService.Modules;
using System;
using Xunit;
using System.Linq;

namespace CommentsCrawlerService.UnitTest
{
    public class UserPlayListServiceTest
    {

        [Fact]
        public void ShouldContainsSpecialPlay()
        {
            UserPlayListService playListService = new UserPlayListService();
            var req = new Models.PlayListRequestModel { uid = "346539201" };
            var result = playListService.GetPlayList(req);
            var a = result.playlist[0].creator.userId.ToString() == req.uid;
            Assert.True(a);
            var b = result.playlist.FirstOrDefault(_ => _.name == "lizhi") is not null;
            Assert.True(b);
        }
    }
}
