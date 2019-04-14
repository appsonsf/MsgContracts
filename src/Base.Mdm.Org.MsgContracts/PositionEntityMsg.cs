using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Mdm.Org.MsgContracts
{
    [Serializable]
    public class PositionEntityMsg
    {
        public Guid Id { get; set; }

        public string SrcId { get; set; }

        public string Name { get; set; }
    }
}
