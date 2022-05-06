using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2.Models.DTO;
using Test2.Models.Repository;

namespace ExternalFTPInjestion.Models.Domain
{
    public class FileReceivedDomain : IDataRepository<TblFileReceived, TblFileReceivedDTO>
    {
        public TblFileReceived Get(long id)
        {
            throw new NotImplementedException();
        }

        public TblFileReceived Get(long id, string str)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TblFileReceived> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<string> GetData()
        {
            throw new NotImplementedException();
        }

        public TblFileReceivedDTO GetDto(long id)
        {
            throw new NotImplementedException();
        }
    }
}
