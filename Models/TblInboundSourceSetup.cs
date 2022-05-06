using System;
using System.Collections.Generic;

namespace ExternalFTPInjestion.Models
{
    public partial class TblInboundSourceSetup
    {
        //public TblInboundSourceSetup()
        //{
        //    TblHeaderMetadataTable = new HashSet<TblHeaderMetadataTable>();
        //    TblHeaderReceived = new HashSet<TblHeaderReceived>();
        //    TblMasterMetadataMapping = new HashSet<TblMasterMetadataMapping>();
        //    TblMetadataMapping = new HashSet<TblMetadataMapping>();
        //}

        public int InboundSourceSetupId { get; set; }
        public int? TypeOfIngestionLkId { get; set; }
        public string SourceUrl { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public int? PayrollProviderTypeLkId { get; set; }
        public int? FrequencyId { get; set; }
        public int? DestinationSetupId { get; set; }
        public string ConnectionPort { get; set; }
        public string SourceFolderPath { get; set; }
        public string FromEmailId { get; set; }
        public string ApiName { get; set; }
        public int? FileTypeLkId { get; set; }
        public string FileNamePattern { get; set; }
        public int? PayrollProviderId { get; set; }
        public string Delimiter { get; set; }
        public string IsColumnHeaderAvailable { get; set; }
        public string IsHeaderRowAvailable { get; set; }
        public string IsColumnFooterHeaderAvailable { get; set; }
        public string IsFooterRowAvailable { get; set; }
        public int? DataHeaderRow { get; set; }
        public int? DataStartRow { get; set; }
        public int? FooterStartRow { get; set; }
        public string HierarchialData { get; set; }
        public string GetOrPut { get; set; }
        public byte? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public int? FilenameStructureParts { get; set; }
        public string StorageFolderName { get; set; }
        public string SheetName { get; set; }

        public TblDestinationSetup DestinationSetup { get; set; }
        public TblLookup FileTypeLk { get; set; }
        public TblPayrollProvider PayrollProvider { get; set; }
        public TblLookup PayrollProviderTypeLk { get; set; }
        public TblLookup TypeOfIngestionLk { get; set; }
        //public ICollection<TblHeaderMetadataTable> TblHeaderMetadataTable { get; set; }
        //public ICollection<TblHeaderReceived> TblHeaderReceived { get; set; }
        //public ICollection<TblMasterMetadataMapping> TblMasterMetadataMapping { get; set; }
        //public ICollection<TblMetadataMapping> TblMetadataMapping { get; set; }
    }
}
