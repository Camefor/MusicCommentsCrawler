using CommentsCrawlerService.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CommentsCrawlerService.UnitTest
{
    public class UserPlayDetailServiceTest
    {
        [Fact]
        public void TryGetData()
        {
            UserPlayDetailService playDetailService = new UserPlayDetailService();
            var data = playDetailService.GetPlayDetail("6915994263");
            Assert.NotNull(data);
            //var result = data.playlist.tracks.FirstOrDefault(_ => _.name == "米店") is not null;
            //Assert.True(result);
        }
    }
}
