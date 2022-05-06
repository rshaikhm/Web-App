using System;
using System.Collections.Generic;

namespace ExternalFTPInjestion.Models
{
    public partial class TblPayrollProvider
    {
        public TblPayrollProvider()
        {
            TblInboundSourceSetup = new HashSet<TblInboundSourceSetup>();
        }

        public int PayrollProviderId { get; set; }
        public int? PayrollProviderTypeLkId { get; set; }
        public string PayrollProviderName { get; set; }
        public byte? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string PayrollProviderCode { get; set; }

        public TblLookup PayrollProviderTypeLk { get; set; }
        public ICollection<TblInboundSourceSetup> TblInboundSourceSetup { get; set; }
    }
}
