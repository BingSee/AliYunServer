using AliYunSms.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliYunSms.Core
{
    internal class CheckSMSCode
    {
        internal static AliYunSmsResponse CheckResponse(string code)
        {
            AliYunSmsResponse rsp = new AliYunSmsResponse();
            if (code != null && code.Equals("OK"))
            {
                rsp.IsSuccess = true;
            }
            else if (code.Equals("isp.RAM_PERMISSION_DENY"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "RAM权限DENY";
            }
            else if (code.Equals("isv.OUT_OF_SERVICE"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "业务停机";
            }
            else if (code.Equals("isv.PRODUCT_UN_SUBSCRIPT"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "未开通云通信产品的阿里云客户";
            }
            else if (code.Equals("isv.PRODUCT_UNSUBSCRIBE"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "产品未开通";
            }
            else if (code.Equals("isv.ACCOUNT_NOT_EXISTS"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "账户不存在";
            }
            else if (code.Equals("isv.ACCOUNT_ABNORMAL"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "账户异常";
            }
            else if (code.Equals("isv.SMS_TEMPLATE_ILLEGAL"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "短信模板不合法";
            }
            else if (code.Equals("isv.SMS_SIGNATURE_ILLEGAL"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "短信签名不合法";
            }
            else if (code.Equals("isv.INVALID_PARAMETERS"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "参数异常";
            }
            else if (code.Equals("isp.SYSTEM_ERROR"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "系统错误";
            }
            else if (code.Equals("isv.MOBILE_NUMBER_ILLEGAL"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "非法手机号码";
            }
            else if (code.Equals("isv.MOBILE_COUNT_OVER_LIMIT"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "手机号码数量超过限制";
            }
            else if (code.Equals("isv.TEMPLATE_MISSING_PARAMETERS"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "模板缺少变量";
            }
            else if (code.Equals("isv.BUSINESS_LIMIT_CONTROL"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "业务限流";
            }
            else if (code.Equals("isv.INVALID_JSON_PARAM"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "JSON参数不合法，只接受字符串值";
            }
            else if (code.Equals("isv.BLACK_KEY_CONTROL_LIMIT"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "黑名单管控";
            }
            else if (code.Equals("isv.PARAM_LENGTH_LIMIT"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "参数超出长度限制";
            }
            else if (code.Equals("isv.PARAM_NOT_SUPPORT_URL"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "不支持URL";
            }
            else if (code.Equals("isv.AMOUNT_NOT_ENOUGH"))
            {
                rsp.IsSuccess = false;
                rsp.ErrorMsg = "账户余额不足";
            }
            return rsp;
        }
    }
}
