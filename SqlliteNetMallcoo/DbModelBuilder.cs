using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlliteNetMallcoo
{
    public class DbModelBuilder
    {
        private static List<EntityTypeConfigration> _EntityConfigrationList = null;
        private static List<Type> _EntityList = null;
        private static List<Type> _hasExistEntity = null;
        public DbModelBuilder()
        {
            if (EntityConfigrationList == null)
            {
                _EntityConfigrationList = new List<EntityTypeConfigration>();
                _EntityList = new List<Type>();
                _hasExistEntity = new List<Type>();
                OnModelCreating(EntityConfigrationList);
                BatchCreateTables(EntityList);
            }
        }
        /// <summary>
        /// 自定义表配置
        /// </summary>
        internal List<EntityTypeConfigration> EntityConfigrationList { get { return _EntityConfigrationList; } }
        internal List<Type> EntityList { get { return _EntityList; } }
        internal List<Type> HasExistEntity { get { return _hasExistEntity; } }

        public virtual void OnModelCreating(List<EntityTypeConfigration> EntityConfigrationList)
        {

        }
        public virtual void BatchCreateTables(List<Type> EntityList)
        {
            
        }
    }
}
