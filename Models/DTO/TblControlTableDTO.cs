using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models.DTO
{
    public class TblControlTableDTO
    {
        public TblControlTableDTO()
        {

        }

        public int ControlTableId { get; set; }
        public int? FileReceivedId { get; set; }
        public int? FileRowCount { get; set; }
        public int? FileHeader1RowCount { get; set; }
        public int? FileFooter1RowCount { get; set; }
        public int? FileHeader2RowCount { get; set; }
        public int? FileFooter2RowCount { get; set; }
        public int? FileHeader3RowCount { get; set; }
        public int? FileFooter3RowCount { get; set; }
        public int? AcquisitionRowCount { get; set; }
        public int? CleansingRowCount { get; set; }
        public int? AcquisitionErrorRowCount { get; set; }
        public int? CleansingErrorRowCount { get; set; }
        public string Status { get; set; }
        public decimal? FileHeader1ControlAmount { get; set; }
        public decimal? FileFooter1ControlAmount { get; set; }
        public decimal? FileHeader2ControlAmount { get; set; }
        public decimal? FileFooter2ControlAmount { get; set; }
        public decimal? FileHeader3ControlAmount { get; set; }
        public decimal? FileFooter3ControlAmount { get; set; }
        public decimal? AcquisitionControlAmount { get; set; }
        public decimal? CleansingControlAmount { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
