using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliYunSms.Base
{
    public class AliYunSmsParam
    {
        /// <summary>
        /// AccessKeyId
        /// </summary>
        public string AccessKeyId { get; set; }
        /// <summary>
        /// AccessKeySecret
        /// </summary>
        public string AccessKeySecret { get; set; }
        /// <summary>
        /// 短信签名
        /// </summary>
        public string SignName { get; set; }
    }
}
