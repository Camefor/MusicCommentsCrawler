using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Camefor.Tools.NetCore.Util.Web
{
    /// <summary>
    /// 描   述  ：                          
    /// 版   本  ： V1.0.0                            
    /// 创 建 人 ： rhyswang                                  
    /// 日    期 ：                         
    /// 创 建 人 ：                                   
    /// 创建时间 ：                                  
    /// 修 改 人 ：                                   
    /// 修改时间 ：                                   
    /// 修改描述 ：                                   
    /// </summary> 
    public class HttpClientStream
    {
        private static HttpClient _httpClient = new HttpClient();
        private readonly JsonSerializerOptions _options;

        public HttpClientStream()
        {
            _httpClient.Timeout = new TimeSpan(0, 0, 30);
            _httpClient.DefaultRequestHeaders.Clear();
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<T> GetObjectWithStream<T>(string url)
        {
            using (var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
            {
                response.EnsureSuccessStatusCode();
                var stream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<T>(stream, _options);
            }
        }

        public async Task<T> PostWithStream<T>(string url, Dictionary<string, string> dict, Dictionary<string, string> cookies = null)
        {
            if (cookies != null)
            {
                if (_httpClient == null)
                {
                    _httpClient = CreateHttpClient(url, cookies);
                }
            }
            var request = new HttpRequestMessage(HttpMethod.Post, url) { Content = new FormUrlEncodedContent(dict) };
            var response = await _httpClient.SendAsync(request);
            var stream = await response.Content.ReadAsStreamAsync();
            return new StreamReader(stream).ReadToEnd().ToObject<T>();
        }



        /// <summary>
        /// 创建HttpClient
        /// </summary>
        /// <returns></returns>
        public static HttpClient CreateHttpClient(string url, IDictionary<string, string> cookies = null)
        {
            //HttpClient httpclient;
            HttpClientHandler handler = new HttpClientHandler();
            var uri = new Uri(url);
            if (cookies != null)
            {
                foreach (var key in cookies.Keys)
                {
                    string one = key + "=" + cookies[key];
                    handler.CookieContainer.SetCookies(uri, one);
                }
            }
            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                _httpClient = new HttpClient(handler);
            }
            else
            {
                _httpClient = new HttpClient(handler);
            }
            return _httpClient;
        }

    }
}
