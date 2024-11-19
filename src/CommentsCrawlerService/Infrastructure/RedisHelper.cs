using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;
using System.Configuration;
using Camefor.Tools.NetCore.Util;


namespace CommentsCrawlerService.Infrastructure.Redis
{
    public static partial class RedisHelper
    {
        //private static readonly string ConnectString = ConfigurationManager.ConnectionStrings["RedisConnection"]?.ToString();       
        private static readonly string ConnectString = "127.0.0.1";
        private static Lazy<ConnectionMultiplexer> _lazyConnection;
        private static readonly Object MultiplexerLock = new Object();
        private static readonly IDatabase Cache;

        static RedisHelper()
        {
            var conn = CreateManager.Value;
            Cache = conn.GetDatabase(); //获取实例
        }

        private static Lazy<ConnectionMultiplexer> GetManager(string connectionString = null)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = GetDefaultConnectionString();
            }

            return new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(connectionString));
        }

        private static Lazy<ConnectionMultiplexer> CreateManager
        {
            get
            {
                if (_lazyConnection == null)
                {
                    lock (MultiplexerLock)
                    {
                        if (_lazyConnection != null) return _lazyConnection;

                        _lazyConnection = GetManager();
                        return _lazyConnection;
                    }
                }

                return _lazyConnection;
            }
        }

        public static string GetDefaultConnectionString()
        {
            return ConnectString;
        }

        public const string DefaultOrder = "desc";

        #region Keys
        public static bool KeyExists(string key)
        {
            var bResult = Cache.KeyExists(key);
            return bResult;
        }

        public static bool SetExpire(string key, DateTime datetime)
        {
            return Cache.KeyExpire(key, datetime);
        }

        public static bool SetExpire(string key, int timeout = 0)
        {
            return Cache.KeyExpire(key, DateTime.Now.AddSeconds(timeout));
        }

        public static bool Set<T>(string key, T t, int timeout = 0)
        {
            var value = t.ToJson();
            bool bResult = Cache.StringSet(key, value);
            if (timeout > 0)
            {
                Cache.KeyExpire(key, DateTime.Now.AddSeconds(timeout));
            }
            return bResult;
        }

        public static bool KeyDelete(string key)
        {
            return Cache.KeyDelete(key);
        }

        public static bool KeyRename(string oldKey, string newKey)
        {
            return Cache.KeyRename(oldKey, newKey);
        }
        #endregion

        #region Hashes
        public static bool IsExist(string hashId, string key)
        {
            return Cache.HashExists(hashId, key);
        }

        public static bool SetHash<T>(string hashId, string key, T t)
        {
            var value = t.ToJson();
            return Cache.HashSet(hashId, key, value);
        }

        public static bool Remove(string hashId, string key)
        {
            return Cache.HashDelete(hashId, key);
        }

        public static long StringIncrement(string hashId, string key, long value = 1)
        {
            return Cache.HashIncrement(hashId, key, value);
        }

        public static T Get<T>(string hashId, string key)
        {
            string value = Cache.HashGet(hashId, key);
            return value.ToObject<T>();
        }

        public static long GetHashCount(string hashId)
        {
            var length = Cache.HashLength(hashId);
            return length;
        }

        public static string Get(string hashId, string key)
        {
            string value = Cache.HashGet(hashId, key).ToString();
            return value;
        }

        //public static List<T> GetAll<T>(string hashId)
        //{
        //    var result = new List<T>();
        //    var list = Cache.HashGetAll(hashId).ToList();
        //    if (list.Count > 0)
        //    {
        //        list.ForEach(x =>
        //        {
        //            var value = x.Value.ToObject<T>();
        //            result.Add(value);
        //        });
        //    }
        //    return result;
        //}

        //public static List<string> GetAllFields(string hashId)
        //{
        //    var result = new List<string>();
        //    var list = Cache.HashKeys(hashId).ToList();
        //    if (list.Count > 0)
        //    {
        //        list.ForEach(x =>
        //        {
        //            var value = JsonSerializer.DeserializeFromString<string>(x);
        //            result.Add(value);
        //        });
        //    }
        //    return result;
        //}

        #endregion

        #region Sorted Sets
        public static bool SortedSetItemIsExist(string setId, string item)
        {
            var value = GetItemScoreFromSortedSet(setId, item);
            if (value != null)
            {
                return true;
            }
            return false;
        }

        public static bool SortedSetAdd(string setId, string item, double score, int timeout = 0)
        {
            return Cache.SortedSetAdd(setId, item, score);
        }

        //public static List<string> GetSortedSetRangeByRank(string setId, long fromRank, long toRank, string order = DefaultOrder)
        //{
        //    var result = new List<string>();
        //    var list = Cache.SortedSetRangeByRank(setId, fromRank, toRank, order == Order.Descending.ToString().ToLower() ? Order.Descending : Order.Ascending).ToList();
        //    if (list.Any())
        //    {
        //        list.ForEach(x =>
        //        {
        //            var value = JsonSerializer.DeserializeFromString<string>(x);
        //            result.Add(value);
        //        });
        //    }
        //    return result;
        //}

        public static Dictionary<string, double> GetSortedSetRangeByRankWithScores(string setId, long fromRank, long toRank, string order = DefaultOrder)
        {
            var result = new Dictionary<string, double>();
            var list = Cache.SortedSetRangeByRankWithScores(setId, fromRank, toRank, order == Order.Descending.ToString().ToLower() ? Order.Descending : Order.Ascending).ToList();
            if (list.Any())
            {
                list.ForEach(x =>
                {
                    result.Add(x.Element, x.Score);
                });
            }
            return result;
        }

        //public static List<string> GetSortedSetRangeByValue(string setId, long minValue, long maxValue)
        //{
        //    var result = new List<string>();
        //    var list = Cache.SortedSetRangeByValue(setId, minValue, maxValue).ToList();
        //    if (list.Any())
        //    {
        //        list.ForEach(x =>
        //        {
        //            var value = JsonSerializer.DeserializeFromString<string>(x);
        //            result.Add(value);
        //        });
        //    }
        //    return result;
        //}

        public static long GetSortedSetLength(string setId)
        {
            return Cache.SortedSetLength(setId);
        }

        public static long GetSortedSetLength(string setId, double minValue, double maxValue)
        {
            return Cache.SortedSetLength(setId, minValue, maxValue);
        }

        public static long? GetItemRankFromSortedSet(string setId, string item, string order = DefaultOrder)
        {
            return Cache.SortedSetRank(setId, item, order == Order.Descending.ToString().ToLower() ? Order.Descending : Order.Ascending);
        }

        public static double? GetItemScoreFromSortedSet(string setId, string item)
        {
            return Cache.SortedSetScore(setId, item);
        }

        public static double SetSortedSetItemIncrement(string setId, string item, double score = 1)
        {
            return Cache.SortedSetIncrement(setId, item, score);
        }

        public static double SortedSetItemDecrement(string setId, string item, double score = -1)
        {
            return Cache.SortedSetDecrement(setId, item, score);
        }

        public static bool RemoveItemFromSortedSet(string setId, string item)
        {
            return Cache.SortedSetRemove(setId, item);
        }

        public static long RemoveByRankFromSortedSet(string setId, long fromRank, long toRank)
        {
            return Cache.SortedSetRemoveRangeByRank(setId, fromRank, toRank);
        }

        public static long RemoveByScoreFromSortedSet(string setId, double minValue, double maxValue)
        {
            return Cache.SortedSetRemoveRangeByScore(setId, minValue, maxValue);
        }

        public static long RemoveByLexFromSortedSet(string setId, int minValue, int maxValue)
        {
            //TODO： Don't know its meaning
            //return Cache.SortedSetRemoveRangeByValue(setId, minValue, maxValue);
            return 0;
        }
        #endregion

        #region Lists

        public static long AddList<T>(string listId, T t)
        {
            var value = t.ToJson();
            return Cache.ListLeftPush(listId, value);
        }

        //public static List<T> GetList<T>(string listId, long start = 0, long stop = -1)
        //{
        //    var result = new List<T>();
        //    var list = Cache.ListRange(listId, start, stop).ToList();
        //    if (list.Count > 0)
        //    {
        //        list.ForEach(x =>
        //        {
        //            var value = JsonSerializer.DeserializeFromString<T>(x);
        //            result.Add(value);
        //        });
        //    }
        //    return result;
        //}
        #endregion

        #region Strings

        public static string Get(string key)
        {
            string value = Cache.StringGet(key);
            return value;
        }

        public static T StringGet<T>(string key)
        {
            string value = Cache.StringGet(key);
            return value.ToObject<T>();
        }

        public static double StringIncrement(string key, double value)
        {
            return Cache.StringIncrement(key, value);
        }

        public static long StringAppend(string key, string value)
        {
            return Cache.StringAppend(value, value, CommandFlags.None);
        }
        #endregion


    }
}
