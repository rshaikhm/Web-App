using ExternalFTPInjestion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2.Models.DTO;
using Test2.Models.Repository;

namespace Test2.Models
{
    public class DestinationSetupDomain : IDataRepository<TblDestinationSetup, TblDestinationSetupDTO>
    {
        readonly pcssqldbconfigpayroll360devContext _bookStoreContext;

        public DestinationSetupDomain(pcssqldbconfigpayroll360devContext storeContext)
        {
            _bookStoreContext = storeContext;
        }

        public TblDestinationSetup Get(long id)
        {
            _bookStoreContext.ChangeTracker.LazyLoadingEnabled = false;

            var result = _bookStoreContext.TblDestinationSetup
                .SingleOrDefault(b => b.DestinationSetupId == id);

            if (result == null)
            {
                return null;
            }

            return result;
        }

        public TblDestinationSetup Get(long id, string str)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TblDestinationSetup> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<string> GetData()
        {
            throw new NotImplementedException();
        }

        public TblDestinationSetupDTO GetDto(long id)
        {
            throw new NotImplementedException();
        }
    }
}
