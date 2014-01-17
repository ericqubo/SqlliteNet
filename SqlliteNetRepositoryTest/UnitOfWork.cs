using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlliteNetRepositoryTest
{
    public class UnitOfWork : IDisposable
    {
        private Context context;
        public UnitOfWork()
        {
            context = new Context(Context.DatabaseFilePath());
        }

        public SchoolRepository schoolRepository()
        {
            return new SchoolRepository(context);
        }
        public PeopleRepository peopleRepository()
        {
            return new PeopleRepository(context);
        }
        #region IDisposable
        //是否释放资源
        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// 释放资源
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        #endregion
    }
}
