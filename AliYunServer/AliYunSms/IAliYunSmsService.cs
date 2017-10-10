using AliYunSms.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliYunSms
{
    public interface IAliYunSmsService
    {
        /// <summary>
        /// 阿里云短信发送给多个用户
        /// </summary>
        /// <param name="phoneNumbers">需要发送的短信号码数组,批量上限为20个手机号码</param>
        /// <param name="templateParam">
        ///     发送短信的模板内容，需要JSON格式
        ///     [如果json中带有换行符，请参照JSON协议换行符的要求]
        ///     如模板内容为"亲爱的${name},您的验证码为${code}"时,此处的值为templateParam = "{\"name\":\"Tom\", \"code\":\"123\"}";
        /// </param>
        /// <param name="templateCode">短信模板代码</param>
        /// <returns></returns>
        AliYunSmsResponse SendSms(string[] phoneNumbers, string templateParam, string templateCode);

        /// <summary>
        /// 阿里云短信发送给单个用户
        /// </summary>
        /// <param name="phoneNumber">单个手机号码</param>
        /// <param name="templateParam">
        ///     发送短信的模板内容，需要JSON格式
        ///     [如果json中带有换行符，请参照JSON协议换行符的要求]
        ///     如模板内容为"亲爱的${name},您的验证码为${code}"时,此处的值为templateParam = "{\"name\":\"Tom\", \"code\":\"123\"}";</param>
        /// <param name="templateCode">短信模板代码</param>
        /// <returns></returns>
        AliYunSmsResponse SendSms(string phoneNumber, string templateParam, string templateCode);
    }
}
