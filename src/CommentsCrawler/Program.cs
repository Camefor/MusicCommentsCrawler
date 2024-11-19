using Camefor.Tools.NetCore;
using Camefor.Tools.NetCore.Util;
using Camefor.Tools.NetCore.Util.Web;
using CommentsCrawlerService.Config;
using CommentsCrawlerService.Infrastructure.Redis;
using CommentsCrawlerService.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommentsCrawler
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //using (PerformanceTester performanceTester = new PerformanceTester())
            //{
            //    Console.WriteLine("耗时： " + performanceTester.Result.TotalMilliseconds + "毫秒");
            //}

            try
            {
                Console.Write("输入网易云音乐用户id:");
                var userId = Console.ReadLine();
                if (string.IsNullOrEmpty(userId))
                {
                    Console.WriteLine("无效id");
                    return;
                }
                MainService mainService = new MainService(userId.Trim());
                await mainService.Main();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("程序结束……");
            Console.ReadKey();

        }

    }
}
