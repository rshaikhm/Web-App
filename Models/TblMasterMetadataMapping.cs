using System;
using System.Collections.Generic;

namespace ExternalFTPInjestion.Models
{
    public partial class TblMasterMetadataMapping
    {
        public TblMasterMetadataMapping()
        {
            TblMetadataMapping = new HashSet<TblMetadataMapping>();
        }

        public int MasterMetadataMappingId { get; set; }
        public int? InboundSourceSetupId { get; set; }
        public string MappingName { get; set; }
        public byte? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }

        public TblInboundSourceSetup InboundSourceSetup { get; set; }
        public ICollection<TblMetadataMapping> TblMetadataMapping { get; set; }
    }
}
