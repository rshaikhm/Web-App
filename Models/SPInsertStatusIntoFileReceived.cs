using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExternalFTPInjestion.Models
{
    public class SPInsertStatusIntoFileReceived
    {

        public int FileReceivedId { get; set; }
        public string FileName { get; set; }
        public DateTime? ReceivedDateAndTime { get; set; }
        public int? InboundSourceSetupId { get; set; }
        public string LoadedBy { get; set; }
        public int? FileTypeLkId { get; set; }
        public DateTime? AsOfDate { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string ActualFile { get; set; }
        public string FromEmailId { get; set; }

        public TblLookup FileTypeLk { get; set; }
        //public ICollection<TblHeaderReceived> TblHeaderReceived { get; set; }
    }
}
