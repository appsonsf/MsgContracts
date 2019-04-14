using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Mdm.Org.MsgContracts
{
    /// <summary>
    /// 全量发布的数据根
    /// </summary>
    public interface FullOrgData
    {
        string ModelVersion { get; set; }
        string DataVersion { get; set; }

        List<OrgUnitEntityMsg> OrgUnits { get; set; }

        List<ContactEntityMsg> Contacts { get; set; }
    }
}
