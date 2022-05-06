using System;
using System.Collections.Generic;

namespace ExternalFTPInjestion.Models
{
    public partial class TblFrequency
    {
        public int FrequencyId { get; set; }
        public string FrequencyDuration { get; set; }
        public int? Day { get; set; }
        public TimeSpan? Time { get; set; }
        public byte? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTill { get; set; }
    }
}
