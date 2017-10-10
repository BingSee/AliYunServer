using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AliYunSms.Base;
using Aliyun.Acs.Dysmsapi.Model.V20170525;
using AliYunSms.Core;

namespace AliYunSms
{
    public class AliYunSmsService : IAliYunSmsService
    {
        public AliYunSmsResponse SendSms(string[] phoneNumbers, string templateParam, string templateCode)
        {
            SendSmsRequest request = new SendSmsRequest();
            request.PhoneNumbers = string.Join(",", phoneNumbers);
            request.SignName = Config.signName;
            request.TemplateCode = templateCode;
            request.TemplateParam = templateParam;
            return Request.SMSRequest(request);
        }

        public AliYunSmsResponse SendSms(string phoneNumber, string templateParam, string templateCode)
        {
            SendSmsRequest request = new SendSmsRequest();
            request.PhoneNumbers = phoneNumber;
            request.SignName = Config.signName;
            request.TemplateCode = templateCode;
            request.TemplateParam = templateParam;
            return Request.SMSRequest(request);
        }
    }
}
