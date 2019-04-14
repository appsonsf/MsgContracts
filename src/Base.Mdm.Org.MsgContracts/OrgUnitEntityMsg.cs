using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Mdm.Org.MsgContracts
{
    [Serializable]
    public class OrgUnitEntityMsg
    {
       public Guid Id { get; set; }
       public string SrcId { get; set; }
       public string Number { get; set; }
       public string Name { get; set; }
       public int TypeId { get; set; }
       public int Sort { get; set; }
       public List<OrgUnitParentValueMsg> Parents { get; set; }
       public List<PositionEntityMsg> Positions { get; set; }
    }
}
