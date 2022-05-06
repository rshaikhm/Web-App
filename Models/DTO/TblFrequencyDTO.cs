using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models.DTO
{
    public class TblFrequencyDTO
    {
        public TblFrequencyDTO()
        {

        }

        public int FrequencyId { get; set; }
        public string FrequencyDuration { get; set; }
        public int? Day { get; set; }
        public TimeSpan? Time { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte? IsActive { get; set; }
    }
}
