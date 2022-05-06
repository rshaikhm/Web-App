using System;
using System.Collections.Generic;

namespace ExternalFTPInjestion.Models
{
    public partial class TblErrorMessageSetup
    {
        public int ErrorMessageSetupId { get; set; }
        public DateTime? ErrorDate { get; set; }
        public int? ErrorId { get; set; }
        public string ErrorName { get; set; }
        public string ErrorType { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}
