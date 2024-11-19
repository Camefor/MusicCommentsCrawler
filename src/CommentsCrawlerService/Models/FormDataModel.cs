using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsCrawlerService.Models
{

    /// <summary>
    /// 请求网易云音乐官方api 加密参数
    /// </summary>
    public class FormDataModel
    {

        /// <summary>
        /// 
        /// </summary>
        public string param { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string encSecKey { get; set; }
    }
}
