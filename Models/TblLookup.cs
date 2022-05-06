using System;
using System.Collections.Generic;

namespace ExternalFTPInjestion.Models
{
    public partial class TblLookup
    {
        public TblLookup()
        {
            TblFileReceived = new HashSet<TblFileReceived>();
            TblInboundSourceSetupFileTypeLk = new HashSet<TblInboundSourceSetup>();
            TblInboundSourceSetupPayrollProviderTypeLk = new HashSet<TblInboundSourceSetup>();
            TblInboundSourceSetupTypeOfIngestionLk = new HashSet<TblInboundSourceSetup>();
            TblPayrollProvider = new HashSet<TblPayrollProvider>();
        }

        public int LookupId { get; set; }
        public string LookupCode { get; set; }
        public int? OrganisationId { get; set; }
        public string SetName { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public int? PrintLookupId { get; set; }
        public byte? SortOrder { get; set; }
        public string Category { get; set; }
        public string SystemYn { get; set; }
        public string IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }

        public ICollection<TblFileReceived> TblFileReceived { get; set; }
        public ICollection<TblInboundSourceSetup> TblInboundSourceSetupFileTypeLk { get; set; }
        public ICollection<TblInboundSourceSetup> TblInboundSourceSetupPayrollProviderTypeLk { get; set; }
        public ICollection<TblInboundSourceSetup> TblInboundSourceSetupTypeOfIngestionLk { get; set; }
        public ICollection<TblPayrollProvider> TblPayrollProvider { get; set; }
    }
}
