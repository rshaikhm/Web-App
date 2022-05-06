using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models.DTO
{
    public class TblMetadataMappingDTO
    {
        public TblMetadataMappingDTO()
        {

        }

        public int MetadataMappingId { get; set; }
        public int? InboundSourceSetupId { get; set; }
        public string SourceColumnName { get; set; }
        public string DestinationTableName { get; set; }
        public string DestinationColumnName { get; set; }
        public string SourceDataType { get; set; }
        public string Format { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte? IsActive { get; set; }
    }
}
