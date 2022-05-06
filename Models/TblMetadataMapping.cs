using System;
using System.Collections.Generic;

namespace ExternalFTPInjestion.Models
{
    public partial class TblMetadataMapping
    {
        public int MetadataMappingId { get; set; }
        public int? MasterMetadataMappingId { get; set; }
        public int? InboundSourceSetupId { get; set; }
        public string SourceColumnName { get; set; }
        public string DestinationTableName { get; set; }
        public string DestinationColumnName { get; set; }
        public string SourceDataType { get; set; }
        public int? ColumnOrder { get; set; }
        public string Format { get; set; }
        public byte? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string SourceType { get; set; }
        public string SourceTableName { get; set; }

        public TblInboundSourceSetup InboundSourceSetup { get; set; }
        public TblMasterMetadataMapping MasterMetadataMapping { get; set; }
    }
}
