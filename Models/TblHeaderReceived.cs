using System;
using System.Collections.Generic;

namespace ExternalFTPInjestion.Models
{
    public partial class TblHeaderReceived
    {
        public int HeaderReceivedId { get; set; }
        public int? HeaderMetadataTableId { get; set; }
        public string HeaderName { get; set; }
        public string HeaderType { get; set; }
        public byte? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? InboundSourceSetupId { get; set; }
        public int? FileReceivedId { get; set; }

        public TblFileReceived FileReceived { get; set; }
        public TblHeaderMetadataTable HeaderMetadataTable { get; set; }
        public TblInboundSourceSetup InboundSourceSetup { get; set; }
    }
}
