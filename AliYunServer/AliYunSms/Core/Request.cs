using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Dysmsapi.Model.V20170525;
using AliYunSms.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliYunSms.Core
{
    internal class Request
    {
        internal static AliYunSmsResponse SMSRequest(SendSmsRequest request)
        {
            AliYunSmsResponse rsp = new AliYunSmsResponse();
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", Config.accessKeyId, Config.accessKeySecret);
            DefaultProfile.AddEndpoint("cn-hangzhou", "cn-hangzhou", Config.product, Config.domain);
            IAcsClient acsClient = new DefaultAcsClient(profile);
            try
            {
                SendSmsResponse sendSmsResponse = acsClient.GetAcsResponse(request);
                rsp = CheckSMSCode.CheckResponse(sendSmsResponse.Code);
            }
            catch (ServerException e)
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = e.Message;
            }
            catch (ClientException e)
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = e.Message;
            }
            return rsp;
        }
    }
}
