using System;
using System.Collections.Generic;

namespace ExternalFTPInjestion.Models
{
    public partial class TblHeaderMetadataTable
    {
        public TblHeaderMetadataTable()
        {
            TblHeaderReceived = new HashSet<TblHeaderReceived>();
        }

        public int HeaderMetadataTableId { get; set; }
        public string HeaderColumnName { get; set; }
        public string HeaderColumnMeaning { get; set; }
        public byte? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? InboundSourceSetupId { get; set; }
        public int? SortOrder { get; set; }
        public string ColumnFormat { get; set; }

        public TblInboundSourceSetup InboundSourceSetup { get; set; }
        public ICollection<TblHeaderReceived> TblHeaderReceived { get; set; }
    }
}
