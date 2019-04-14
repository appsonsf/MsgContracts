using System;

namespace Base.Mdm.Org.MsgContracts
{
    [Serializable]
    public class OrgUnitParentValueMsg
    {
        public Guid? Id { get; set; }

        public string SrcId { get; set; }

        public OrgUnitParentType Type { get; set; }
    }
}