using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Mdm.Org.MsgContracts
{
    [Serializable]
    public class ContactAddedMsg
    {
        public ContactEntityMsg NewData { get; set; }
    }

    [Serializable]
    public class ContactUpdatedMsg
    {
        public ContactEntityMsg OldData { get; set; }
        public ContactEntityMsg NewData { get; set; }
    }

    [Serializable]
    public class ContactDeletedMsg
    {
        public ContactEntityMsg OldData { get; set; }
    }
}
