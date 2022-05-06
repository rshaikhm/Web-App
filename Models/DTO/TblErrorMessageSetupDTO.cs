using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models.DTO
{
    public class TblErrorMessageSetupDTO
    {
        public TblErrorMessageSetupDTO()
        {

        }

        public int ErrorMessageSetupId { get; set; }
        public DateTime? ErrorDate { get; set; }
        public int? ErrorId { get; set; }
        public string ErrorName { get; set; }
        public string ErrorType { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
