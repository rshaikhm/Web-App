using System;
using System.Collections.Generic;

namespace ExternalFTPInjestion.Models
{
    public partial class TblWebhookMsgHandled
    {
        public int MessageHandledId { get; set; }
        public string HandledMessage { get; set; }
        public string IsActive { get; set; }
        public DateTime? CreateDttm { get; set; }
        public DateTime? UpdateDttm { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
    }
}
