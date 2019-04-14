using System;
using System.Collections.Generic;

namespace Base.Mdm.Org.MsgContracts
{
    [Serializable]
    public class ContactEntityMsg : UserInfoMsg
    {
        public string Name { get; set; }

        public string SrcId { get; set; }

        public string Mobile { get; set; }

        public int Gender { get; set; }

        public int RelationTypeId { get; set; }

        public List<ContactPositionValueMsg> Positions { get; set; }
    }
}
