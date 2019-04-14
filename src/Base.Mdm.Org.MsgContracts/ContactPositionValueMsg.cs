using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Mdm.Org.MsgContracts
{
    [Serializable]
    public class ContactPositionValueMsg
    {
        public Guid OrgUnitId { get; set; }

        public Guid PositionId { get; set; }

        public string OrgUnitSrcId { get; set; }

        public string PositionSrcId { get; set; }

        public bool IsPrimary { get; set; }
    }
}
