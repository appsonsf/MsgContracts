using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Mdm.Org.MsgContracts
{
    [Serializable]
    public class UserInfoMsg
    {
        public Guid ContactId { get; set; }

        public string ContactSrcId { get; set; }

        public string IdCardNo { get; set; }

        public string Number { get; set; }

        public Guid? UserId { get; set; }

        public string UserName { get; set; }
    }
}
