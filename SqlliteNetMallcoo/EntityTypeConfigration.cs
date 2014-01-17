using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlliteNetMallcoo
{
    public class EntityTypeConfigration
    {
        internal string FullName { get; private set; }

        internal string PK { get; set; }

        internal bool IsAutoPK { get; set; }

        public EntityTypeConfigration HasKey(string keyName)
        {
            this.PK = keyName;
            return this;
        }

        public EntityTypeConfigration IsAutoPKInCrease(bool isauto)
        {
            this.IsAutoPK = isauto;
            return this;
        }
        /// <summary>
        ///构造函数
        /// </summary>
        /// <param name="FullName">type 的完全限定名</param>
        public EntityTypeConfigration(string FullName)
        {
            this.FullName = FullName;
        }
    }
}
