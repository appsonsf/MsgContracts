using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Mdm.Org.MsgContracts
{
    /// <summary>
    /// 事件发布的事件根
    /// </summary>
    public interface OrgDataEvent
    {
        string ModelVersion { get; set; }
        string DataVersion { get; set; }

        List<OrgUnitAddedMsg> OrgUnitAddeds { get; set; }
        List<OrgUnitUpdatedMsg> OrgUnitUpdateds { get; set; }
        List<OrgUnitDeletedMsg> OrgUnitDeleteds { get; set; }
        List<ContactAddedMsg> ContactAddeds { get; set; }
        List<ContactUpdatedMsg> ContactUpdateds { get; set; }
        List<ContactDeletedMsg> ContactDeleteds { get; set; }
    }
}
