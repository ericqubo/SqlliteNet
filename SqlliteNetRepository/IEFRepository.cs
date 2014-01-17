using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlliteNetRepository
{
    public interface IEFRepository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        // Methods
        //DbSet<TEntity> GetDbSet();
        IQueryable<TEntity> GetWithDbSetSql(string query, params object[] parameters);
    }
}
