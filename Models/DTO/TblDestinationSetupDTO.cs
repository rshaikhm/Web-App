using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models.DTO
{
    public class TblDestinationSetupDTO
    {
        public TblDestinationSetupDTO()
        {

        }
        public int DestinationSetupId { get; set; }
        public string DestinationUrl { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string ConnectionPort { get; set; }
        public string DestinationFolderPath { get; set; }
    }
}
