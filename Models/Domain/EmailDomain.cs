using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2.Models.DTO;
using Test2.Models.Repository;

namespace Test2.Models.Domain
{
    
    public class EmailDomain : IDataRepository<TblInboundSourceSetup, TblInboundSourceSetupDTO>
    {
        readonly pcssqldbconfigpayroll360devContext _bookStoreContext;

        public EmailDomain(pcssqldbconfigpayroll360devContext storeContext)
        {
            _bookStoreContext = storeContext;
        }

        public IEnumerable<TblInboundSourceSetup> GetAll()
        {
            return _bookStoreContext.TblInboundSourceSetup
                .Include(TblInboundSourceSetup => TblInboundSourceSetup.FileNamePattern)
                .ToList();  
        }

        public TblInboundSourceSetup Get(long id)
        {
            _bookStoreContext.ChangeTracker.LazyLoadingEnabled = false;

            //var book = _bookStoreContext.TblInboundSourceSetup
            //    .SingleOrDefault(b => b.InboundSourceSetupId == id);
            var book = _bookStoreContext.TblInboundSourceSetup
                .SingleOrDefault(b => b.TypeOfIngestionLkId == id);


            if (book == null)
            {
                return null;
            }

            //_bookStoreContext.Entry(book)
            //    .Collection(b => b.InboundSourceSetupId)
            //    .Load();

            //_bookStoreContext.Entry(book)
            //    .Reference(b => b.InboundSourceSetupId)
            //    .Load();

            return book;
        }

        public TblInboundSourceSetupDTO GetDto(long id)
        {
            throw new System.NotImplementedException();
        }

        //public void Add(Book entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void Update(Book entityToUpdate, Book entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void Delete(Book entity)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
