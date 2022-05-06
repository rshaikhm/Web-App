using ExternalFTPInjestion.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2.Models.DTO;
using Test2.Models.Repository;

namespace Test2.Models.Domain
{
    public class InboundSourceSetupDomain : IDataRepository<TblInboundSourceSetup, TblInboundSourceSetupDTO>
    {
        readonly pcssqldbconfigpayroll360devContext _dbContext;// _bookStoreContext;
        public InboundSourceSetupDomain(pcssqldbconfigpayroll360devContext storeContext)
        {
            _dbContext = storeContext;
        }

        public IEnumerable<TblInboundSourceSetup> GetAll()

        {
                return _dbContext.TblInboundSourceSetup
                .Include(x => x.FileNamePattern)
                .ToList();
        }

        public TblInboundSourceSetup Get(long id, string mailId)
        {
            var result = _dbContext.TblInboundSourceSetup
                 .SingleOrDefault(b => b.TypeOfIngestionLkId == id && b.FromEmailId == mailId);

            //List<string> result = new List<string>();
            //result = _dbContext.TblInboundSourceSetup.Select(x => x.FileNamePattern).ToList();
            return result;
        }

        //public TblInboundSourceSetup Get(long id)
        //{
        //    var result = _dbContext.TblInboundSourceSetup
        //         .SingleOrDefault(b => b.TypeOfIngestionLkId == id && b.FromEmailId == mailId);

        //    //List<string> result = new List<string>();
        //    //result = _dbContext.TblInboundSourceSetup.Select(x => x.FileNamePattern).ToList();
        //    return result;
        //}

        public List<string> GetData()
        {
            
            List<string> result = new List<string>();
            result = _dbContext.TblInboundSourceSetup.Select(x => x.FileNamePattern).Distinct().ToList();
            return result;
        }
       

        public TblInboundSourceSetupDTO GetDto(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(TblInboundSourceSetup entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(TblInboundSourceSetup entityToUpdate, TblInboundSourceSetup entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TblInboundSourceSetup entity)
        {
            throw new System.NotImplementedException();
        }

        public TblInboundSourceSetup Get(long id)
        {
            throw new NotImplementedException();
        }

    }
}
