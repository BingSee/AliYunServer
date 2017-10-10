using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliYunSms.Base
{
    public class AliYunSmsResponse
    {
        /// <summary>
        /// 是否发送成功 
        /// true : 发送成功
        /// false: 发送失败
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// 发送失败，返回错误信息
        /// </summary>
        public string ErrorMsg { get; set; }
    }
}
