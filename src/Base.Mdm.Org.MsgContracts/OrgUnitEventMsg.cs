using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Mdm.Org.MsgContracts
{
    [Serializable]
    public class OrgUnitAddedMsg
    {
        public OrgUnitEntityMsg NewData { get; set; }
    }

    [Serializable]
    public class OrgUnitUpdatedMsg
    {
        public OrgUnitEntityMsg OldData { get; set; }
        public OrgUnitEntityMsg NewData { get; set; }
    }

    [Serializable]
    public class OrgUnitDeletedMsg
    {
        public OrgUnitEntityMsg OldData { get; set; }
    }
}
