using System;
using System.Collections.Generic;

namespace ExternalFTPInjestion.Models
{
    public partial class TblDestinationSetup
    {
        public TblDestinationSetup()
        {
            TblInboundSourceSetup = new HashSet<TblInboundSourceSetup>();
        }

        public int DestinationSetupId { get; set; }
        public string DestinationUrl { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string ConnectionPort { get; set; }
        public string DestinationFolderPath { get; set; }
        public string ErrorFolderPath { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public ICollection<TblInboundSourceSetup> TblInboundSourceSetup { get; set; }
    }
}
