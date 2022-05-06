using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models.Repository
{
    public interface IDataRepository<TEntity, TDto>
    {
        IEnumerable<TEntity> GetAll();
        List<string> GetData();
        TEntity Get(long id);
        TEntity Get(long id, string str);
        TDto GetDto(long id);



        //void Add(TEntity entity);
        //void Update(TEntity entityToUpdate, TEntity entity);
        //void Delete(TEntity entity);
    }
}
