using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Framework.DataFramework
{
    public interface IRepository<TEntity>
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        List<TEntity> SearchByName(string name);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
