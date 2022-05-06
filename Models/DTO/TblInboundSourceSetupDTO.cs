using ExternalFTPInjestion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models.DTO
{
    public class TblInboundSourceSetupDTO
    {
        public TblInboundSourceSetupDTO()
        {

        }

        public static TblInboundSourceSetupDTO MapToDto(TblInboundSourceSetup objTblInboundSourceSetup)
        {
            return new TblInboundSourceSetupDTO()
            {
                InboundSourceSetupId = objTblInboundSourceSetup.InboundSourceSetupId,
               
            };
        }

        public int InboundSourceSetupId { get; set; }
        public int? TypeOfIngestionId { get; set; }
        public string SourceUrl { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public int? PayrollProviderId { get; set; }
        public string FrequencyId { get; set; }
        public string ConnectionPort { get; set; }
        public string SourceFolderPath { get; set; }
        public string FromEmailId { get; set; }
        public string ApiName { get; set; }
        public string FileType { get; set; }
        public string FileNamePattern { get; set; }
        public string PayrollProviderName { get; set; }
        public string Delimiter { get; set; }
        public string IsHeaderAvailable { get; set; }
        public string SummarySection { get; set; }
        public int? DataHeaderRow { get; set; }
        public int? DataStartRow { get; set; }
        public int? FooterStartRow { get; set; }
        public string HierarchialData { get; set; }
        public string GetOrPut { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string IsActive { get; set; }
        public int? DestinationSetupId { get; set; }
    }
}
