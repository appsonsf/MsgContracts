using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Mdm.Org.MsgContracts
{
    [Flags]
    public enum OrgUnitParentType
    {
        /// <summary>
        /// 行政上级，默认parent
        /// </summary>
        Admin = 0,
        /// <summary>
        /// 法定上级，djlb
        /// </summary>
        Legal = 1,
        /// <summary>
        /// 管理上级，glz
        /// </summary>
        Management = 2
    }
}
