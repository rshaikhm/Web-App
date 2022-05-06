using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2.Models.DTO;
using Test2.Models.Repository;
using Microsoft.EntityFrameworkCore;

namespace Test2.Models.Domain
{
    public class ExternalFTPDomain : IDataRepository<TblInboundSourceSetup, TblInboundSourceSetupDTO>
    {
        readonly PcsSqldbConfigPayroll360DevContext _configContext;

        //public ExternalFTPDomain()
        //{
        //}

        public ExternalFTPDomain(PcsSqldbConfigPayroll360DevContext storeContext)
        {
            _configContext = storeContext;
        }
        //public IEnumerable<TblInboundSourceSetup> GetAll()
        //{
        //    //return _bookStoreContext..Author
        //    //    .Include(author => author.AuthorContact)
        //    //    .ToList();
        //}

        public TblInboundSourceSetup Get(long id)
        {
            var inboundSourceSetup = _configContext.TblInboundSourceSetup
                .SingleOrDefault(b => b.InboundSourceSetupId == id);

            return inboundSourceSetup;
        }

        public TblInboundSourceSetupDTO GetDto(long id)
        {
            _configContext.ChangeTracker.LazyLoadingEnabled = true;

            using (var context = new PcsSqldbConfigPayroll360DevContext())
            {
                var author = context.TblInboundSourceSetup
                    .SingleOrDefault(b => b.InboundSourceSetupId == id);

                return TblInboundSourceSetupDTO.MapToDto(author);
            }
        }
    }
}
