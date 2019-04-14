using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Mdm.Org.MsgContracts
{
    /// <summary>
    /// 用户信息更新事件的数据根
    /// </summary>
    public interface UserInfoUpdated
    {
        List<UserInfoMsg> Users { get; set; }
    }
}
