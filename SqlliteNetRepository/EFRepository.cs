using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlliteNetMallcoo;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SqlliteNetRepository
{
    public class EFRepository<TEntity> : IEFRepository<TEntity>, IRepository<TEntity> where TEntity : class, new()
    {
        private object locker = new object();
        // Fields
        protected SQLiteConnection dbconn;

        // Methods
        public EFRepository(SQLiteConnection dbConn)
        {
            dbconn = dbConn;
            dbconn.CreateTablePre(typeof(TEntity));
        }
        public int Count()
        {
            return dbconn.Table<TEntity>().Count();
        }
        public int Count(Expression<Func<TEntity, bool>> filter)
        {
            return dbconn.Table<TEntity>().Count(filter);
        }
        public void Delete(object id)
        {
            dbconn.Delete<TEntity>(id);
        }
        public void DeleteAll()
        {
            dbconn.DeleteAll<TEntity>();
        }
        public void Delete(TEntity entityToDelete)
        {
            dbconn.Delete(entityToDelete);
        }
        public TEntity Get(object id)
        {
            return dbconn.Get<TEntity>(id);
        }
        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return dbconn.Table<TEntity>().Where(predicate).FirstOrDefault();
        }
        public TableQuery<TEntity> GetAll()
        {
            return dbconn.Table<TEntity>();
        }
        public TableQuery<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return dbconn.Table<TEntity>().Where(filter);
        }
        public List<TEntity> GetWithDbSetSql(string query, params object[] parameters)
        {
            return dbconn.Query<TEntity>(query, parameters);
        }

        public int Insert(TEntity entity)
        {
            lock (locker)
            {
                return dbconn.Insert(entity);
            }
        }

        public int Update(TEntity entityToUpdate)
        {
            lock (locker)
            {
                return dbconn.Update(entityToUpdate);
            }
        }
    }



}
