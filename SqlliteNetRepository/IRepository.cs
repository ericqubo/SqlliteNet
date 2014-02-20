using SqlliteNetMallcoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SqlliteNetRepository
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        // Methods
        int Count();
        int Count([Optional, DefaultParameterValue(null)] Expression<Func<TEntity, bool>> filter);
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        void DeleteAll();
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(object id);
        TableQuery<TEntity> GetAll();
        TableQuery<TEntity> GetAll(Expression<Func<TEntity, bool>> filter);
        int Insert(TEntity entity);
        int Update(TEntity entityToUpdate);
    }

 

 

}
