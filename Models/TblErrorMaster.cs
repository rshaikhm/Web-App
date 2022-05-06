using System;
using System.Collections.Generic;

namespace ExternalFTPInjestion.Models
{
    public partial class TblErrorMaster
    {
        public int ErrorMessageSetupId { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorCategory { get; set; }
        public string ErrorMsg { get; set; }
        public int? ErrorTypeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
