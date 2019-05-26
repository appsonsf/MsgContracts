using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Csi.Sms.MsgContracts
{
    /// <summary>
    /// 发送手机验证码
    /// </summary>
    public interface SendMobileCodeCommand
    {
        string[] PhoneNumbers { get; set; }
        string Code { get; set; }
    }
}
